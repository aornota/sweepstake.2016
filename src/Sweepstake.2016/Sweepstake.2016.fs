namespace AOrNotA.Sweepstake2016

open System

open AOrNotA.Sweepstake2016.``Data 2016``
open AOrNotA.Sweepstake2016.Domain
open AOrNotA.Sweepstake2016.Sweepstake

module ``Sweepstake 2016`` =

    //let jack = Participant "Jack"
    //let neph = Participant "Neph"
    let rob = Participant "Rob"
    //let rosie = Participant "Rosie"
    let steveM = Participant "Steve M"
    let steveS = Participant "Steve S"

    // Before first draft...
    //let jackPicks0 = { Participant = jack; CoachTeam = None; Picks = [] }
    //let nephPicks0 = { Participant = neph; CoachTeam = None; Picks = [] }
    let robPicks0 = { Participant = rob; CoachTeam = None; Picks = [] }
    //let rosiePicks0 = { Participant = rosie; CoachTeam = None; Picks = [] }
    let steveMPicks0 = { Participant = steveM; CoachTeam = None; Picks = [] }
    let steveSPicks0 = { Participant = steveS; CoachTeam = None; Picks = [] }

    let sweepstakers0 = [ robPicks0; steveMPicks0; steveSPicks0 ]

    // TODO (if required): Before second draft?...

    // Final teams...
    (* let jackPicksFinal = { Participant = jack
                           CoachTeam = None
                           Picks = [ (* { Player = halldorssonHannesThor (* Goalkeeper *); OnlyScoresFrom = None }
                                     { Player = giroudOlivier; OnlyScoresFrom = None }
                                     { Player = gudjohnsenEidur; OnlyScoresFrom = None } *) ] } *)

    (* let nephPicksFinal = { Participant = neph
                           CoachTeam = None
                           Picks = [ (* { Player = llorisHugo (* Goalkeeper *); OnlyScoresFrom = None }
                                     { Player = griezmannAntoine; OnlyScoresFrom = None } 
                                     { Player = sigurdssonGylfi; OnlyScoresFrom = None } 
                                     { Player = gyomberNorbert; OnlyScoresFrom = None } *) ] } *)

    let robPicksFinal = { Participant = rob
                          CoachTeam = None
                          Picks = [ (* { Player = llorisHugo (* Goalkeeper *); OnlyScoresFrom = None }
                                    { Player = griezmannAntoine; OnlyScoresFrom = None } 
                                    { Player = sigurdssonGylfi; OnlyScoresFrom = None } 
                                    { Player = gyomberNorbert; OnlyScoresFrom = None } *) ] }

    (* let rosiePicksFinal = { Participant = rosie
                            CoachTeam = None
                            Picks = [ (* { Player = payetDimitri; OnlyScoresFrom = None }
                                      { Player = martialAnthony; OnlyScoresFrom = None }
                                      { Player = ronaldoCristiano; OnlyScoresFrom = None } *) ] } *)

    let steveMPicksFinal = { Participant = steveM
                             CoachTeam = None
                             Picks = [ (* { Player = llorisHugo (* Goalkeeper *); OnlyScoresFrom = None }
                                       { Player = griezmannAntoine; OnlyScoresFrom = None } 
                                       { Player = sigurdssonGylfi; OnlyScoresFrom = None } 
                                       { Player = gyomberNorbert; OnlyScoresFrom = None } *) ] }

    let steveSPicksFinal = { Participant = steveS
                             CoachTeam = None
                             Picks = [ (* { Player = llorisHugo (* Goalkeeper *); OnlyScoresFrom = None }
                                       { Player = griezmannAntoine; OnlyScoresFrom = None } 
                                       { Player = sigurdssonGylfi; OnlyScoresFrom = None } 
                                       { Player = gyomberNorbert; OnlyScoresFrom = None } *) ] }

    let sweepstakersFinal = [ robPicksFinal; steveMPicksFinal; steveSPicksFinal ]

    let sweepstakers = sweepstakersFinal

    let pickedPlayers = sweepstakers |> List.collect (fun sweepstaker -> let participant = getParticipant sweepstaker
                                                                         sweepstaker.Picks |> List.map (fun pick -> pick, participant))

