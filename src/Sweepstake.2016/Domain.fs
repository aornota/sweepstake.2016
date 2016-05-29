namespace AOrNotA.Sweepstake2016

open System

module Domain =

    [<Measure>]
    type min
    [<Measure>]
    type goal

    type TeamStatus = | Active | Eliminated

    type Team = { Name: string; Status: TeamStatus; Seeding: int; Coach: string }

    type Stage = | Group of label: char * teams: Team list
                 | RoundOf16 of ordinal: int
                 | QuarterFinal of ordinal: int
                 | SemiFinal of ordinal: int
                 | Final

    let isKnockout stage = match stage with | Group _ -> false | _ -> true

    type PlayerType = | Goalkeeper | Defender | Midfielder | Forward

    type PlayerStatus = | OriginalSquad
                        | Withdrawn of DateTime option | Replacement of DateTime option

    type Player = { Name: string; Team: Team; Type: PlayerType; Status: PlayerStatus }

    type Squad = { Team: Team; Players: Player list }

    type MatchEvent = | Goal of player: Player * at: int<min> option * assistedBy: Player option
                      | Penalty of player: Player * at: int<min> option // TBC: no 'assistedBy' for Penalty?...
                      | OwnGoal of player: Player * at: int<min> option
                      | MissedPenalty of player: Player * at: int<min> option
                      | SavedPenalty of goalkeeper: Player * at: int<min> option
                      | YellowCard of player: Player * at: int<min> option
                      | RedCard of player: Player * at: int<min> option
                      | CleanSheet of goalkeeper: Player * sharedWith: Player option
                      | ManOfTheMatch of player: Player

    type TeamMatchScore = | TeamMatchScore of team: Team * goals: int<goal> * shootoutPenalties: int<goal> option

    type Match = { Team1Score: TeamMatchScore; Team2Score: TeamMatchScore; Number: int; Stage: Stage; KickOff: DateTime; Events: MatchEvent list }

    let getTeam teamMatchScore = match teamMatchScore with | TeamMatchScore (team, _, _) -> team
    let getGoals teamMatchScore = match teamMatchScore with | TeamMatchScore (_, goals, _) -> goals
    let getShootoutPenalties teamMatchScore = match teamMatchScore with | TeamMatchScore (_, _, shootoutPenalties) -> shootoutPenalties

    (* let getTeamForMatchEvent matchEvent = match matchEvent with
                                          | Try (player, _) -> player.Team
                                          | PenaltyTry (team, _) -> team
                                          | Conversion player | Penalty player | DropGoal player -> player.Team
                                          | MissedConversion player | MissedPenalty player -> player.Team
                                          | YellowCard (player, _) | RedCard (player, _) | ManOfTheMatch player -> player.Team

    let getTeamGoalsFromMatchEvents ``match`` =
        let getPoints team matchEvents =
            matchEvents
            |> List.map (fun matchEvent -> match matchEvent with
                                           | Try (player, _) when player.Team = team -> 5<point>
                                           | PenaltyTry (team', _) when team' = team -> 5<point>
                                           | Conversion player when player.Team = team -> 2<point>
                                           | Penalty player when player.Team = team -> 3<point>
                                           | DropGoal player when player.Team = team -> 3<point>
                                           | _ -> 0<point>)
            |> List.sum
        let team1, team2 = getTeam ``match``.Team1Points, getTeam ``match``.Team2Points
        let team1Points = TeamPoints (team1, getPoints team1 ``match``.Events)
        let team2Points = TeamPoints (team2, getPoints team2 ``match``.Events)
        team1Points, team2Points *)

