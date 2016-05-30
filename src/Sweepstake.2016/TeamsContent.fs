namespace AOrNotA.Sweepstake2016

open System

open AOrNotA.Sweepstake2016.Content
open AOrNotA.Sweepstake2016.Domain
open AOrNotA.Sweepstake2016.Sweepstake

module TeamsContent =

    let linksHtml =
        let groupRow group =
            let groupCells =
                let teamCell (team: Team) = td (linkToAnchor2 team.Name (getTeamTextWithStrike team (getTeamNameWithSeeding team)))
                let teamCells = getGroupTeams group |> List.map teamCell
                let label = getGroupLabel group
                [ td (bold (sprintf "Group %s" label)) ] @
                teamCells @
                [ td (linkToAnchor2 (sprintf "Group %s fixtures/results" label) "fixtures/results") ]
            tr groupCells
        table (Some 100) (groups2016 |> List.collect groupRow) @
        [ para (linkToAnchor "Knockout fixtures/results") ]

    let getTeamsLinksHtml () = linksHtml
                               |> concatenateWithNewLine

    let fixtureHtml ``match`` =
        let team1, team2 = getTeam ``match``.Team1Score, getTeam ``match``.Team2Score
        let team1Goals, team2Goals = getGoals ``match``.Team1Score, getGoals ``match``.Team2Score
        let result = match (matchHasStarted ``match``) with
                     | false -> td (sprintf "%s vs %s" (linkToAnchor team1.Name) (linkToAnchor team2.Name))
                     | true -> let shootoutDetails = match (isKnockout ``match``) with
                                                     | false -> None
                                                     | true -> match team1Goals, team2Goals with
                                                               | team1Goals, team2Goals when team1Goals <> team2Goals -> None
                                                               | _ -> let team1ShootoutPenalties, team2ShootoutPenalties = getShootoutPenalties ``match``.Team1Score, getShootoutPenalties ``match``.Team2Score
                                                                      if team1ShootoutPenalties.IsNone || team2ShootoutPenalties.IsNone then failwith (sprintf "Missing penalty shootout information for knockout match %d." ``match``.Number)
                                                                      else let team1ShootoutPenalties', team2ShootoutPenalties' = team1ShootoutPenalties.Value, team2ShootoutPenalties.Value
                                                                           let winner, winningPenalties, losingPenalties = if team1ShootoutPenalties' > team2ShootoutPenalties' then team1, team1ShootoutPenalties', team2ShootoutPenalties'
                                                                                                                           else if team1ShootoutPenalties < team2ShootoutPenalties then team2, team2ShootoutPenalties', team1ShootoutPenalties'
                                                                                                                           else failwith (sprintf "Penalty shootout cannot be a draw for knockout match %d" ``match``.Number)
                                                                           Some (sprintf "%s win %d - %d on penalties" winner.Name winningPenalties losingPenalties)
                               // TODO: More details (e.g. MatchEvents &c.)?...
                               match shootoutDetails with
                               | Some shootoutDetails' -> td (sprintf "%s %d - %d %s (%s)" (linkToAnchor team1.Name) (int team1Goals) (int team2Goals) (linkToAnchor team2.Name) shootoutDetails')
                               | _ -> td (sprintf "%s %d - %d %s" (linkToAnchor team1.Name) (int team1Goals) (int team2Goals) (linkToAnchor team2.Name))
        let kickOff = td (sprintf "%s %s" (``match``.KickOff.DayOfWeek.ToString ()) (``match``.KickOff.ToString ("dd-MMM-yyyy HH:mm")))
        let stage = match ``match``.Stage with | Group _ -> [] | _ -> [ td (getStage ``match``.Stage) ]
        tr (stage @ [ kickOff; result ])

    let groupsHtml =
        let teamHeaderRow = tr ( [ td (bold "Coach")
                                   td (bold "Seeding")
                                   td (bold "Picked by")
                                   td (bold "2016 score") ] )
        let playersHeaderRow = tr ( [ td (bold "Name")
                                      td (bold "Type")
                                      td (bold "Picked by")
                                      td (bold "2016 score") ] )
        let groupHtml group =
            let teamsHtml =
                let teamHtml (team: Team) =
                    let teamRow = tr ( [ td (getTeamTextWithStrike team team.Coach)
                                         td (getTeamSeeding team)
                                         td (getTeamPickedBy team)
                                         td (getTeamScoreText2016 team) ] )
                    let playerRow player = tr ( [ td (getPlayerNameWithStrike player)
                                                  td (getPlayerTypeAndStatus player)
                                                  td (getPlayerPickedByText player)
                                                  td (getPlayerAndPickScoreText2016 player) ] )
                    let players = players2016 |> List.filter (fun (player, _) -> player.Team = team)
                                              |> List.map (fun (player, _) -> player)
                    [ h3 (anchor2 team.Name (getTeamTextWithStrike team (getTeamNameWithSeeding team))) ] @
                    table (Some 80) (teamHeaderRow @ teamRow) @
                    table (Some 100) (playersHeaderRow @ (players |> List.collect playerRow))
                getGroupTeams group |> List.collect teamHtml
            let label = getGroupLabel group
            let fixturesHtml = matches2016 |> List.filter (fun ``match`` -> not (isKnockout ``match``))
                                           |> List.filter (fun ``match`` -> getGroupLabel ``match``.Stage = label)
                                           |> List.sortBy (fun ``match`` -> ``match``.Number)
                                           |> List.collect fixtureHtml
            [ h2 (sprintf "Group %s" label) ] @
            teamsHtml @
            [ h3 (anchor (sprintf "Group %s fixtures/results" label)) ] @
            table (Some 80) fixturesHtml
        groups2016 |> List.collect groupHtml

    let knockoutFixturesHtml =
        let fixturesHtml = matches2016 |> List.filter (fun ``match`` -> isKnockout ``match``)
                                       |> List.sortBy (fun ``match`` -> ``match``.Number)
                                       |> List.collect fixtureHtml
        [ h3 (anchor "Knockout fixtures/results") ] @
        table (Some 100) fixturesHtml

    let getTeamsHtml () = groupsHtml @ knockoutFixturesHtml
                          |> concatenateWithNewLine

