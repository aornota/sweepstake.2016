namespace AOrNotA.Sweepstake2016

open System

open AOrNotA.Sweepstake2016.``Data 2016``
open AOrNotA.Sweepstake2016.Domain
open AOrNotA.Sweepstake2016.Sweepstake

module ``Sweepstake 2016`` =

    let chris = Participant "Chris"
    let denis = Participant "Denis"
    let hugh = Participant "Hugh"
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

    // Before second draft...
    let chrisPicks1 = { Participant = chris
                        CoachTeam = Some spain
                        Picks = [ { Player = vardyJamie; OnlyScoresFrom = None }
                                  { Player = morataAlvaro; OnlyScoresFrom = None }
                                  { Player = zazaSimone; OnlyScoresFrom = None }
                                  { Player = gignacAndrePierre; OnlyScoresFrom = None }
                                  { Player = emboloBreel; OnlyScoresFrom = None }
                                  { Player = kokorinAleksandr; OnlyScoresFrom = None } ] }

    let denisPicks1 = { Participant = denis
                        CoachTeam = Some russia
                        Picks = [ { Player = neuerManuel; OnlyScoresFrom = None } (* goalkeeper *)
                                  { Player = lukakuRomelu; OnlyScoresFrom = None }
                                  { Player = kroosToni; OnlyScoresFrom = None }
                                  { Player = shaqiriXherdan; OnlyScoresFrom = None }
                                  { Player = hummelsMatt; OnlyScoresFrom = None }
                                  { Player = longShane; OnlyScoresFrom = None }
                                  { Player = silvaRafa; OnlyScoresFrom = None }
                                  { Player = immobileCiro; OnlyScoresFrom = None }
                                  { Player = eder_Portugal; OnlyScoresFrom = None }
                                  { Player = blaszczykowskiJakub; OnlyScoresFrom = None }
                                  { Player = kimmichJoshua; OnlyScoresFrom = None } ] }

    let hughPicks1 = { Participant = hugh
                       CoachTeam = None
                       Picks = [ { Player = patricioRui; OnlyScoresFrom = None } (* goalkeeper *)
                                 { Player = lewandowskiRobert; OnlyScoresFrom = None }
                                 { Player = ibrahimovicZlatan; OnlyScoresFrom = None }
                                 { Player = pelleGraciano; OnlyScoresFrom = None }
                                 { Player = sturridgeDaniel; OnlyScoresFrom = None }
                                 { Player = yarmolenkoAndriy; OnlyScoresFrom = None }
                                 { Player = yilmazBurak; OnlyScoresFrom = None }
                                 { Player = necidTomas; OnlyScoresFrom = None }
                                 { Player = fellainiMarouane; OnlyScoresFrom = None }
                                 { Player = inanSelcuk; OnlyScoresFrom = None }
                                 { Player = junuzovicZlatko; OnlyScoresFrom = None } ] }

    let jemPicks1 = { Participant = jem
                      CoachTeam = Some france
                      Picks = [ { Player = deBruyneKevin; OnlyScoresFrom = None }
                                { Player = hazardEden; OnlyScoresFrom = None }
                                { Player = rakiticIvan; OnlyScoresFrom = None }
                                { Player = dzyubaArtyom; OnlyScoresFrom = None }
                                { Player = nani; OnlyScoresFrom = None }
                                { Player = insigneLorenzo; OnlyScoresFrom = None }
                                { Player = ramosSergio; OnlyScoresFrom = None }
                                { Player = smallingChris; OnlyScoresFrom = None } ] }

    let joshPicks1 = { Participant = josh
                       CoachTeam = Some austria
                       Picks = [ { Player = buffonGianluigi; OnlyScoresFrom = None } (* goalkeeper *)
                                 { Player = baleGareth; OnlyScoresFrom = None }
                                 { Player = gotzeMario; OnlyScoresFrom = None }
                                 { Player = arnautovicMarko; OnlyScoresFrom = None }
                                 { Player = piqueGerard; OnlyScoresFrom = None }
                                 { Player = vertonghenJan; OnlyScoresFrom = None }
                                 { Player = dierEric; OnlyScoresFrom = None }
                                 { Player = draxlerJulian; OnlyScoresFrom = None }
                                 { Player = candrevaAntonio; OnlyScoresFrom = None }
                                 { Player = xhakaGranit; OnlyScoresFrom = None }
                                 { Player = tosunCenk; OnlyScoresFrom = None } ] }

    let nephPicks1 = { Participant = neph
                       CoachTeam = Some croatia
                       Picks = [ { Player = hartJoe; OnlyScoresFrom = None } (* goalkeeper *)
                                 { Player = mullerThomas; OnlyScoresFrom = None }
                                 { Player = nolito; OnlyScoresFrom = None }
                                 { Player = mandzukicMario; OnlyScoresFrom = None }
                                 { Player = sigurdssonGylfi; OnlyScoresFrom = None }
                                 { Player = kalinicNikola; OnlyScoresFrom = None }
                                 { Player = matuidiBlaise; OnlyScoresFrom = None }
                                 { Player = lallanaAdam; OnlyScoresFrom = None }
                                 { Player = deRossiDaniele; OnlyScoresFrom = None }
                                 { Player = ramseyAaron; OnlyScoresFrom = None }
                                 { Player = perisicIvan; OnlyScoresFrom = None }  ] }

    let robPicks1 = { Participant = rob
                      CoachTeam = Some belgium
                      Picks = [ { Player = llorisHugo; OnlyScoresFrom = None } (* goalkeeper *)
                                { Player = martialAnthony; OnlyScoresFrom = None }
                                { Player = fabregasCesc; OnlyScoresFrom = None }
                                { Player = kanteNGolo; OnlyScoresFrom = None }
                                { Player = adurizAritz; OnlyScoresFrom = None } ] }

    let rosiePicks1 = { Participant = rosie
                        CoachTeam = Some england
                        Picks = [ { Player = griezmannAntoine; OnlyScoresFrom = None }
                                  { Player = ozilMesut; OnlyScoresFrom = None }
                                  { Player = alabaDavid; OnlyScoresFrom = None }
                                  { Player = jankoMarc; OnlyScoresFrom = None }
                                  { Player = comanKingsley; OnlyScoresFrom = None }
                                  { Player = stanciuNicolae; OnlyScoresFrom = None }
                                  { Player = elShaarawyStephan; OnlyScoresFrom = None }
                                  { Player = ozyakupOguzhan; OnlyScoresFrom = None }
                                  { Player = dudaOndrej; OnlyScoresFrom = None }
                                  { Player = sabitzerMarcel; OnlyScoresFrom = None } ] }

    let steveMPicks1 = { Participant = steveM
                         CoachTeam = Some germany
                         Picks = [ { Player = courtoisThibaut; OnlyScoresFrom = None } (* goalkeeper *)
                                   { Player = gomezMario; OnlyScoresFrom = None }
                                   { Player = payetDimitri; OnlyScoresFrom = None }
                                   { Player = walkerKyle; OnlyScoresFrom = None }
                                   { Player = turanArda; OnlyScoresFrom = None }
                                   { Player = sigthorssonKolbeinn; OnlyScoresFrom = None }
                                   { Player = rosickyTomas; OnlyScoresFrom = None }
                                   { Player = albaJordi; OnlyScoresFrom = None }
                                   { Player = bonucciLeonardo; OnlyScoresFrom = None }
                                   { Player = chielliniGiorgio; OnlyScoresFrom = None }
                                   { Player = boatengJerome; OnlyScoresFrom = None } ] }

    let steveSPicks1 = { Participant = steveS
                         CoachTeam = Some portugal
                         Picks = [ { Player = cechPetr; OnlyScoresFrom = None } (* goalkeeper *)
                                   { Player = giroudOlivier; OnlyScoresFrom = None }
                                   { Player = roseDanny; OnlyScoresFrom = None }
                                   { Player = hamsikMarek; OnlyScoresFrom = None }
                                   { Player = alderweireldToby; OnlyScoresFrom = None }
                                   { Player = konoplyankaYevhen; OnlyScoresFrom = None }
                                   { Player = juanfran; OnlyScoresFrom = None }
                                   { Player = williamsAshley; OnlyScoresFrom = None }
                                   { Player = chirichesVlad; OnlyScoresFrom = None } ] }

    let susiePicks1 = { Participant = susie
                        CoachTeam = Some italy
                        Picks = [ { Player = kaneHarry; OnlyScoresFrom = None }
                                  { Player = alliDele; OnlyScoresFrom = None }
                                  { Player = rooneyWayne; OnlyScoresFrom = None }
                                  { Player = iniestaAndres; OnlyScoresFrom = None }
                                  { Player = pedro; OnlyScoresFrom = None } ] }

    let willPicks1 = { Participant = will
                       CoachTeam = Some poland
                       Picks = [ { Player = tatarusanuCiprian; OnlyScoresFrom = None } (* goalkeeper *)
                                 { Player = ronaldoCristiano; OnlyScoresFrom = None }
                                 { Player = pogbaPaul; OnlyScoresFrom = None }
                                 { Player = modricLuka; OnlyScoresFrom = None }
                                 { Player = silvaDavid; OnlyScoresFrom = None }
                                 { Player = origiDivock; OnlyScoresFrom = None }
                                 { Player = milikArkadiusz; OnlyScoresFrom = None } ] }

    let sweepstakers1 = [ chrisPicks1; denisPicks1; hughPicks1; jemPicks1; joshPicks1; nephPicks1; robPicks1; rosiePicks1; steveMPicks1; steveSPicks1; susiePicks1; willPicks1 ]

    // Final teams...
    let chrisPicksFinal = { Participant = chris
                            CoachTeam = None
                            Picks = [] }

    let denisPicksFinal = { Participant = denis
                            CoachTeam = Some russia
                            Picks = [ { Player = neuerManuel; OnlyScoresFrom = None } (* goalkeeper *)
                                      { Player = lukakuRomelu; OnlyScoresFrom = None }
                                      { Player = kroosToni; OnlyScoresFrom = None }
                                      { Player = shaqiriXherdan; OnlyScoresFrom = None }
                                      { Player = hummelsMatt; OnlyScoresFrom = None }
                                      { Player = longShane; OnlyScoresFrom = None }
                                      { Player = silvaRafa; OnlyScoresFrom = None }
                                      { Player = immobileCiro; OnlyScoresFrom = None }
                                      { Player = eder_Portugal; OnlyScoresFrom = None }
                                      { Player = blaszczykowskiJakub; OnlyScoresFrom = None }
                                      { Player = kimmichJoshua; OnlyScoresFrom = None } ] }

    let hughPicksFinal = { Participant = hugh
                           CoachTeam = None
                           Picks = [] }

    let jemPicksFinal = { Participant = jem
                          CoachTeam = None
                          Picks = [] }

    let joshPicksFinal = { Participant = josh
                           CoachTeam = Some austria
                           Picks = [ { Player = buffonGianluigi; OnlyScoresFrom = None } (* goalkeeper *)
                                     { Player = baleGareth; OnlyScoresFrom = None }
                                     { Player = gotzeMario; OnlyScoresFrom = None }
                                     { Player = arnautovicMarko; OnlyScoresFrom = None }
                                     { Player = piqueGerard; OnlyScoresFrom = None }
                                     { Player = vertonghenJan; OnlyScoresFrom = None }
                                     { Player = dierEric; OnlyScoresFrom = None }
                                     { Player = draxlerJulian; OnlyScoresFrom = None }
                                     { Player = candrevaAntonio; OnlyScoresFrom = None }
                                     { Player = xhakaGranit; OnlyScoresFrom = None }
                                     { Player = tosunCenk; OnlyScoresFrom = None } ] }

    let nephPicksFinal = { Participant = neph
                           CoachTeam = Some croatia
                           Picks = [ { Player = hartJoe; OnlyScoresFrom = None } (* goalkeeper *)
                                     { Player = mullerThomas; OnlyScoresFrom = None }
                                     { Player = nolito; OnlyScoresFrom = None }
                                     { Player = mandzukicMario; OnlyScoresFrom = None }
                                     { Player = sigurdssonGylfi; OnlyScoresFrom = None }
                                     { Player = kalinicNikola; OnlyScoresFrom = None }
                                     { Player = matuidiBlaise; OnlyScoresFrom = None }
                                     { Player = lallanaAdam; OnlyScoresFrom = None }
                                     { Player = deRossiDaniele; OnlyScoresFrom = None }
                                     { Player = ramseyAaron; OnlyScoresFrom = None }
                                     { Player = perisicIvan; OnlyScoresFrom = None }  ] }

    let robPicksFinal = { Participant = rob
                          CoachTeam = None
                          Picks = [] }

    let rosiePicksFinal = { Participant = rosie
                            CoachTeam = None
                            Picks = [] }

    let steveMPicksFinal = { Participant = steveM
                             CoachTeam = Some germany
                             Picks = [ { Player = courtoisThibaut; OnlyScoresFrom = None } (* goalkeeper *)
                                       { Player = gomezMario; OnlyScoresFrom = None }
                                       { Player = payetDimitri; OnlyScoresFrom = None }
                                       { Player = walkerKyle; OnlyScoresFrom = None }
                                       { Player = turanArda; OnlyScoresFrom = None }
                                       { Player = sigthorssonKolbeinn; OnlyScoresFrom = None }
                                       { Player = rosickyTomas; OnlyScoresFrom = None }
                                       { Player = albaJordi; OnlyScoresFrom = None }
                                       { Player = bonucciLeonardo; OnlyScoresFrom = None }
                                       { Player = chielliniGiorgio; OnlyScoresFrom = None }
                                       { Player = boatengJerome; OnlyScoresFrom = None } ] }

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

    // TEMP...
    let sweepstakers = sweepstakers1
    //let sweepstakers = sweepstakersFinal
    // ...TEMP

    let pickedPlayers = sweepstakers |> List.collect (fun sweepstaker -> let participant = getParticipant sweepstaker
                                                                         sweepstaker.Picks |> List.map (fun pick -> pick, participant))

