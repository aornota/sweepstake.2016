namespace AOrNotA.Sweepstake2016

open System

module Domain =

    [<Measure>]
    type min
    [<Measure>]
    type goal
    [<Measure>]
    type shootoutPenalty

    type TeamStatus = | Active | Eliminated

    type Team = { Name: string; Status: TeamStatus; Seeding: int; Coach: string }

    type Stage = | Group of label: char * teams: Team list
                 | RoundOf16 of matchNumber: int
                 | QuarterFinal of ordinal: int
                 | SemiFinal of ordinal: int
                 | Final

    type PlayerType = | Goalkeeper | Defender | Midfielder | Forward

    type PlayerStatus = | OriginalSquad
                        | Withdrawn of DateTime option | Replacement of DateTime option

    type Player = { Name: string; Team: Team; Type: PlayerType; Status: PlayerStatus }

    type Squad = { Team: Team; Players: Player list }

    type MatchEvent = | Goal of player: Player * at: int<min> option * assistedBy: Player option // note: assistedBy (if specified) must be *same* Team as player (but *cannot* be the same Player)
                      | OwnGoal of goalFor: Team * player: Player * at: int<min> option // note: player must be *opposing* Team to goalFor
                      | Penalty of player: Player * successful: bool * at: int<min> option * wonBy: Player option * savedBy: Player option // note: wonBy (if specified) must be *same* Team as player (and *can* be the same Player) - and savedBy (if specified) must be *opposing* Team (and will *usually* be Goalkeeper) and must only be specified (but does *not* have to be specified, e.g. a penalty can be "missed" without being "saved") if not successful
                      | YellowCard of player: Player * at: int<min> option
                      | RedCard of player: Player * at: int<min> option
                      | CleanSheet of goalkeeper: Player * sharedWith: Player option // note: sharedWith (if specified) must be *same* Team as goalkeeper (but *cannot* be the same Player) - and goalkeeper (and sharedWith, if specified) will *usually* be Goalkeeper(s)
                      | ManOfTheMatch of player: Player
                      | ShootoutPenalty of player: Player * successful: bool

    type TeamMatchScore = | TeamMatchScore of team: Team * goals: int<goal> * shootoutPenalties: int<shootoutPenalty> option

    type Match = { Team1Score: TeamMatchScore; Team2Score: TeamMatchScore; Number: int; Stage: Stage; KickOff: DateTime; Events: MatchEvent list }

    let isKnockout ``match`` = match ``match``.Stage with | Group _ -> false | _ -> true

    let getTeam teamMatchScore = match teamMatchScore with | TeamMatchScore (team, _, _) -> team
    let getGoals teamMatchScore = match teamMatchScore with | TeamMatchScore (_, goals, _) -> goals
    let getShootoutPenalties teamMatchScore = match teamMatchScore with | TeamMatchScore (_, _, shootoutPenalties) -> shootoutPenalties

    let getTeamForMatchEvent matchEvent = match matchEvent with | Goal (player, _, _) -> player.Team
                                                                | OwnGoal (_, player, _) -> player.Team
                                                                | Penalty (player, _, _, _, _) -> player.Team
                                                                | YellowCard (player, _) -> player.Team
                                                                | RedCard (player, _) -> player.Team
                                                                | CleanSheet (goalkeeper, _) -> goalkeeper.Team
                                                                | ManOfTheMatch player -> player.Team
                                                                | ShootoutPenalty (player, _) -> player.Team

    let getOtherTeamForMatchEvent matchEvent = match matchEvent with | OwnGoal (goalFor, _, _) -> Some goalFor
                                                                     | Penalty (_, _, _, _, Some savedBy) -> Some savedBy.Team
                                                                     | _ -> None

    let getTeamMatchScoresFromMatchEvents ``match`` =
        let getGoals team matchEvents = matchEvents |> List.map (fun matchEvent -> match matchEvent with
                                                                                   | Goal (player, _, _) when player.Team = team -> 1<goal>
                                                                                   | OwnGoal (goalFor, _, _) when goalFor = team -> 1<goal>
                                                                                   | Penalty (player, successful, _, _, _) when successful && player.Team = team -> 1<goal>
                                                                                   | _ -> 0<goal>)
                                                    |> List.sum
        let getShootoutPenalties team matchEvents =
            let sum = matchEvents |> List.map (fun matchEvent -> match matchEvent with
                                                                 | ShootoutPenalty (player, successful) when successful && player.Team = team -> 1<shootoutPenalty>
                                                                 | _ -> 0<shootoutPenalty>)
                                  |> List.sum
            match sum with | 0<shootoutPenalty> -> None
                           | sum' -> Some sum'
        let team1, team2 = getTeam ``match``.Team1Score, getTeam ``match``.Team2Score
        let team1MatchScore = TeamMatchScore (team1, getGoals team1 ``match``.Events, getShootoutPenalties team1 ``match``.Events)
        let team2MatchScore = TeamMatchScore (team2, getGoals team2 ``match``.Events, getShootoutPenalties team2 ``match``.Events)
        team1MatchScore, team2MatchScore

