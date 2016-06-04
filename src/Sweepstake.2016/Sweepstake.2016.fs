namespace AOrNotA.Sweepstake2016

open System

open AOrNotA.Sweepstake2016.``Data 2016``
open AOrNotA.Sweepstake2016.Domain
open AOrNotA.Sweepstake2016.Sweepstake

module ``Sweepstake 2016`` =

    let chris = Participant "Chris"
    let denis = Participant "Denis"
    let hugh = Participant "Hugh"
    //let jack = Participant "Jack"
    let jem = Participant "Jem"
    let josh = Participant "Josh"
    let neph = Participant "Neph"
    let rob = Participant "Rob"
    let rosie = Participant "Rosie"
    let steveM = Participant "Steve M"
    let steveS = Participant "Steve S"
    let susie = Participant "Susie"
    let will = Participant "Will"

    // Before first draft...
    let chrisPicks0 = { Participant = chris; CoachTeam = None; Picks = [] }
    let denisPicks0 = { Participant = denis; CoachTeam = None; Picks = [] }
    let hughPicks0 = { Participant = hugh; CoachTeam = None; Picks = [] }
    //let jackPicks0 = { Participant = jack; CoachTeam = None; Picks = [] }
    let jemPicks0 = { Participant = jem; CoachTeam = None; Picks = [] }
    let joshPicks0 = { Participant = josh; CoachTeam = None; Picks = [] }
    let nephPicks0 = { Participant = neph; CoachTeam = None; Picks = [] }
    let robPicks0 = { Participant = rob; CoachTeam = None; Picks = [] }
    let rosiePicks0 = { Participant = rosie; CoachTeam = None; Picks = [] }
    let steveMPicks0 = { Participant = steveM; CoachTeam = None; Picks = [] }
    let steveSPicks0 = { Participant = steveS; CoachTeam = None; Picks = [] }
    let susiePicks0 = { Participant = susie; CoachTeam = None; Picks = [] }
    let willPicks0 = { Participant = will; CoachTeam = None; Picks = [] }

    let sweepstakers0 = [ chrisPicks0; denisPicks0; hughPicks0; jemPicks0; joshPicks0; nephPicks0; robPicks0; rosiePicks0; steveMPicks0; steveSPicks0; susiePicks0; willPicks0 ]

    // TODO (if required): Before second draft?...

    // Final teams...
    let chrisPicksFinal = { Participant = chris
                            CoachTeam = None
                            Picks = [] }

    let denisPicksFinal = { Participant = denis
                            CoachTeam = None
                            Picks = [] }

    let hughPicksFinal = { Participant = hugh
                           CoachTeam = None
                           Picks = [] }

    (* let jackPicksFinal = { Participant = jack
                           CoachTeam = None
                           Picks = [ (* { Player = halldorssonHannesThor (* Goalkeeper *); OnlyScoresFrom = None }
                                     { Player = giroudOlivier; OnlyScoresFrom = None }
                                     { Player = gudjohnsenEidur; OnlyScoresFrom = None } *) ] } *)

    let jemPicksFinal = { Participant = jem
                          CoachTeam = None
                          Picks = [] }

    let joshPicksFinal = { Participant = josh
                           CoachTeam = None
                           Picks = [] }

    let nephPicksFinal = { Participant = neph
                           CoachTeam = None
                           Picks = [] }

    let robPicksFinal = { Participant = rob
                          CoachTeam = None
                          Picks = [] }

    let rosiePicksFinal = { Participant = rosie
                            CoachTeam = None
                            Picks = [] }

    let steveMPicksFinal = { Participant = steveM
                             CoachTeam = None
                             Picks = [] }

    let steveSPicksFinal = { Participant = steveS
                             CoachTeam = None
                             Picks = [] }

    let susiePicksFinal = { Participant = susie
                            CoachTeam = None
                            Picks = [] }

    let willPicksFinal = { Participant = will
                           CoachTeam = None
                           Picks = [] }

    let sweepstakersFinal = [ chrisPicksFinal; denisPicksFinal; hughPicksFinal; jemPicksFinal; joshPicksFinal; nephPicksFinal; robPicksFinal; rosiePicksFinal; steveMPicksFinal; steveSPicksFinal
                              susiePicksFinal; willPicksFinal ]

    let sweepstakers = sweepstakersFinal

    let pickedPlayers = sweepstakers |> List.collect (fun sweepstaker -> let participant = getParticipant sweepstaker
                                                                         sweepstaker.Picks |> List.map (fun pick -> pick, participant))

