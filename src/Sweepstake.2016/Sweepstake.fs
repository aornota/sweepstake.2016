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

    (* let getTeamScoreForMatch team ``match`` =
        let getMatchEventScore team matchEvents =
            matchEvents
            |> List.map (fun matchEvent -> match matchEvent with
                                           | PenaltyTry (team', _) when team' = team -> 6<score>
                                           | YellowCard (player, _) when player.Team = team -> -2<score>
                                           | RedCard (player, _) when player.Team = team -> -4<score>
                                           | _ -> 0<score>)
            |> List.sum
        let getResultScore team team1 team2 ``match`` =
            let isTop8 team = match team.Seeding with | Some seeding when seeding <= 8 -> true | _ -> false
            let teamIsTop8 = isTop8 team
            let opponent = if team = team1 then team2 else team1
            let opponentIsTop8 = isTop8 opponent
            let team1Points = getPoints ``match``.Team1Points
            let team2Points = getPoints ``match``.Team2Points
            let teamPoints = if team = team1 then team1Points else team2Points
            let opponentPoints = if opponent = team1 then team1Points else team2Points
            let matchResult = if teamPoints > opponentPoints then Win
                              else if teamPoints = opponentPoints then Draw
                              else Lose
            let matchResultScore = match matchResult, teamIsTop8, opponentIsTop8 with
                                   | Win, false, true -> 10<score>
                                   | Win, true, false -> 6<score>
                                   | Win, _, _ -> 8<score>
                                   | Draw, false, true -> 5<score>
                                   | Draw, true, false -> 3<score>
                                   | Draw, _, _ -> 4<score>
                                   | _ -> 0<score>
            let (_, team1BonusCount), (_, team2BonusCount) = getTeamBonusCounts ``match``
            let teamBonusCount = if team = team1 then team1BonusCount else team2BonusCount
            let bonusMultiplier = match teamIsTop8, opponentIsTop8 with
                                  | false, true -> 3<score>
                                  | true, false -> 1<score>
                                  | _ -> 2<score>
            let bonusPointScore = teamBonusCount * bonusMultiplier
            matchResultScore + bonusPointScore
        let team1, team2 = getTeam ``match``.Team1Points, getTeam ``match``.Team2Points
        if team <> team1 && team <> team2 then 0<score>
        else if ``match``.KickOff > DateTime.Now then 0<score>
        else getMatchEventScore team ``match``.Events + getResultScore team team1 team2 ``match``

    let getPlayerScoreForMatch (player: Player) (onlyScoresFrom: DateTime option) ``match`` =
        let getScore player matchEvents =
            matchEvents
            |> List.map (fun matchEvent -> match matchEvent with
                                           | Try (player', _) when player' = player -> 9<score>
                                           | Conversion player' when player' = player -> 2<score>
                                           | Penalty player' when player' = player -> 3<score>
                                           | DropGoal player' when player' = player -> 3<score>
                                           | ManOfTheMatch player' when player' = player -> 10<score>
                                           | MissedConversion player' when player' = player -> -1<score>
                                           | MissedPenalty player' when player' = player -> -2<score>
                                           | YellowCard (player', _) when player' = player -> -3<score>
                                           | RedCard (player', _) when player' = player -> -6<score>
                                           | _ -> 0<score>)
            |> List.sum
        let team1, team2 = getTeam ``match``.Team1Points, getTeam ``match``.Team2Points
        if player.Team <> team1 && player.Team <> team2 then 0<score>
        else if onlyScoresFrom.IsSome && ``match``.KickOff < onlyScoresFrom.Value then 0<score>
        else getScore player ``match``.Events

    let getTotalScorePerTeam teams matches =
        teams |> List.map (fun team -> let score = matches |> List.map (getTeamScoreForMatch team)
                                                           |> List.sum
                                       team, score)
              |> List.sortBy (fun (_ , score) -> -score)

    let getTotalScorePerPlayer (players: (Player * DateTime option) list) matches =
        players |> List.map (fun (player, onlyScoresFrom) -> let score = matches
                                                                         |> List.map (getPlayerScoreForMatch player onlyScoresFrom)
                                                                         |> List.sum
                                                             player, score)
                |> List.sortBy (fun (_, score) -> -score) *)

