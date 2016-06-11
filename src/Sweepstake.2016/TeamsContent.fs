namespace AOrNotA.Sweepstake2016

open System

open AOrNotA.Sweepstake2016.Content
open AOrNotA.Sweepstake2016.Domain
open AOrNotA.Sweepstake2016.Sweepstake

module TeamsContent =

    let private linksHtml =
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

    let private fixtureOrResultHtml ``match`` =
        let result = td (getResult true ``match``)
        let kickOff = td (sprintf "%s %s" (``match``.KickOff.DayOfWeek.ToString ()) (``match``.KickOff.ToString ("dd-MMM-yyyy HH:mm")))
        let stage = match ``match``.Stage with | Group _ -> [] | _ -> [ td (getStage ``match``.Stage) ]
        tr (stage @ [ kickOff; result ])

    let private groupsHtml =
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
                                         td (getTeamPickedByText team)
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
            let fixturesAndResultsHtml = matches2016 |> List.filter (fun ``match`` -> not (isKnockout ``match``))
                                                     |> List.filter (fun ``match`` -> getGroupLabel ``match``.Stage = label)
                                                     |> List.sortBy (fun ``match`` -> ``match``.Number)
                                                     |> List.collect fixtureOrResultHtml
            [ h2 (sprintf "Group %s" label) ] @
            teamsHtml @
            [ h3 (anchor (sprintf "Group %s fixtures/results" label)) ] @
            table (Some 80) fixturesAndResultsHtml
        groups2016 |> List.collect groupHtml

    let private knockoutFixturesAndResultsHtml =
        let fixturesAndResultsHtml = matches2016 |> List.filter (fun ``match`` -> isKnockout ``match``)
                                                 |> List.sortBy (fun ``match`` -> ``match``.Number)
                                                 |> List.collect fixtureOrResultHtml
        [ h3 (anchor "Knockout fixtures/results") ] @
        table (Some 100) fixturesAndResultsHtml

    let getTeamsHtml () = groupsHtml @
                          knockoutFixturesAndResultsHtml
                          |> concatenateWithNewLine

