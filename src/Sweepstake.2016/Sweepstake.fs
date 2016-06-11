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

    [<Literal>]
    let private winUnderdog = 20<score>
    [<Literal>]
    let private winPickEm = 16<score>
    [<Literal>]
    let private winFavourite = 12<score>
    [<Literal>]
    let private drawUnderdog = 8<score>
    [<Literal>]
    let private drawPickEm = 6<score>
    [<Literal>]
    let private drawFavourite = 4<score>

    [<Literal>]
    let private playerManOfTheMatch = 15<score>
    [<Literal>]
    let private playerGoal = 12<score>
    [<Literal>]
    let private playerAssist = 3<score>
    [<Literal>]
    let private playerScorePenalty = playerGoal
    [<Literal>]
    let private playerWinPenalty = playerAssist
    [<Literal>]
    let private playerMissPenalty = -6<score>
    [<Literal>]
    let private playerOwnGoal = -6<score>
    [<Literal>]
    let private playerCleanSheet = 12<score>
    [<Literal>]
    let private playerSavePenalty = 12<score>

    [<Literal>]
    let private playerYellow = -2<score>
    [<Literal>]
    let private playerRed = -6<score>
    [<Literal>]
    let private teamYellow = -1<score>
    [<Literal>]
    let private teamRed = -3<score>

    let extractParticipant participant = match participant with | Participant name -> name
    let getParticipant sweepstaker = extractParticipant sweepstaker.Participant
    
    let matchHasStarted ``match`` = if ``match``.KickOff > DateTime.Now then false
                                    else if ``match``.Events |> List.length = 0 then false // note: should be safe because however uneventful the match, there will always be a ManOfTheMatch (and CleanSheets if no Goals/Penalties &c.)
                                    else true

    let getYellowScores usePlayerScore ``match`` =
        let perYellow = match usePlayerScore with | true -> playerYellow | false -> teamYellow
        let equivalentToRed = match usePlayerScore with | true -> playerRed | false -> teamRed
        let getPlayerYellowScore player matchEvents =
            let yellows = matchEvents |> List.filter (fun matchEvent -> match matchEvent with | YellowCard (player', _) when player' = player -> true | _ -> false)
                                      |> List.length
            let reds = matchEvents |> List.filter (fun matchEvent -> match matchEvent with | RedCard (player', _) when player' = player -> true | _ -> false)
                                   |> List.length
            match yellows, reds with | 0, _ -> None
                                     | 1, _ -> Some (perYellow, sprintf "yellow card for %s = %d" player.Name (int perYellow))
                                     | 2, reds' when reds' <> 0 -> failwith (sprintf "%s has two yellow cards and a red card for match %d." player.Name ``match``.Number)
                                     | 2, _ -> Some (equivalentToRed, sprintf "2 yellow cards (equivalent to red card) for %s = %d" player.Name (int equivalentToRed))
                                     | _ -> failwith (sprintf "%s has an invalid number (%d) of yellow cards for match %d." player.Name yellows ``match``.Number)
        let yellowPlayers = ``match``.Events |> List.map (fun matchEvent -> match matchEvent with | YellowCard (player, _) -> Some player | _ -> None)
                                             |> List.choose (fun player -> player)
                                             |> List.distinct
        yellowPlayers |> List.map (fun player -> player, getPlayerYellowScore player ``match``.Events)

    let getYellowPlayerScores = getYellowScores true
    let getYellowTeamScores = getYellowScores false

    let getTeamScoresForMatch team ``match`` =
        let matchEventScores = ``match``.Events |> List.map (fun matchEvent -> match matchEvent with
                                                                               // Note: YellowCards handled separately.
                                                                               | RedCard (player, _) when player.Team = team -> Some (teamRed, sprintf "red card for %s = %d" player.Name (int teamRed))
                                                                               | _ -> None)
        let yellowScores = getYellowTeamScores ``match`` |> List.filter (fun (player, _) -> player.Team = team)
                                                         |> List.map (fun (_, scoreAndNotes) -> scoreAndNotes)
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
            match matchResult, teamIsTop12, opponentIsTop12 with | Win, false, true -> Some (winUnderdog, sprintf "win for %s = %d" team1.Name (int winUnderdog))
                                                                 | Win, true, false -> Some (winFavourite, sprintf "win for %s = %d" team1.Name (int winFavourite))
                                                                 | Win, _, _ -> Some (winPickEm, sprintf "win for %s = %d" team1.Name (int winPickEm))
                                                                 | Draw, false, true -> Some (drawUnderdog, sprintf "draw for %s = %d" team1.Name (int drawUnderdog))
                                                                 | Draw, true, false -> Some (drawFavourite, sprintf "draw for %s = %d" team1.Name (int drawFavourite))
                                                                 | Draw, _, _ -> Some (drawPickEm, sprintf "draw for %s = %d" team1.Name (int drawPickEm))
                                                                 | _ -> None
        let team1, team2 = getTeam ``match``.Team1Score, getTeam ``match``.Team2Score
        if team <> team1 && team <> team2 then []
        else if not (matchHasStarted ``match``) then []
        else matchEventScores @
             yellowScores @
             [ getResultScore team1 team2 ]
             |> List.choose (fun item -> item)
    
    let getPlayerScoresForMatch (player: Player) (onlyScoresFrom: DateTime option) ``match`` =
        let matchEventScores = ``match``.Events |> List.map (fun matchEvent -> match matchEvent with
                                                                               // Note: For Goal, player and assistedBy *cannot* be the same Player.
                                                                               | Goal (player', _, _) when player' = player -> Some (playerGoal, sprintf "goal scored by %s = %d" player'.Name (int playerGoal))
                                                                               | Goal (_, _, Some assistedBy) when assistedBy = player -> Some (playerAssist, sprintf "assist by %s = %d" assistedBy.Name (int playerAssist))
                                                                               | OwnGoal (_, player', _) when player' = player -> Some (playerOwnGoal, sprintf "own goal scored by %s = %d" player'.Name (int playerOwnGoal))
                                                                               // Note: For Penalty, player and wonBy *can* be the same Player.
                                                                               | Penalty (player', true, _, Some wonBy, _) when player' = player && wonBy = player -> Some (playerScorePenalty + playerWinPenalty, sprintf "Penalty won and scored by %s = %d" player'.Name (int playerScorePenalty + int playerWinPenalty))
                                                                               | Penalty (player', false, _, Some wonBy, _) when player' = player && wonBy = player -> Some (playerMissPenalty + playerWinPenalty, sprintf "Penalty won and missed by %s = %d" player'.Name (int playerMissPenalty + int playerWinPenalty))
                                                                               | Penalty (player', true, _, _, _) when player' = player -> Some (playerScorePenalty, sprintf "penalty scored by %s = %d" player'.Name (int playerScorePenalty))
                                                                               | Penalty (player', false, _, _, _) when player' = player -> Some (playerMissPenalty, sprintf "penalty missed by %s = %d" player'.Name (int playerMissPenalty))
                                                                               | Penalty (_, _, _, Some wonBy, _) when wonBy = player -> Some (playerWinPenalty, sprintf "penalty won by %s = %d" wonBy.Name (int playerWinPenalty))
                                                                               | Penalty (_, _, _, _, Some savedBy) when savedBy = player -> Some (playerSavePenalty, sprintf "penalty saved by %s = %d" savedBy.Name (int playerSavePenalty))
                                                                               // Note: YellowCards handled separately.
                                                                               | RedCard (player', _) when player' = player -> Some (playerRed, sprintf "red card for %s = %d" player'.Name (int playerRed))
                                                                               // Note: For CleanSheet, goalkeeper and sharedWith *cannot* be the same Player.
                                                                               | CleanSheet (goalkeeper, Some sharedWith) when goalkeeper = player -> Some (playerCleanSheet / 2, sprintf "clean sheet (shared with %s) for %s = %d" sharedWith.Name goalkeeper.Name (int playerCleanSheet / 2))
                                                                               | CleanSheet (goalkeeper, Some sharedWith) when sharedWith = player -> Some (playerCleanSheet / 2, sprintf "clean sheet (shared with %s) for %s = %d" goalkeeper.Name sharedWith.Name (int playerCleanSheet / 2))
                                                                               | CleanSheet (goalkeeper, _) when goalkeeper = player -> Some (playerCleanSheet, sprintf "clean sheet for %s = %d" goalkeeper.Name (int playerCleanSheet))
                                                                               | ManOfTheMatch player' when player' = player -> Some (playerManOfTheMatch, sprintf "man-of-the-match for %s = %d" player'.Name (int playerManOfTheMatch))
                                                                               | _ -> None)
        let yellowScores = getYellowPlayerScores ``match`` |> List.filter (fun (player', _) -> player' = player)
                                                           |> List.map (fun (_, scoreAndNotes) -> scoreAndNotes)
        let team1, team2 = getTeam ``match``.Team1Score, getTeam ``match``.Team2Score
        if player.Team <> team1 && player.Team <> team2 then []
        else if not (matchHasStarted ``match``) then []
        else if onlyScoresFrom.IsSome && ``match``.KickOff < onlyScoresFrom.Value then []
        else matchEventScores @
             yellowScores
             |> List.choose (fun item -> item)

    let getTotalScorePerTeam teams matches =
        teams |> List.map (fun team -> let score = matches |> List.collect (getTeamScoresForMatch team)
                                                           |> List.map (fun (score, _) -> score)
                                                           |> List.sum
                                       team, score)
              |> List.sortBy (fun (_ , score) -> -score)

    let getTotalScorePerPlayer (players: (Player * DateTime option) list) matches =
        players |> List.map (fun (player, onlyScoresFrom) -> let score = matches |> List.collect (getPlayerScoresForMatch player onlyScoresFrom)
                                                                                 |> List.map (fun (score, _) -> score)
                                                                                 |> List.sum
                                                             player, score)
                |> List.sortBy (fun (_, score) -> -score)

