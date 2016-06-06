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

    // First draft...
    let chris1 = { Participant = chris
                   DraftPicks = [ CoachTeam spain
                                  Player mullerThomas
                                  Player vardyJamie
                                  Player griezmannAntoine
                                  Player lewandowskiRobert
                                  Player morataAlvaro
                                  Player ronaldoCristiano
                                  Player gomezMario
                                  Player kaneHarry
                                  CoachTeam belgium
                                  Player neuerManuel (* goalkeeper *)
                                  Player martialAnthony
                                  Player ibrahimovicZlatan
                                  Player nolito
                                  Player mandzukicMario
                                  Player deBruyneKevin
                                  Player rooneyWayne
                                  Player pelleGraciano
                                  Player jankoMarc
                                  Player baleGareth
                                  Player dzyubaArtyom
                                  Player zazaSimone
                                  Player gignacAndrePierre
                                  Player silvaDavid
                                  Player kalinicNikola
                                  Player lukakuRomelu
                                  Player emboloBreel
                                  Player kokorinAleksandr
                                  Player adurizAritz
                                  Player hazardEden ] }

    let denis1 = { Participant = denis
                   DraftPicks = [ CoachTeam russia
                                  Player neuerManuel (* goalkeeper *)
                                  Player mullerThomas
                                  Player lukakuRomelu
                                  Player baleGareth
                                  Player ibrahimovicZlatan
                                  Player kroosToni
                                  Player alliDele
                                  Player shaqiriXherdan
                                  Player hummelsMatt
                                  Player longShane
                                  Player silvaRafa
                                  Player martialAnthony
                                  Player sturridgeDaniel
                                  Player immobileCiro
                                  Player eder_Portugal
                                  Player blaszczykowskiJakub
                                  Player kimmichJoshua
                                  Player koke
                                  Player waltersJonathan
                                  Player fellainiMarouane ] }

    let hugh1 = { Participant = hugh
                  DraftPicks = [ Player griezmannAntoine
                                 Player mullerThomas
                                 CoachTeam france
                                 CoachTeam germany
                                 Player lewandowskiRobert
                                 Player ronaldoCristiano
                                 Player gomezMario
                                 Player ibrahimovicZlatan
                                 Player deBruyneKevin
                                 Player pelleGraciano
                                 Player hazardEden
                                 Player giroudOlivier
                                 Player kaneHarry
                                 Player morataAlvaro
                                 Player lukakuRomelu
                                 Player nolito
                                 Player rooneyWayne
                                 Player mandzukicMario
                                 Player jankoMarc
                                 Player sturridgeDaniel
                                 Player dzyubaArtyom
                                 Player yarmolenkoAndriy
                                 CoachTeam poland
                                 Player pogbaPaul
                                 Player turanArda
                                 Player yilmazBurak
                                 Player necidTomas
                                 Player sigurdssonGylfi
                                 Player iniestaAndres
                                 Player milikArkadiusz
                                 Player modricLuka
                                 Player fellainiMarouane
                                 Player shaqiriXherdan
                                 Player inanSelcuk
                                 Player junuzovicZlatko
                                 Player ozilMesut
                                 Player patricioRui (* goalkeeper *)
                                 Player rosickyTomas
                                 Player fabregasCesc
                                 Player pedro
                                 Player mertensDries
                                 Player bergMarcus
                                 Player kokorinAleksandr
                                 Player schurrleAndre
                                 Player sigthorssonKolbeinn
                                 Player sanchesRenato
                                 Player emboloBreel
                                 Player shirokovRoman
                                 Player deRossiDaniele
                                 Player hamsikMarek
                                 Player konoplyankaYevhen
                                 Player alabaDavid ] }

    let jem1 = { Participant = jem
                 DraftPicks = [ CoachTeam france
                                Player mullerThomas
                                Player deBruyneKevin
                                Player hazardEden
                                Player morataAlvaro
                                Player rakiticIvan
                                Player ozilMesut
                                Player dzyubaArtyom
                                Player pelleGraciano
                                Player ibrahimovicZlatan
                                Player nani
                                Player gotzeMario
                                Player yarmolenkoAndriy
                                Player insigneLorenzo
                                Player yilmazBurak
                                Player neuerManuel (* goalkeeper *)
                                Player necidTomas
                                Player ramosSergio
                                Player smallingChris
                                Player sturridgeDaniel ] }

    let josh1 = { Participant = josh
                  DraftPicks = [ Player buffonGianluigi (* goalkeeper *)
                                 CoachTeam austria
                                 CoachTeam italy
                                 CoachTeam croatia
                                 Player deGeaDavid (* goalkeeper *)
                                 Player llorisHugo (* goalkeeper *)
                                 Player baleGareth
                                 Player lewandowskiRobert
                                 Player gotzeMario
                                 Player alliDele
                                 Player mandzukicMario
                                 Player kaneHarry
                                 Player ibrahimovicZlatan
                                 Player arnautovicMarko
                                 Player alderweireldToby
                                 Player piqueGerard
                                 Player shaqiriXherdan
                                 Player modricLuka
                                 Player vertonghenJan
                                 Player sigurdssonGylfi
                                 Player longShane
                                 Player dierEric
                                 Player draxlerJulian
                                 Player candrevaAntonio
                                 Player kokorinAleksandr
                                 Player xhakaGranit
                                 Player tosunCenk
                                 Player konoplyankaYevhen
                                 Player mullerThomas
                                 Player zinchenkoOleksandr ] }

    let neph1 = { Participant = neph
                  DraftPicks = [ Player mullerThomas
                                 Player nolito
                                 Player buffonGianluigi (* goalkeeper *)
                                 CoachTeam italy
                                 Player mandzukicMario
                                 Player griezmannAntoine
                                 Player llorisHugo (* goalkeeper *)
                                 Player kaneHarry
                                 Player lewandowskiRobert
                                 Player deBruyneKevin
                                 Player sigurdssonGylfi
                                 Player kalinicNikola
                                 Player matuidiBlaise
                                 Player konoplyankaYevhen
                                 Player alabaDavid
                                 Player dzyubaArtyom
                                 Player lallanaAdam
                                 Player hamsikMarek
                                 Player alderweireldToby
                                 Player hartJoe (* goalkeeper *)
                                 Player akinfeevIgor (* goalkeeper *)
                                 CoachTeam austria
                                 CoachTeam croatia
                                 CoachTeam ukraine
                                 Player shaqiriXherdan
                                 Player deRossiDaniele
                                 Player iniestaAndres
                                 Player alliDele
                                 Player payetDimitri
                                 Player ramseyAaron
                                 Player perisicIvan
                                 Player gyomberNorbert
                                 Player cahillGary
                                 Player sanchesRenato ] }

    let rob1 = { Participant = rob
                 DraftPicks = [ CoachTeam germany
                                Player llorisHugo (* goalkeeper *)
                                CoachTeam belgium
                                Player neuerManuel (* goalkeeper *)
                                Player payetDimitri
                                Player mullerThomas
                                Player griezmannAntoine
                                Player kaneHarry
                                Player deBruyneKevin
                                Player martialAnthony
                                Player pogbaPaul
                                Player morataAlvaro
                                Player gomezMario
                                Player fabregasCesc
                                Player hartJoe (* goalkeeper *)
                                Player kanteNGolo
                                Player lukakuRomelu
                                Player ronaldoCristiano
                                Player ozilMesut
                                Player nolito
                                Player alderweireldToby
                                Player hazardEden
                                Player pelleGraciano
                                Player vardyJamie
                                Player pedro
                                Player adurizAritz
                                Player giroudOlivier
                                Player lewandowskiRobert ] }

    let rosie1 = { Participant = rosie
                   DraftPicks = [ Player griezmannAntoine
                                  CoachTeam england
                                  Player lewandowskiRobert
                                  Player deBruyneKevin
                                  Player ozilMesut
                                  Player kaneHarry
                                  Player buffonGianluigi (* goalkeeper *)
                                  CoachTeam poland
                                  Player alabaDavid
                                  Player alliDele
                                  Player jankoMarc
                                  Player comanKingsley
                                  Player morataAlvaro
                                  Player stanciuNicolae
                                  Player gotzeMario
                                  Player silvaDavid
                                  Player pogbaPaul
                                  Player hazardEden
                                  Player elShaarawyStephan
                                  Player yarmolenkoAndriy
                                  Player mandzukicMario
                                  Player milikArkadiusz
                                  Player rooneyWayne
                                  Player adurizAritz
                                  Player nolito
                                  CoachTeam romania
                                  Player cechPetr (* goalkeeper *)
                                  Player sigurdssonGylfi
                                  Player ozyakupOguzhan
                                  Player konoplyankaYevhen
                                  Player dudaOndrej
                                  Player emboloBreel
                                  Player sabitzerMarcel ] }

    let steveM1 = { Participant = steveM // note: draft pick order TBC...
                    DraftPicks = [ CoachTeam germany
                                   Player buffonGianluigi (* goalkeeper *)
                                   Player gomezMario
                                   Player payetDimitri
                                   Player kaneHarry
                                   CoachTeam france
                                   Player courtoisThibaut (* goalkeeper *)
                                   Player pogbaPaul
                                   Player lukakuRomelu
                                   Player walkerKyle
                                   Player alliDele
                                   Player hazardEden
                                   Player turanArda
                                   Player sigthorssonKolbeinn
                                   Player mandzukicMario
                                   Player ronaldoCristiano
                                   Player lewandowskiRobert
                                   Player rosickyTomas
                                   Player modricLuka
                                   Player yilmazBurak
                                   Player juanfran
                                   Player albaJordi
                                   Player bonucciLeonardo
                                   Player chielliniGiorgio
                                   Player boatengJerome
                                   Player hummelsMatt
                                   Player darmianMatteo ] }

    let steveS1 = { Participant = steveS
                    DraftPicks = [ Player cechPetr (* goalkeeper *)
                                   Player ronaldoCristiano
                                   Player giroudOlivier
                                   Player baleGareth
                                   Player griezmannAntoine
                                   Player ibrahimovicZlatan
                                   Player lewandowskiRobert
                                   Player gomezMario
                                   Player llorisHugo (* goalkeeper *)
                                   Player roseDanny
                                   Player kaneHarry
                                   Player hamsikMarek
                                   Player deBruyneKevin
                                   Player alderweireldToby
                                   CoachTeam belgium
                                   Player alabaDavid
                                   Player konoplyankaYevhen
                                   Player hennesseyWayne (* goalkeeper *)
                                   Player juanfran
                                   Player silvaDavid
                                   Player williamsAshley
                                   Player mullerThomas
                                   Player chirichesVlad
                                   CoachTeam spain
                                   Player pogbaPaul
                                   CoachTeam portugal
                                   Player alliDele
                                   Player ramseyAaron
                                   Player modricLuka
                                   Player payetDimitri
                                   Player ozilMesut ] }

    let susie1 = { Participant = susie
                   DraftPicks = [ CoachTeam italy
                                  Player ronaldoCristiano
                                  Player lewandowskiRobert
                                  Player kaneHarry
                                  Player lukakuRomelu
                                  Player alliDele
                                  Player martialAnthony
                                  Player payetDimitri
                                  Player llorisHugo (* goalkeeper *)
                                  Player griezmannAntoine
                                  Player ibrahimovicZlatan
                                  Player rooneyWayne
                                  Player iniestaAndres
                                  Player pedro
                                  Player kroosToni
                                  Player gomezMario ] }

    let will1 = { Participant = will
                  DraftPicks = [ CoachTeam germany
                                 Player mullerThomas
                                 Player ronaldoCristiano
                                 Player giroudOlivier
                                 Player neuerManuel (* goalkeeper *)
                                 Player lewandowskiRobert
                                 Player hazardEden
                                 CoachTeam poland
                                 Player pogbaPaul
                                 Player gomezMario
                                 Player jankoMarc
                                 Player deBruyneKevin
                                 Player mandzukicMario
                                 Player tatarusanuCiprian (* goalkeeper *)
                                 Player pelleGraciano
                                 Player modricLuka
                                 Player silvaDavid
                                 Player shaqiriXherdan
                                 Player rakiticIvan
                                 Player origiDivock
                                 Player hamsikMarek
                                 Player morataAlvaro
                                 Player sigurdssonGylfi
                                 Player milikArkadiusz
                                 Player matuidiBlaise ] }
                                   
    let draft1 = [ chris1; denis1; hugh1; jem1; josh1; neph1; rob1; rosie1; steveM1; steveS1; susie1; will1 ]

    // TODO: Second draft...

    let chris2 = { Participant = chris
                   DraftPicks = [  ] }

    let hugh2 = { Participant = hugh
                  DraftPicks = [  ] }

    let jem2 = { Participant = jem
                 DraftPicks = [  ] }

    let rob2 = { Participant = rob
                 DraftPicks = [  ] }

    let rosie2 = { Participant = rosie
                   DraftPicks = [  ] }

    let steveS2 = { Participant = steveS
                    DraftPicks = [  ] }

    let susie2 = { Participant = susie
                   DraftPicks = [  ] }

    let will2 = { Participant = will
                  DraftPicks = [  ] }

    let draft2 = [ chris2; hugh2; jem2; rob2; rosie2; steveS2; susie2; will2 ]

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
        let pluralize noun count = if count = 1 then noun else sprintf "%ss" noun
        let getCoachTeamText (team: Team option) = match team with | Some team' -> sprintf "Team/coach: %s (%s)" team'.Name team'.Coach
                                                                   | None -> italic "Team/coach still to be picked..."
        let playersHtml =
            let playerHtml player = para (sprintf "%s (%s): %s" player.Name player.Team.Name (getPlayerType player))
            let goalkeepers = sweepstaker.Picks |> List.filter (fun pick -> getPlayerIsGoalkeeper pick.Player)
            let outfieldPlayers = sweepstaker.Picks |> List.filter (fun pick -> not (getPlayerIsGoalkeeper pick.Player))
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

    let popularPicksHtml ordinal drafts =
        let allPicks = drafts |> List.collect (fun draft -> draft.DraftPicks)
        let popularCoachTeamsHtml =
            let popularCoachTeams = allPicks |> List.choose (fun pick -> match pick with | CoachTeam team -> Some pick | _ -> None)
                                             |> Seq.ofList
                                             |> Seq.groupBy (fun team -> team)
                                             |> Seq.map (fun (team, seq) -> team, seq |> Seq.length)
                                             |> Seq.filter (fun (_, count) -> count > 1)
                                             |> Seq.sortBy (fun (_, count) -> -count)
                                             |> List.ofSeq
            [ h3 ("Teams/coaches") ] @
            orderedList (popularCoachTeams |> List.map (fun (team, count) -> listItem (sprintf "%s: %d" (getDraftPickText team) count)))
        let popularGoalkeepersHtml =
            let popularGoalkeepers = allPicks |> List.choose (fun pick -> match pick with | Player player when getPlayerIsGoalkeeper player -> Some pick | _ -> None)
                                              |> Seq.ofList
                                              |> Seq.groupBy (fun team -> team)
                                              |> Seq.map (fun (team, seq) -> team, seq |> Seq.length)
                                              |> Seq.filter (fun (_, count) -> count > 1)
                                              |> Seq.sortBy (fun (_, count) -> -count)
                                              |> List.ofSeq
            [ h3 ("Goalkeepers") ] @
            orderedList (popularGoalkeepers |> List.map (fun (goalkeeper, count) -> listItem (sprintf "%s: %d" (getDraftPickText goalkeeper) count)))
        let popularOutfieldPlayersHtml =
            let popularOutfieldPlayers = allPicks |> List.choose (fun pick -> match pick with | Player player when not (getPlayerIsGoalkeeper player) -> Some pick | _ -> None)
                                                  |> Seq.ofList
                                                  |> Seq.groupBy (fun team -> team)
                                                  |> Seq.map (fun (team, seq) -> team, seq |> Seq.length)
                                                  |> Seq.filter (fun (_, count) -> count > 1)
                                                  |> Seq.sortBy (fun (_, count) -> -count)
                                                  |> List.ofSeq
            [ h3 ("Outfield players") ] @
            orderedList (popularOutfieldPlayers |> List.map (fun (player, count) -> listItem (sprintf "%s: %d" (getDraftPickText player) count)))
        [ h2 (sprintf "Most popular draft %d picks" ordinal) ] @
        popularCoachTeamsHtml @
        popularGoalkeepersHtml @
        popularOutfieldPlayersHtml

    let draftPicksHtml ordinal drafts = [ h2 (anchor (sprintf "Draft %d picks" ordinal)) ] @
                                        (drafts |> List.collect sweepstakerDraftHtml)

    let draftProcessHtml ordinal seed sweepstakers drafts =
        let sweepstakers', processHtml = processDraft ordinal seed sweepstakers drafts
        processHtml @
        sweepstakersPostDraftHtml ordinal sweepstakers'

    let getDraft1Html () = popularPicksHtml 1 draft1 @
                           draftPicksHtml 1 draft1 @
                           draftProcessHtml 1 (Some 20160606) sweepstakers0 draft1
                           |> concatenateWithNewLine

    let getDraft2Html () = draftPicksHtml 2 draft2 @
                           draftProcessHtml 2 (Some 2016) sweepstakers1 draft2
                           |> concatenateWithNewLine

                           