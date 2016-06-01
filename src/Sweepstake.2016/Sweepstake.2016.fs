﻿namespace AOrNotA.Sweepstake2016

open System

open AOrNotA.Sweepstake2016.``Data 2016``
open AOrNotA.Sweepstake2016.Domain
open AOrNotA.Sweepstake2016.Sweepstake

module ``Sweepstake 2016`` =

    // TODO: Invite Josh...

    // TEMP...
    let jack = Participant "Jack"
    let neph = Participant "Neph"
    let rosie = Participant "Rosie"

    // Before first draft...
    let jackPicks0 = { Participant = jack; CoachTeam = None; Picks = [] }
    let nephPicks0 = { Participant = neph; CoachTeam = None; Picks = [] }
    let rosiePicks0 = { Participant = rosie; CoachTeam = None; Picks = [] }

    let sweepstakers0 = [ jackPicks0; nephPicks0; rosiePicks0 ]

    // TODO (if required): Before second draft?...

    // Final teams...
    let jackPicksFinal = { Participant = jack
                           CoachTeam = None
                           Picks = [ (* { Player = halldorssonHannesThor (* Goalkeeper *); OnlyScoresFrom = None }
                                     { Player = giroudOlivier; OnlyScoresFrom = None }
                                     { Player = gudjohnsenEidur; OnlyScoresFrom = None } *) ] }

    let nephPicksFinal = { Participant = neph
                           CoachTeam = None
                           Picks = [ (* { Player = llorisHugo (* Goalkeeper *); OnlyScoresFrom = None }
                                     { Player = griezmannAntoine; OnlyScoresFrom = None } 
                                     { Player = sigurdssonGylfi; OnlyScoresFrom = None } 
                                     { Player = gyomberNorbert; OnlyScoresFrom = None } *) ] }

    let rosiePicksFinal = { Participant = rosie
                            CoachTeam = None
                            Picks = [ (* { Player = payetDimitri; OnlyScoresFrom = None }
                                      { Player = martialAnthony; OnlyScoresFrom = None }
                                      { Player = ronaldoCristiano; OnlyScoresFrom = None } *) ] }

    let sweepstakersFinal = [ jackPicksFinal; nephPicksFinal; rosiePicksFinal ]
    // ...TEMP

    let sweepstakers = sweepstakersFinal

    let pickedPlayers = sweepstakers |> List.collect (fun sweepstaker -> let participant = getParticipant sweepstaker
                                                                         sweepstaker.Picks |> List.map (fun pick -> pick, participant))

