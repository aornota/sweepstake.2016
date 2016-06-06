namespace AOrNotA.Sweepstake2016

open System

open AOrNotA.Sweepstake2016.Content
open AOrNotA.Sweepstake2016.Domain
open AOrNotA.Sweepstake2016.Sweepstake
open AOrNotA.Sweepstake2016.``Sweepstake 2016``

module IndexContent =

    let getSweepstakerTeamScore sweepstaker = match sweepstaker.CoachTeam with | Some team' -> match getTeamScore2016 team' with | Some score -> score
                                                                                                                                 | None -> 0<score>
                                                                               | None -> 0<score>
                                                                               
    let getSweepstakerPlayersScore sweepstaker = sweepstaker.Picks |> List.map (fun pick -> match getPlayerPickScore2016 pick.Player with | Some score -> score
                                                                                                                                          | None -> 0<score>)
                                                                   |> List.sum

    let getSweepstakerScore sweepstaker = getSweepstakerTeamScore sweepstaker + getSweepstakerPlayersScore sweepstaker

    let getTeamWithCoach sweepstaker = match sweepstaker.CoachTeam with | Some team -> getTeamTextWithStrike team (getTeamNameWithCoach team) | None -> ""

    let sweepstakerLinksHtml =
        let sweepstakerCell sweepstaker = [ td (linkToAnchor (getParticipant sweepstaker)) ]
        table (Some 100) (tr ( [ td (bold "Sweepstakers") ] @
                              (sweepstakers |> List.collect sweepstakerCell) ))

    let standingsHtml =
        let standingsHeaderRow = tr ( [ td (bold "Name")
                                        td (bold "Team/coach")
                                        td (bold "Formation")
                                        td (bold "Players remaining")
                                        td (bold "Score") ] )
        let sweepstakersHtml =
            let sweepstakerRow (sweepstaker, score) =
                let remainingPlayers = sweepstaker.Picks |> List.filter (fun pick -> getPlayerIsActive pick.Player)
                                                         |> List.length
                let defenders = sweepstaker.Picks |> List.filter (fun pick -> getPlayerIsDefender pick.Player)
                                                  |> List.length
                let midfielders = sweepstaker.Picks |> List.filter (fun pick -> getPlayerIsMidfielder pick.Player)
                                                    |> List.length
                let forwards = sweepstaker.Picks |> List.filter (fun pick -> getPlayerIsForward pick.Player)
                                                 |> List.length
                tr ( [ td (linkToAnchor (getParticipant sweepstaker))
                       td (getTeamWithCoach sweepstaker)
                       td (sprintf "%d-%d-%d" defenders midfielders forwards)
                       td (sprintf "%d" remainingPlayers)
                       td (sprintf "%d" (int score)) ] )
            let sweepstakerScores = sweepstakers |> List.map (fun sweepstaker -> sweepstaker, getSweepstakerScore sweepstaker)
                                                 |> List.sortBy (fun (_, score) -> -score)
            table (Some 100) (standingsHeaderRow @ (sweepstakerScores |> List.collect sweepstakerRow))
        [ h2 (anchor "Standings") ] @
        sweepstakersHtml

    let linksHtml = table (Some 100) (tr ( [ td (bold "Top")
                                             td (linkToAnchor2 "Top teams/coaches" "teams/coaches")
                                             td (linkToAnchor2 "Top players" "players")
                                             td (linkToAnchor2 "Top goalkeepers" "goalkeepers")
                                             td (linkToAnchor2 "Top defenders" "defenders")
                                             td (linkToAnchor2 "Top midfielders" "midfielders")
                                             td (linkToAnchor2 "Top forwards" "forwards") ] ) @
                                      tr ( [ td (bold "Best unpicked") 
                                             td (linkToAnchor2 "Best unpicked teams/coaches" "teams/coaches")
                                             td (linkToAnchor2 "Best unpicked players" "players")
                                             td (linkToAnchor2 "Best unpicked goalkeepers" "goalkeepers")
                                             td (linkToAnchor2 "Best unpicked defenders" "defenders")
                                             td (linkToAnchor2 "Best unpicked midfielders" "midfielders")
                                             td (linkToAnchor2 "Best unpicked forwards" "forwards") ] ))

    let getIndexStandingsAndLinksHtml () = sweepstakerLinksHtml @ [ para "" ] @
                                           standingsHtml @
                                           [ para "" ] @ linksHtml
                                           |> concatenateWithNewLine

    let sweepstakersHtml =
        let isGoalkeeper pick = match pick.Player.Type with | Goalkeeper -> true | _ -> false
        let pluralize noun count = if count = 1 then noun else sprintf "%ss" noun
        let picksHeaderRow = tr ( [ td (bold "Name")
                                    td (bold "Team")
                                    td (bold "Type")
                                    td ("") // only scores from (if relevant)
                                    td (bold "Score") ] )
        let sweepstakerHtml sweepstaker =
            let coachHtml sweepstaker =
                match sweepstaker.CoachTeam with
                | Some team -> table (Some 70) (tr ( [ td (bold "Team/coach")
                                                       td (bold "Seeding")
                                                       td (bold "Score") ] ) @
                                                tr ( [ td (getTeamWithCoach sweepstaker)
                                                       td (getTeamSeeding team)
                                                       td (sprintf "%d" (getSweepstakerTeamScore sweepstaker)) ] ))
                | None -> [ para (italic "Team/coach still to be picked...") ]
            let picksHtml sweepstaker =
                let playerTypeOrder playerType = match playerType with | Goalkeeper -> 1 | Defender -> 2 | Midfielder -> 3 | Forward -> 4
                let pickRow pick = tr ( [ td (getPlayerNameWithStrike pick.Player)
                                          td (getTeamTextWithStrike pick.Player.Team pick.Player.Team.Name)
                                          td (getPlayerTypeAndStatus pick.Player)
                                          td (getPickOnlyScoresFrom pick)
                                          td (getPlayerPickScoreText2016 pick.Player) ] )
                let goalkeepers = sweepstaker.Picks |> List.filter (fun pick -> isGoalkeeper pick)
                                                    |> List.filter (fun pick -> not (getPlayerIsWithdrawn pick.Player))
                let outfieldPlayers = sweepstaker.Picks |> List.filter (fun pick -> not (isGoalkeeper pick))
                                                        |> List.filter (fun pick -> not (getPlayerIsWithdrawn pick.Player))
                let goalkeepersToPick = requiredGoalkeepers - (goalkeepers |> List.length)
                let outfieldPlayersToPick = requiredOutfieldPlayers - (outfieldPlayers |> List.length)
                let toPickHtml = match goalkeepersToPick, outfieldPlayersToPick with
                                 | 0, 0 -> [ para (italic "The required number of goalkeepers and outfield players have been picked") ]
                                 | _, 0 -> [ para (italic (sprintf "%d %s still to be picked..." goalkeepersToPick (pluralize "goalkeeper" goalkeepersToPick))) ]
                                 | 0, _ -> [ para (italic (sprintf "%d %s still to be picked..." outfieldPlayersToPick (pluralize "outfield player" outfieldPlayersToPick))) ]
                                 | _ -> [ para (italic (sprintf "%d %s and %d %s still to be picked..." goalkeepersToPick (pluralize "goalkeeper" goalkeepersToPick) outfieldPlayersToPick (pluralize "outfield player" outfieldPlayersToPick))) ]
                let sorted = sweepstaker.Picks |> List.sortBy (fun pick -> (playerTypeOrder pick.Player.Type) + if (getPlayerIsActive pick.Player) then 0 else 1000)
                (match sorted |> List.length with | 0 -> []
                                                  | _ -> table (Some 100) (picksHeaderRow @ (sorted |> List.collect pickRow))) @
                toPickHtml
            [ h3 (anchor (getParticipant sweepstaker) + (sprintf ": %d"  (getSweepstakerScore sweepstaker))) ] @
            coachHtml sweepstaker @
            picksHtml sweepstaker
        sweepstakers |> List.collect (fun sweepstaker -> sweepstakerHtml sweepstaker)

    let unpickedAnchor unpicked = match unpicked with | true -> "Best unpicked" | false -> "Top"
    let playerTypeText playerType = match playerType with | Some playerType' -> match playerType' with | Goalkeeper -> "goalkeepers"
                                                                                                       | Defender -> "defenders"
                                                                                                       | Midfielder -> "midfielders"
                                                                                                       | Forward -> "forwards"
                                                          | None -> "players"

    let topN n list = if list |> List.length > n then list |> Seq.ofList |> Seq.take n |> List.ofSeq
                      else list

    let teamScoresHtml unpicked =
        let teamsHeaderRow = tr ( [ td (bold "Team")
                                    td (bold "Seeding")
                                    td (bold "Coach") ] @
                                  (if unpicked then [] else [ td (bold "Picked by") ] ) @
                                  [ td (bold "Score") ] )
        let teamsHtml teamScores =
            let teamRow (team, score) = tr ( [ td (getTeamTextWithStrike team team.Name)
                                               td (getTeamSeeding team)
                                               td team.Coach ] @
                                             (if unpicked then [] else [ td (getTeamPickedBy team) ] ) @
                                             [ td (sprintf "%d" (int score)) ] )
            table (Some (if unpicked then 70 else 80)) (teamsHeaderRow @ (teamScores |> List.collect teamRow))
        let picked team = getTeamPickedBy team <> ""
        let matching unpicked picked = if unpicked then not picked else true
        let topScoring = teamScores2016 |> List.filter (fun (team, _) -> matching unpicked (picked team))
                                        |> List.filter (fun (_, score) -> score > 0<score>)
                                        |> List.sortBy (fun (_, score) -> -score)
                                        |> topN 16
        let scoresHtml = if topScoring |> List.length = 0 then [ para (italic "Coming soon...") ]
                         else topScoring |> teamsHtml
        [ h3 (anchor (sprintf "%s teams/coaches" (unpickedAnchor unpicked))) ] @
        scoresHtml

    let playerScoresHtml unpicked (playerType: PlayerType option) =
        let playersHeaderRow = tr ( [ td (bold "Name")
                                      td (bold "Team") ] @
                                    (if playerType.IsSome then [ td "" ] else [ td (bold "Type") ] ) @
                                    (if unpicked then [] else [ td (bold "Picked by") ] ) @
                                    [ td (bold "Score") ] )
        let playersHtml players =
            let playerRow player = tr ( [ td (getPlayerNameWithStrike player)
                                          td (getTeamTextWithStrike player.Team player.Team.Name) ] @
                                        (if playerType.IsSome then
                                             match getPlayerStatus player with | Some status -> [ td status ]
                                                                               | None -> [ td "" ]
                                         else [ td (getPlayerTypeAndStatus player) ] ) @
                                        (if unpicked then [] else [ td (getPlayerPickedByText player) ] ) @
                                        [ td (sprintf "%s" (getPlayerAndPickScoreText2016 player)) ] )
            table (Some (if unpicked then 80 else 100)) (playersHeaderRow @ (players |> List.collect playerRow))
        let picked player = (getPlayerPickedBy player).IsSome
        let matching unpicked picked = if unpicked then not picked else true
        let matching' playerType player = match playerType with
                                          | Some playerType' -> playerType' = player.Type
                                          | None -> true
        let topScoring = playerScores2016 |> List.filter (fun (player, _) ->
                                                              matching unpicked (picked player) && matching' playerType player)
                                          |> List.filter (fun (_, score) -> score > 0<score>)
                                          |> List.sortBy (fun (_, score) -> -score)
                                          |> List.map (fun (player, _) -> player)
                                          |> topN 20
        let scoresHtml = if topScoring |> List.length = 0 then [ para (italic "Coming soon...") ]
                         else topScoring |> playersHtml
        [ h3 (anchor (sprintf "%s %s" (unpickedAnchor unpicked) (playerTypeText playerType))) ] @
        scoresHtml

    let getIndexHtml () = sweepstakersHtml @
                          teamScoresHtml false @
                          playerScoresHtml false None @
                          playerScoresHtml false (Some Goalkeeper) @
                          playerScoresHtml false (Some Defender) @
                          playerScoresHtml false (Some Midfielder) @
                          playerScoresHtml false (Some Forward) @
                          teamScoresHtml true @
                          playerScoresHtml true None @
                          playerScoresHtml true (Some Goalkeeper) @
                          playerScoresHtml true (Some Defender) @
                          playerScoresHtml true (Some Midfielder) @
                          playerScoresHtml true (Some Forward)
                          |> concatenateWithNewLine

