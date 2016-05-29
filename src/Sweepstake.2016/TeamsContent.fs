namespace AOrNotA.Sweepstake2016

open System

open AOrNotA.Sweepstake2016.Content
open AOrNotA.Sweepstake2016.Domain

module TeamsContent =

    let ``to do`` = ()

    (* let linksHtml =
        let groupRow group =
            let groupCells =
                let teamCell (team: Team) = td (linkToAnchor2 team.Name (getTeamTextWithStrike team (getTeamNameWithSeeding team)))
                let teamCells = getGroupTeams group |> List.map teamCell
                let label = getGroupLabel group
                [ td (bold (sprintf "Group %s" label)) ] @
                teamCells @
                [ td (linkToAnchor2 (sprintf "Group %s fixtures/results" label) "fixtures/results") ]
            tr groupCells
        table (Some 100) (groups2015 |> List.collect groupRow) @
        [ para (linkToAnchor "Knockout fixtures/results") ]

    let getTeamsLinksHtml () = linksHtml
                               |> concatenateWithNewLine

    let fixtureHtml ``match`` =
        let team1, team2 = getTeam ``match``.Team1Points, getTeam ``match``.Team2Points
        let team1Points, team2Points = getPoints ``match``.Team1Points, getPoints ``match``.Team2Points
        let result = if team1Points = 0<point> && team2Points = 0<point> then
                        td (sprintf "%s vs %s" (linkToAnchor team1.Name) (linkToAnchor team2.Name)) // note: assume no genuine nil-nil results
                     // TODO [NMB]: More details (e.g. MatchEvents &c.) for results?...
                     else td (sprintf "%s %d - %d %s" (linkToAnchor team1.Name) (int team1Points) (int team2Points) (linkToAnchor team2.Name))
        let kickOff = td (sprintf "%s %s" (``match``.KickOff.DayOfWeek.ToString ()) (``match``.KickOff.ToString ("dd-MMM-yyyy HH:mm")))
        let stage = match ``match``.Stage with | Group _ -> []
                                               | _ -> [ td (getStage ``match``.Stage) ]
        tr (stage @ [ kickOff; result ])

    let groupsHtml =
        let teamHeaderRow = tr ( [ td (bold "Coach")
                                   td (bold "Seeding")
                                   td (bold "Picked by")
                                   td (bold "2015 score") ] )
        let playersHeaderRow = tr ( [ td (bold "Name")
                                      td (bold "Type")
                                      td (bold "Picked by")
                                      td (bold "2015 score") ] )
        let groupHtml group =
            let teamsHtml =
                let teamHtml (team: Team) =
                    let teamRow = tr ( [ td (getTeamTextWithStrike team team.Coach)
                                         td (getTeamSeeding team)
                                         td (getTeamPickedBy team)
                                         td (getTeamScoreText2015 team) ] )
                    let playerRow player = tr ( [ td (getPlayerNameWithStrike player)
                                                  td (getPlayerTypeAndStatus player)
                                                  td (getPlayerPickedByText player)
                                                  td (getPlayerAndPickScoreText2015 player) ] )
                    let players = players2015 |> List.filter (fun (player, _) -> player.Team = team)
                                              |> List.map (fun (player, _) -> player)
                    [ h3 (anchor2 team.Name (getTeamTextWithStrike team (getTeamNameWithSeeding team))) ] @
                    table (Some 80) (teamHeaderRow @ teamRow) @
                    table (Some 100) (playersHeaderRow @ (players |> List.collect playerRow))
                getGroupTeams group |> List.collect teamHtml
            let label = getGroupLabel group
            let fixturesHtml = matches2015 |> List.filter (fun ``match`` -> getGroupLabel ``match``.Stage = label)
                                           |> List.sortBy (fun ``match`` -> ``match``.KickOff)
                                           |> List.collect fixtureHtml
            [ h2 (sprintf "Group %s" label) ] @
            teamsHtml @
            [ h3 (anchor (sprintf "Group %s fixtures/results" label)) ] @
            table (Some 80) fixturesHtml
        groups2015 |> List.collect groupHtml

    let knockoutFixturesHtml =
        let fixturesHtml = matches2015 |> List.filter (fun ``match`` -> getGroupLabel ``match``.Stage = "")
                                       |> List.sortBy (fun ``match`` -> ``match``.KickOff)
                                       |> List.collect fixtureHtml
        [ h3 (anchor "Knockout fixtures/results") ] @
        table (Some 100) fixturesHtml

    let getTeamsHtml () = groupsHtml @ knockoutFixturesHtml
                          |> concatenateWithNewLine *)

