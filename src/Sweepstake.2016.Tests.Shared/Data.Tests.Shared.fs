namespace AOrNotA.Sweepstake2016.Tests

open AOrNotA.Sweepstake2016.Domain

module ``Data Tests`` =
    
    let ``to do`` = ()

    (* let ``Get Squads with Players for incorrect Team`` squads =
        squads |> List.filter (fun squad -> let incorrectTeamCount = squad.Players
                                                                     |> List.filter (fun player -> player.Team <> squad.Team)
                                                                     |> List.length
                                            incorrectTeamCount > 0)

    let ``Get Squads with incorrect total non-withdrawn Player counts`` squads expectedNonWithdrawnCount =
        squads |> List.filter (fun squad -> let nonWithdrawnCount = squad.Players
                                                                    |> List.filter (fun player -> match player.Status with
                                                                                                  | OriginalSquad _ -> true
                                                                                                  | Replacement _ -> true
                                                                                                  | Withdrawn _ -> false)
                                                                    |> List.length
                                            nonWithdrawnCount <> expectedNonWithdrawnCount)

    let ``Get Matches with MatchEvents for incorrect Teams`` matches =
        matches |> List.filter (fun ``match`` ->
                                    let team1, team2 = getTeam ``match``.Team1Points, getTeam ``match``.Team2Points
                                    let incorrectTeamCount = ``match``.Events
                                                             |> List.map (fun matchEvent -> getTeamForMatchEvent matchEvent)
                                                             |> List.filter (fun team -> team <> team1 && team <> team2)
                                                             |> List.length
                                    incorrectTeamCount > 0)

    let ``Get Matches with incorrect TeamScores`` matches =
        matches |> List.filter (fun ``match`` ->
                                    getTeamScoresFromMatchEvents ``match`` <> (``match``.Team1Points, ``match``.Team2Points))

    let ``Get Matches with incorrect total Conversion attempts`` matches =
        matches |> List.filter (fun ``match`` ->
                                    let team1, team2 = getTeam ``match``.Team1Points, getTeam ``match``.Team2Points
                                    let team1Tries = getTryCount team1 ``match``.Events
                                    let team1ConversionAttempts = getConversionAttemptCount team1 ``match``.Events
                                    let team2Tries = getTryCount team2 ``match``.Events
                                    let team2ConversionAttempts = getConversionAttemptCount team2 ``match``.Events
                                    team1Tries <> team1ConversionAttempts || team2Tries <> team2ConversionAttempts) *)

