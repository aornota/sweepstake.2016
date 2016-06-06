namespace AOrNotA.Sweepstake2016

open System
open System.Text

open AOrNotA.Sweepstake2016.Domain
open AOrNotA.Sweepstake2016.Sweepstake

module Content =

    let concatenateWithNewLine (lines: string list) =
        let append (state: StringBuilder) (line: string) = state.Append (sprintf "%s\n" line)
        let builder = lines |> List.fold append (StringBuilder ())
        builder.ToString ()

    let h2 text = sprintf "<h2>%s</h2>" text
    let h3 text = sprintf "<h3>%s</h3>" text
    let para text = sprintf "<p>%s</p>" text
    let bold text = sprintf "<b>%s</b>" text
    let italic text = sprintf "<i>%s</i>" text
    let orderedList items = [ "<ol>" ] @ items @ [ "</ol>" ]
    let unorderedList items = [ "<ul>" ] @ items @ [ "</ul>" ]
    let listItem text = sprintf "<li>%s</li>" text
    let anchor2 name text = sprintf """<a name="%s">%s</a>""" name text
    let anchor nameAndText = anchor2 nameAndText nameAndText
    let link content anchor text = match content, anchor with | Some content', Some anchor' -> sprintf """<a href="%s.html#%s">%s</a>""" content' anchor' text
                                                              | Some content', None -> sprintf """<a href="%s.html">%s</a>""" content' text
                                                              | None, Some anchor' -> sprintf """<a href="#%s">%s</a>""" anchor' text
                                                              | None, None -> text
    let linkToContent content text = link (Some content) None text
    let linkToAnchor2 name text = link None (Some name) text
    let linkToAnchor nameAndText = linkToAnchor2 nameAndText nameAndText
    let linkToContentAnchor content anchor text = link (Some content) (Some anchor) text
    let strike text = sprintf "<strike>%s</strike>" text
    let table width rows =
        let tag = match width with | Some width' -> sprintf """<table style="width:%d%%">""" width' | None -> "<table>"
        [ tag ] @ rows @ [ "</table>" ]
    let tr cells = [ "<tr>" ] @ cells @ [ "</tr>"]
    let td text = sprintf "\t\t<td>%s</td>" text

    [<Literal>]
    let requiredGoalkeepers = 1
    [<Literal>]
    let requiredOutfieldPlayers = 10

    let getLastUpdated () = para (italic (sprintf "Last updated: %s" (DateTime.Now.ToString ("dd-MMM-yyyy HH:mm:ss"))))

    let getStage stage = match stage with | Group (label, _) -> sprintf "Group %c" label
                                          | RoundOf16 matchNumber -> sprintf "Round of 16 (match %d)" matchNumber
                                          | QuarterFinal ordinal -> sprintf "Quarter-final %d" ordinal
                                          | SemiFinal ordinal -> sprintf "Semi-final %d" ordinal
                                          | Final -> "Final"

    let getGroupLabel group = match group with | Group (label, _) -> string label | _ -> ""
    let getGroupTeams group = match group with | Group (_, teams) -> teams | _ -> []

    let getTeamSeeding team = sprintf "%d" team.Seeding
    let getTeamNameWithSeeding (team: Team) = sprintf "%s (%s)" team.Name (getTeamSeeding team)
    let getTeamNameWithCoach (team: Team) = sprintf "%s (%s)" team.Name team.Coach
    let getTeamTextWithStrike (team: Team) text = match team.Status with | Active -> text | Eliminated -> strike text

    let getPlayerIsActive (player: Player) = match player.Team.Status, player.Status with | Eliminated, _ -> false | _, Withdrawn _ -> false | _ -> true
    let getPlayerIsWithdrawn (player: Player) = match player.Status with | Withdrawn _ -> true | _ -> false
    let getPlayerNameWithStrike (player: Player) = match getPlayerIsActive player with | true -> player.Name | false -> strike player.Name
    let getPlayerType player = match player.Type with | Goalkeeper -> "Goalkeeper" | Defender -> "Defender" | Midfielder -> "Midfielder" | Forward -> "Forward"
    let getPlayerStatus player = match player.Status with
                                 | Withdrawn date when date.IsSome -> Some (sprintf "Withdrawn (%s)" (date.Value.ToString ("dd-MMM")))
                                 | Withdrawn _ -> Some "Withdrawn"
                                 | Replacement date when date.IsSome -> Some (sprintf "Replacement (%s)" (date.Value.ToString ("dd-MMM")))
                                 | Replacement _ -> Some "Replacement"
                                 | _ -> None
    let getPlayerTypeAndStatus player = match getPlayerStatus player with | Some status -> sprintf "%s - %s" (getPlayerType player) status | None -> (getPlayerType player)
    let getPlayerIsGoalkeeper (player: Player) = match player.Type with | Goalkeeper -> true | _ -> false
    let getPlayerIsDefender (player: Player) = match player.Type with | Defender -> true | _ -> false
    let getPlayerIsMidfielder (player: Player) = match player.Type with | Midfielder -> true | _ -> false
    let getPlayerIsForward (player: Player) = match player.Type with | Forward -> true | _ -> false

    let teamScores2016 = getTotalScorePerTeam ``Data 2016``.teams ``Data 2016``.matches
    let getTeamScore (teamScores: (Team * int<score>) list) (team: Team) = match teamScores |> List.filter (fun (team', _) -> team'.Name = team.Name) with
                                                                           | h :: _ -> Some (snd h)
                                                                           | _ -> None
    let getTeamScoreText teamScores team = match getTeamScore teamScores team with | Some score -> sprintf "%d" score
                                                                                   | None -> "n/a"
    let getTeamScore2016 team = getTeamScore teamScores2016 team
    let getTeamScoreText2016 team = getTeamScoreText teamScores2016 team
    let getTeamPickedBy team = match ``Sweepstake 2016``.sweepstakers |> List.filter (fun sweepstaker -> match sweepstaker.CoachTeam with | Some team' when team' = team -> true | _ -> false) with
                               | h :: _ -> getParticipant h
                               | _ -> ""

    let players2016 = ``Data 2016``.players |> List.map (fun player -> player, None)
    let playerPicks2016 = ``Sweepstake 2016``.pickedPlayers |> List.map (fun (pick, _) -> pick.Player, pick.OnlyScoresFrom)
    let playerScores2016 = getTotalScorePerPlayer players2016 ``Data 2016``.matches
    let playerPickScores2016 = getTotalScorePerPlayer playerPicks2016 ``Data 2016``.matches
    let getPlayerScore playerScores player = match playerScores |> List.filter (fun (player', _) -> player'.Name = player.Name) with
                                             | h :: _ -> Some (snd h)
                                             | _ -> None
    let getPlayerScoreText playerScores player = match getPlayerScore playerScores player with | Some score -> sprintf "%d" score | None -> "n/a"

    let getPlayerScore2016 player = getPlayerScore playerScores2016 player
    let getPlayerPickScore2016 player = getPlayerScore playerPickScores2016 player
    let getPlayerScoreText2016 player = getPlayerScoreText playerScores2016 player
    let getPlayerPickScoreText2016 player = getPlayerScoreText playerPickScores2016 player
    let getPickOnlyScoresFrom pick = match pick.OnlyScoresFrom with | Some date -> sprintf "(from %s)" (date.ToString ("dd-MMM")) | None -> ""

    let getPlayerPickedBy player = match ``Sweepstake 2016``.pickedPlayers |> List.filter (fun (pick, _) -> pick.Player = player) with
                                   | h :: _ -> Some (snd h, (fst h).OnlyScoresFrom)
                                   | _ -> None
    let getPlayerPickedByText player = match getPlayerPickedBy player with
                                       | Some (pickedBy, onlyScoresFrom) -> match onlyScoresFrom with
                                                                            | Some date -> sprintf "%s (from %s)" pickedBy (date.ToString ("dd-MMM"))
                                                                            | None -> pickedBy
                                       | None -> ""
    let getPlayerAndPickScoreText2016 player = match getPlayerPickedBy player with
                                               | Some (pickedBy, _) -> let playerScoreText2016 = getPlayerScoreText2016 player
                                                                       let playerPickScoreText2016 = getPlayerPickScoreText2016 player
                                                                       if playerScoreText2016 = playerPickScoreText2016 then playerScoreText2016
                                                                       else sprintf "%s (%s for %s)" playerScoreText2016 playerPickScoreText2016 pickedBy
                                               | None -> getPlayerScoreText2016 player

    let groups2016 = [ ``Data 2016``.groupA; ``Data 2016``.groupB; ``Data 2016``.groupC; ``Data 2016``.groupD; ``Data 2016``.groupE; ``Data 2016``.groupF ]
    let matches2016 = ``Data 2016``.matches

