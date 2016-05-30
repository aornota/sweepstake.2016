namespace AOrNotA.Sweepstake2016

open System

open AOrNotA.Sweepstake2016.Content
open AOrNotA.Sweepstake2016.``Data 2016``
open AOrNotA.Sweepstake2016.Domain
open AOrNotA.Sweepstake2016.Sweepstake
open AOrNotA.Sweepstake2016.``Sweepstake 2016``

module DraftContent =

    type DraftPick = | CoachTeam of team: Team
                     | Player of player: Player

    type SweepstakerDraft = { Participant: Participant; DraftPicks: DraftPick list }

    // TEMP...
    // First draft...
    let jack1 = { Participant = jack
                  DraftPicks = [ Player giroudOlivier
                                 CoachTeam france
                                 Player martialAnthony
                                 Player gudjohnsenEidur
                                 Player halldorssonHannesThor ] }

    let neph1 = { Participant = neph
                  DraftPicks = [ Player llorisHugo
                                 Player griezmannAntoine
                                 CoachTeam france
                                 Player sigurdssonGylfi
                                 CoachTeam iceland ] }

    let rosie1 = { Participant = rosie
                   DraftPicks = [ CoachTeam portugal
                                  Player payetDimitri
                                  Player griezmannAntoine
                                  Player martialAnthony
                                  Player ronaldoCristiano ] }

    let draft1 = [ jack1; neph1; rosie1 ]

    // TODO (if needed): Second draft...

    // ...TEMP

    let getDraftPickText draftPick = match draftPick with | CoachTeam team -> sprintf "%s (%s)" team.Name team.Coach
                                                          | Player player -> sprintf "%s (%s)" player.Name player.Team.Name

    let isCoachTeamNeeded sweepstaker = match sweepstaker.CoachTeam with | Some _ -> false | None -> true
    let isPlayerTypeNeeded sweepstaker playerType =
        let goalkeeperPicks = sweepstaker.Picks |> List.filter (fun pick -> pick.Player.Type = Goalkeeper)
                                                |> List.length
        let outfieldPicks = sweepstaker.Picks |> List.filter (fun pick -> pick.Player.Type <> Goalkeeper)
                                              |> List.length
        match playerType with | Goalkeeper -> goalkeeperPicks < requiredGoalkeepers
                              | _ -> outfieldPicks < requiredOutfieldPlayers

    let isCoachTeamAvailable sweepstakers team =
        match sweepstakers |> List.choose (fun sweepstaker -> sweepstaker.CoachTeam)
                           |> List.filter (fun team' -> team' = team)
                           |> List.length with
        | 0 -> true
        | _ -> false
    let isPlayerAvailable sweepstakers player =
        match sweepstakers |> List.collect (fun sweepstaker -> sweepstaker.Picks)
                           |> List.filter (fun pick -> pick.Player = player)
                           |> List.length with
        | 0 -> true
        | _ -> false

    let getSweepstaker (sweepstakers: Sweepstaker list) participant = 
        sweepstakers |> List.find (fun sweepstaker' -> sweepstaker'.Participant = participant)

    let getUnneeded (sweepstakers: Sweepstaker list) drafts =
        drafts
        |> List.collect (fun draft -> let unavailable' = draft.DraftPicks
                                                         |> List.filter (fun draftPick -> let sweepstaker = getSweepstaker sweepstakers draft.Participant
                                                                                          match draftPick with
                                                                                          | CoachTeam _ -> not (isCoachTeamNeeded sweepstaker)
                                                                                          | Player player -> not (isPlayerTypeNeeded sweepstaker player.Type))
                                      unavailable' |> List.map (fun draftPick -> draft.Participant, draftPick)
        )
    let getUnavailable sweepstakers drafts =
        drafts
        |> List.collect (fun draft -> let unavailable' = draft.DraftPicks
                                                         |> List.filter (fun draftPick -> match draftPick with
                                                                                          | CoachTeam team -> not (isCoachTeamAvailable sweepstakers team) 
                                                                                          | Player player -> not (isPlayerAvailable sweepstakers player))
                                      unavailable' |> List.map (fun draftPick -> draft.Participant, draftPick))

    let removedHtml removed unneeded =
        let reasonHtml (participant, draftPick) =
            let reason = match unneeded, draftPick with
                         | true, CoachTeam _ -> "a team/coach has already been picked"
                         | true, Player player -> match player.Type with
                                                  | Goalkeeper -> sprintf "The required number (%d) of goalkeepers has already been picked" requiredGoalkeepers
                                                  | _ -> sprintf "The requied number (%d) of outfield players has already been picked" requiredOutfieldPlayers
                         | false, _ -> sprintf "%s was picked in an earlier draft / round" (getDraftPickText draftPick)
            let reason' = match unneeded with
                          | true -> sprintf "Removed %s for %s: %s" (getDraftPickText draftPick) (extractParticipant participant) reason
                          | false -> sprintf "Removed pick for %s: %s" (extractParticipant participant) reason
            para reason'
        let descriptionHtml =
            match removed |> List.length, unneeded with | 0, _ -> []
                                                        | _, true -> [ para (italic "Removing surplus picks...") ]
                                                        | _, false -> [ para (italic "Removing unavailable picks...") ]
        descriptionHtml @
        (removed |> List.map reasonHtml)

    let updateDraftsForRemoved drafts removed =
        drafts |> List.map (fun draft -> let draftPicks = draft.DraftPicks
                                                          |> List.filter (fun pick -> not (removed |> List.exists (fun (participant, pick') -> participant = draft.Participant && pick = pick')))
                                         { Participant = draft.Participant; DraftPicks = draftPicks })

    let topPicksHtml topPicks unique round =
        let uniqueText = match unique with | true -> "unique" | false -> "contested"
        let topPickHtml (participant, draftPick) =
            para (sprintf "%s has a %s pick for round %d: %s" (extractParticipant participant) uniqueText round (getDraftPickText draftPick))
        let descriptionHtml =
            match topPicks |> List.length, unique with | 0, _ -> []
                                                       | _, true -> [ para (italic "Processing unique picks...") ]
                                                       | _, false -> [ para (italic "Processing contested picks...") ]
        descriptionHtml @
        (topPicks |> List.map topPickHtml)

    let assignCoachTeam sweepstaker team = { Participant = Participant (getParticipant sweepstaker)
                                             CoachTeam = Some team
                                             Picks = sweepstaker.Picks }
    let assignPlayer sweepstaker player = { Participant = Participant (getParticipant sweepstaker)
                                            CoachTeam = sweepstaker.CoachTeam
                                            Picks = sweepstaker.Picks @ [ { Player = player; OnlyScoresFrom = None } ] }

    let assignmentHtml participant draftPick contested =
        match contested with
        | false -> para (sprintf "%s assigned to %s" (getDraftPickText draftPick) (extractParticipant participant))
        | true -> para (sprintf "%s randomly assigned to %s" (getDraftPickText draftPick) (extractParticipant participant))

    let assignPicks (sweepstakers: Sweepstaker list) picks =
        let assignments =
            sweepstakers
            |> List.map (fun sweepstaker ->
                             let pick = match picks
                                              |> List.filter (fun (participant, _, _) -> participant = sweepstaker.Participant) with
                                        | (_, draftPick, contested) :: _ -> Some (draftPick, contested)
                                        | [] -> None
                             let sweepstaker' = match pick with
                                                | Some (draftPick, _) -> match draftPick with
                                                                         | CoachTeam team -> assignCoachTeam sweepstaker team
                                                                         | Player player -> assignPlayer sweepstaker player
                                                | None -> sweepstaker
                             let assignedHtml = match pick with
                                                | Some (draftPick, contested) -> assignmentHtml sweepstaker.Participant draftPick contested
                                                | None -> ""
                             sweepstaker', assignedHtml)
        let sweepstakers' = assignments |> List.map fst
        let assignedPicksHtml = assignments |> List.map snd
                                            |> List.filter (fun line -> line <> "")
        sweepstakers', assignedPicksHtml

    let assignUniquePicks sweepstakers uniquePicks =
        let picks = uniquePicks |> List.map (fun (participant, draftPick) -> participant, draftPick, false)
        assignPicks sweepstakers picks

    let assignContestedPicks nextRandom (sweepstakers: Sweepstaker list) contestedPicks (priorities: (Participant * int) list) =
        let getPriority participant = priorities |> List.filter (fun (participant', _) -> participant' = participant)
                                                 |> List.map (fun (_, value) -> value)
                                                 |> List.head
        let assignContestedPick (contestedPick: DraftPick * Participant list) =
            let contestedPriorityHtml (participant, value) =
                [ para (sprintf "%s has pick priority %d" (extractParticipant participant) value) ]
            let highestPriorityHtml participant =
                [ para (sprintf "%s has highest pick priority" (extractParticipant participant)) ]
            let randomHtml (participant, value) =
                [ para (sprintf "%s assigned random number %f" (extractParticipant participant) value)]
            // Note: Intentional hiding of contestHtml.
            let contestHtml = [ para (italic (sprintf "Resolving contested pick %s..." (getDraftPickText (fst contestedPick)))) ]
            let contestedPriorities = snd contestedPick |> List.map (fun participant -> participant, getPriority participant)
            let contestHtml = contestHtml @
                              (contestedPriorities |> List.collect contestedPriorityHtml)
            let highestPriority = contestedPriorities |> List.map (fun (_, value) -> value)
                                                      |> List.max
            let candidates = contestedPriorities |> List.filter (fun (_, value) -> value = highestPriority)
                                                 |> List.map fst
            let contestHtml = contestHtml @
                              (candidates |> List.collect highestPriorityHtml)
            let winningCandidate, contested, winningHtml =
                if candidates |> List.length > 1 then
                    let randoms = candidates |> List.map (fun participant -> participant, nextRandom ())
                    let randomsHtml = randoms |> List.collect randomHtml
                    let highest = randoms |> List.sortBy snd
                                          |> List.rev
                                          |> List.map fst
                                          |> List.head
                    highest, true, randomsHtml @ [ para (sprintf "%s has the highest random number" (extractParticipant highest)) ]
                else candidates |> List.head, false, []
            let losingCandidates = snd contestedPick |> List.filter (fun participant -> participant <> winningCandidate)
            let winner = winningCandidate, fst contestedPick, contested
            let losers = losingCandidates |> List.map (fun participant -> participant, fst contestedPick)
            winner, losers, contestHtml @ winningHtml
        let outcome = contestedPicks |> List.map assignContestedPick
        let picks = outcome |> List.map (fun (winner, _, _) -> winner)
        let missedPicks = outcome |> List.collect (fun (_, losers, _) -> losers)
        let contestedPicksHtml = outcome |> List.collect (fun (_, _, contestedPickHtml) -> contestedPickHtml)
        let sweepstakers', assignedPicksHtml = assignPicks sweepstakers picks
        sweepstakers', contestedPicksHtml @ assignedPicksHtml, missedPicks

    let updatePriorities priorities missedPicks =
        let missedPickHtml participant pick value =
            para (sprintf "%s missed out on %s: pick priority now %d" (extractParticipant participant) (getDraftPickText pick) value)
        let missed = priorities |> List.map (fun (participant, value) ->
                                                 let missedPick = match missedPicks
                                                                        |> List.filter (fun (participant', _) -> participant' = participant) with
                                                                  | h :: _ -> Some (snd h)
                                                                  | [] -> None
                                                 let priority = match missedPick with
                                                                | Some _ -> participant, value + 1
                                                                | None -> participant, value
                                                 let missedHtml = match missedPick with
                                                                  | Some pick -> missedPickHtml participant pick (snd priority)
                                                                  | None -> ""
                                                 priority, missedHtml)
        let priorities' = missed |> List.map fst
        let prioritiesHtml = missed |> List.map snd
                                    |> List.filter (fun line -> line <> "")
        priorities', prioritiesHtml

    let processDraft ordinal seed (sweepstakers: Sweepstaker list) drafts =
        let getRandom seed =
            let random = match seed with | Some seed' -> Random seed' | None -> Random ()
            fun () -> random.NextDouble ()
        let nextRandom = getRandom seed
        let rec processRound sweepstakers drafts priorities draftHtml round =
            // Note: Intentional hiding of sweepstakers | drafts | missed | draftHtml.
            let draftHtml = draftHtml @ [ h3 (sprintf "Round %d" round)]
            let unneeded = getUnneeded sweepstakers drafts
            let draftHtml = draftHtml @ removedHtml unneeded true
            let drafts = updateDraftsForRemoved drafts unneeded
            let unavailable = getUnavailable sweepstakers drafts
            let draftHtml = draftHtml @ removedHtml unavailable false
            let drafts = updateDraftsForRemoved drafts unavailable
            let remainingPicks = drafts |> List.collect (fun draft -> draft.DraftPicks)
                                        |> List.length
            if remainingPicks = 0 then sweepstakers, draftHtml
            else let topPicks = drafts |> List.filter (fun draft -> draft.DraftPicks |> List.length > 0)
                                       |> List.map (fun draft -> draft.Participant, draft.DraftPicks |> List.head)
                 let uniquePicks = topPicks |> Seq.ofList |> Seq.groupBy snd |> List.ofSeq
                                            |> List.filter (fun (_, seq) -> seq |> Seq.length = 1)
                                            |> List.collect (fun (_, seq) -> seq |> List.ofSeq)
                 let draftHtml = draftHtml @ topPicksHtml uniquePicks true round
                 let sweepstakers, uniqueHtml = assignUniquePicks sweepstakers uniquePicks
                 let draftHtml = draftHtml @ uniqueHtml
                 let contestedPicks = topPicks |> Seq.ofList |> Seq.groupBy snd |> List.ofSeq
                                               |> List.filter (fun (_, seq) -> seq |> Seq.length > 1)
                                               |> List.map (fun (draftPick, seq) -> draftPick, seq |> List.ofSeq |> List.map fst)
                 let contestedPicks' = contestedPicks |> List.collect (fun (draftPick, participants) ->
                                                                           participants |> List.map (fun participant -> participant, draftPick))
                 let draftHtml = draftHtml @ topPicksHtml contestedPicks' false round
                 let sweepstakers, contestedHtml, missedPicks = assignContestedPicks nextRandom sweepstakers contestedPicks priorities
                 let draftHtml = draftHtml @ contestedHtml
                 let priorities, prioritiesHtml = updatePriorities priorities missedPicks
                 let draftHtml = draftHtml @ prioritiesHtml
                 let drafts = drafts |> List.filter (fun draft -> draft.DraftPicks |> List.length > 1)
                                     |> List.map (fun draft -> { Participant = draft.Participant
                                                                 DraftPicks = draft.DraftPicks |> List.tail } )
                 if drafts |> List.length = 0 then sweepstakers, draftHtml
                 else processRound sweepstakers drafts priorities draftHtml (round + 1)
        let priorities = sweepstakers |> List.map (fun sweepstaker -> sweepstaker.Participant, 0)
        let sweepstakers', draftHtml = processRound sweepstakers drafts priorities [] 1
        let seedHtml = match seed with | Some seed' -> [ para (italic (sprintf "Using random seed %d" seed')) ] | None -> []
        let processHtml = [ h2 (anchor (sprintf "Draft %d process" ordinal)) ] @
                          seedHtml @
                          draftHtml
        sweepstakers', processHtml
    
    let sweepstakerHtml sweepstaker =
        let isGoalkeeper pick = match pick.Player.Type with | Goalkeeper -> true | _ -> false
        let pluralize noun count = if count = 1 then noun else sprintf "%ss" noun
        let getCoachTeamText (team: Team option) = match team with | Some team' -> sprintf "Team/coach: %s (%s)" team'.Name team'.Coach
                                                                   | None -> italic "Team/coach still to be picked..."
        let playersHtml =
            let playerHtml player = para (sprintf "%s (%s): %s" player.Name player.Team.Name (getPlayerType player))
            let goalkeepers = sweepstaker.Picks |> List.filter (fun pick -> isGoalkeeper pick)
            let outfieldPlayers = sweepstaker.Picks |> List.filter (fun pick -> not (isGoalkeeper pick))
            let goalkeepersHtml = goalkeepers |> List.map (fun pick -> playerHtml pick.Player)
            let outfieldPlayersHtml = outfieldPlayers |> List.map (fun pick -> playerHtml pick.Player)
            let goalkeepersToPick = requiredGoalkeepers - (goalkeepers |> List.length)
            let outfieldPlayersToPick = requiredOutfieldPlayers - (outfieldPlayers |> List.length)
            let toPickHtml = match goalkeepersToPick, outfieldPlayersToPick with
                             | 0, 0 -> [ para (italic "The required number of players have been picked") ]
                             | _, 0 -> [ para (italic (sprintf "%d %s still to be picked..." goalkeepersToPick (pluralize "goalkeeper" goalkeepersToPick))) ]
                             | 0, _ -> [ para (italic (sprintf "%d %s still to be picked..." outfieldPlayersToPick (pluralize "outfield player" outfieldPlayersToPick))) ]
                             | _ -> [ para (italic (sprintf "%d %s and %d %s still to be picked..." goalkeepersToPick (pluralize "goalkeeper" goalkeepersToPick) outfieldPlayersToPick (pluralize "outfield player" outfieldPlayersToPick))) ]
            goalkeepersHtml @ outfieldPlayersHtml @ toPickHtml
        [ h3 (sprintf "%s" (getParticipant sweepstaker)) ] @
        [ para (getCoachTeamText sweepstaker.CoachTeam) ] @
        playersHtml

    let sweepstakersPostDraftHtml ordinal sweepstakers = [ h2 (anchor (sprintf "Draft %d outcome" ordinal)) ] @
                                                         (sweepstakers |> List.collect sweepstakerHtml)

    let sweepstakerDraftHtml draft =
        let picksHtml = 
            orderedList (draft.DraftPicks |> List.map (fun pick -> listItem (getDraftPickText pick)))
        [ h3 (sprintf "%s picks" (extractParticipant draft.Participant)) ] @
        picksHtml

    let draftPicksHtml ordinal drafts = [ h2 (anchor (sprintf "Draft %d picks" ordinal)) ] @
                                        (drafts |> List.collect sweepstakerDraftHtml)

    let draftProcessHtml ordinal seed sweepstakers drafts =
        let sweepstakers', processHtml = processDraft ordinal seed sweepstakers drafts
        processHtml @
        sweepstakersPostDraftHtml ordinal sweepstakers'

    let getDraft1Html () = draftPicksHtml 1 draft1 @
                           draftProcessHtml 1 (Some 24689465) sweepstakers0 draft1
                           |> concatenateWithNewLine

                           