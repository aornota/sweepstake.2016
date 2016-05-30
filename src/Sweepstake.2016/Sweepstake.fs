namespace AOrNotA.Sweepstake2016

open System

open AOrNotA.Sweepstake2016.Domain

module Sweepstake =

    [<Measure>]
    type score

    type Participant = | Participant of name: string

    type Pick = { Player: Player; OnlyScoresFrom: DateTime option }

    type Sweepstaker = { Participant: Participant; CoachTeam: Team option; Picks: Pick list }

    type MatchResult = | Win | Draw | Lose

    let extractParticipant participant = match participant with | Participant name -> name
    let getParticipant sweepstaker = extractParticipant sweepstaker.Participant
    
    let matchHasStarted ``match`` = if ``match``.KickOff > DateTime.Now then false
                                    else if ``match``.Events |> List.length = 0 then false // note: should be safe because however uneventful the match, there will always be a ManOfTheMatch (and CleanSheets if no Goals/Penalties &c.)
                                    else true

    let getYellowScores usePlayerScore ``match`` =
        let perYellow = match usePlayerScore with | true -> -2<score> | false -> -1<score>
        let equivalentToRed = match usePlayerScore with | true -> -6<score> | false -> -3<score>
        let getPlayerYellowScore player matchEvents =
            let yellows = matchEvents |> List.filter (fun matchEvent -> match matchEvent with | YellowCard (player', _) when player' = player -> true | _ -> false)
                                      |> List.length
            let reds = matchEvents |> List.filter (fun matchEvent -> match matchEvent with | RedCard (player', _) when player' = player -> true | _ -> false)
                                   |> List.length
            match yellows, reds with | 0, _ -> 0<score>
                                     | 1, _ -> perYellow
                                     | 2, reds' when reds' <> 0 -> failwith (sprintf "%s has two yellow cards and a red card for match %d." player.Name ``match``.Number)
                                     | 2, _ -> equivalentToRed
                                     | _ -> failwith (sprintf "%s has an invalid number (%d) of yellow cards for match %d." player.Name yellows ``match``.Number)
        let yellowPlayers = ``match``.Events |> List.map (fun matchEvent -> match matchEvent with | YellowCard (player, _) -> Some player | _ -> None)
                                             |> List.choose (fun player -> player)
                                             |> List.distinct
        yellowPlayers |> List.map (fun player -> player, getPlayerYellowScore player ``match``.Events)

    let getYellowPlayerScores = getYellowScores true
    let getYellowTeamScores = getYellowScores false

    let getTeamScoreForMatch team ``match`` =
        let matchEventScore = ``match``.Events |> List.map (fun matchEvent -> match matchEvent with
                                                                              // Note: YellowCards handled separately.
                                                                              | RedCard (player, _) when player.Team = team -> -3<score>
                                                                              | _ -> 0<score>)
                                               |> List.sum
        let yellowScore = getYellowTeamScores ``match`` |> List.filter (fun (player, _) -> player.Team = team)
                                                        |> List.map (fun (_, score) -> score)
                                                        |> List.sum
        let getResultScore team1 team2 =
            let isTop12 team = team.Seeding <= 12
            let teamIsTop12 = isTop12 team
            let opponent = if team = team1 then team2 else team1
            let opponentIsTop12 = isTop12 opponent
            let team1Goals = getGoals ``match``.Team1Score
            let team1ShootoutPenalties = getShootoutPenalties ``match``.Team1Score
            let team2Goals = getGoals ``match``.Team2Score
            let team2ShootoutPenalties = getShootoutPenalties ``match``.Team2Score
            let teamPoints = if team = team1 then team1Goals else team2Goals
            let teamShootoutPenalties = if team = team1 then team1ShootoutPenalties else team2ShootoutPenalties
            let opponentPoints = if opponent = team1 then team1Goals else team2Goals
            let opponentShootoutPenalities = if opponent = team1 then team1ShootoutPenalties else team2ShootoutPenalties
            let matchResult = match teamPoints, opponentPoints, isKnockout ``match``, teamShootoutPenalties, opponentShootoutPenalities with
                              | teamPoints, opponentPoints, _, _, _ when teamPoints > opponentPoints -> Win
                              | teamPoints, opponentPoints, false, _, _ when teamPoints = opponentPoints -> Draw
                              | teamPoints, opponentPoints, true, Some teamShootoutPenalties', Some opponentShootoutPenalities' when teamPoints = opponentPoints && teamShootoutPenalties' > opponentShootoutPenalities' -> Win
                              | teamPoints, opponentPoints, true, Some teamShootoutPenalties', Some opponentShootoutPenalities' when teamPoints = opponentPoints && teamShootoutPenalties' < opponentShootoutPenalities' -> Lose
                              | teamPoints, opponentPoints, true, Some teamShootoutPenalties', Some opponentShootoutPenalities' when teamPoints = opponentPoints && teamShootoutPenalties' = opponentShootoutPenalities' -> failwith (sprintf "Penalty shootout cannot be a draw for knockout match %d" ``match``.Number)
                              | teamPoints, opponentPoints, true, _, _ when teamPoints = opponentPoints -> failwith (sprintf "Missing penalty shootout information for knockout match %d." ``match``.Number)
                              | _ -> Lose
            match matchResult, teamIsTop12, opponentIsTop12 with | Win, false, true -> 10<score>
                                                                 | Win, true, false -> 6<score>
                                                                 | Win, _, _ -> 8<score>
                                                                 | Draw, false, true -> 5<score>
                                                                 | Draw, true, false -> 3<score>
                                                                 | Draw, _, _ -> 4<score>
                                                                 | _ -> 0<score>
        let team1, team2 = getTeam ``match``.Team1Score, getTeam ``match``.Team2Score
        if team <> team1 && team <> team2 then 0<score>
        else if not (matchHasStarted ``match``) then 0<score>
        else matchEventScore + yellowScore + getResultScore team1 team2
    
    let getPlayerScoreForMatch (player: Player) (onlyScoresFrom: DateTime option) ``match`` =
        let matchEventScore = ``match``.Events |> List.map (fun matchEvent -> match matchEvent with
                                                                              // Note: For Goal, player and assistedBy *cannot* be the same Player.
                                                                              | Goal (player', _, _) when player' = player -> 8<score>
                                                                              | Goal (_, _, Some assistedBy) when assistedBy = player -> 2<score>
                                                                              | OwnGoal (_, player', _) when player' = player -> -4<score>
                                                                              // Note: For Penalty, player and wonBy *can* be the same Player.
                                                                              | Penalty (player', true, _, Some wonBy, _) when player' = player && wonBy = player -> 10<score> // note: 8 + 2
                                                                              | Penalty (player', false, _, Some wonBy, _) when player' = player && wonBy = player -> -2<score> // note: -4 + 2
                                                                              | Penalty (player', true, _, _, _) when player' = player -> 8<score>
                                                                              | Penalty (player', false, _, _, _) when player' = player -> -4<score>
                                                                              | Penalty (_, _, _, Some wonBy, _) when wonBy = player -> 2<score>
                                                                              | Penalty (_, _, _, _, Some savedBy) when savedBy = player -> 8<score>
                                                                              // Note: YellowCards handled separately.
                                                                              | RedCard (player', _) when player' = player -> -6<score>
                                                                              // Note: For CleanSheet, goalkeeper and sharedWith *cannot* be the same Player.
                                                                              | CleanSheet (goalkeeper, Some sharedWith) when goalkeeper = player || sharedWith = player -> 4<score>
                                                                              | CleanSheet (goalkeeper, _) when goalkeeper = player -> 8<score>
                                                                              | ManOfTheMatch player' when player' = player -> 10<score>
                                                                              | _ -> 0<score>)
                                               |> List.sum
        let yellowScore = getYellowPlayerScores ``match`` |> List.filter (fun (player', _) -> player' = player)
                                                          |> List.map (fun (_, score) -> score)
                                                          |> List.sum
        let team1, team2 = getTeam ``match``.Team1Score, getTeam ``match``.Team2Score
        if player.Team <> team1 && player.Team <> team2 then 0<score>
        else if not (matchHasStarted ``match``) then 0<score>
        else if onlyScoresFrom.IsSome && ``match``.KickOff < onlyScoresFrom.Value then 0<score>
        else matchEventScore + yellowScore

    let getTotalScorePerTeam teams matches =
        teams |> List.map (fun team -> let score = matches |> List.map (getTeamScoreForMatch team)
                                                           |> List.sum
                                       team, score)
              |> List.sortBy (fun (_ , score) -> -score)

    let getTotalScorePerPlayer (players: (Player * DateTime option) list) matches =
        players |> List.map (fun (player, onlyScoresFrom) -> let score = matches |> List.map (getPlayerScoreForMatch player onlyScoresFrom)
                                                                                 |> List.sum
                                                             player, score)
                |> List.sortBy (fun (_, score) -> -score)

