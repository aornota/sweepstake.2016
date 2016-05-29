namespace AOrNotA.Sweepstake2016

open System

open AOrNotA.Sweepstake2016.``Data 2016``
open AOrNotA.Sweepstake2016.Domain
open AOrNotA.Sweepstake2016.Sweepstake

module ``Sweepstake 2016`` =

    let ``to do`` = ()

    // TODO: Invite Amanda | Vuk | Josh | ...

    // TEMP...
    let jack = Participant "Jack"
    let neph = Participant "Neph"
    let rosie = Participant "Rosie"

    // Before first draft...
    let jackPicks0 = { Participant = jack; CoachTeam = None; Picks = [] }
    let nephPicks0 = { Participant = neph; CoachTeam = None; Picks = [] }
    let rosiePicks0 = { Participant = rosie; CoachTeam = None; Picks = [] }

    let sweepstakers0 = [ jackPicks0; nephPicks0; rosiePicks0 ]

    // Before second draft...

    let jackPicks1 = { Participant = jack
                       CoachTeam = Some france
                       Picks = [ { Player = pogbaPaul; OnlyScoresFrom = None }
                                 { Player = giroudOlivier; OnlyScoresFrom = None } ] }

    let nephPicks1 = { Participant = neph
                       CoachTeam = Some iceland
                       Picks = [ { Player = griezmannAntoine; OnlyScoresFrom = None }
                                 { Player = llorisHugo (* Goalkeeper *); OnlyScoresFrom = None } ] }

    let rosiePicks1 = { Participant = rosie
                        CoachTeam = Some portugal
                        Picks = [ { Player = payetDimitri; OnlyScoresFrom = None }
                                  { Player = martialAnthony; OnlyScoresFrom = None } ] }

    let sweepstakers1 = [ jackPicks1; nephPicks1; rosiePicks1 ]

    // Final teams...

    let jackPicks2 = { Participant = jack
                       CoachTeam = Some france
                       Picks = [ { Player = pogbaPaul; OnlyScoresFrom = None }
                                 { Player = giroudOlivier; OnlyScoresFrom = None } ] }

    let nephPicks2 = { Participant = neph
                       CoachTeam = Some iceland
                       Picks = [ { Player = griezmannAntoine; OnlyScoresFrom = None }
                                 { Player = llorisHugo (* Goalkeeper *); OnlyScoresFrom = None } ] }

    let rosiePicks2 = { Participant = rosie
                        CoachTeam = Some portugal
                        Picks = [ { Player = payetDimitri; OnlyScoresFrom = None }
                                  { Player = martialAnthony; OnlyScoresFrom = None } ] }

    let sweepstakers2 = [ jackPicks2; nephPicks2; rosiePicks2 ]
    // ...TEMP

    let sweepstakers = sweepstakers2

    let pickedPlayers = sweepstakers |> List.collect (fun sweepstaker -> let participant = getParticipant sweepstaker
                                                                         sweepstaker.Picks |> List.map (fun pick -> pick, participant))

