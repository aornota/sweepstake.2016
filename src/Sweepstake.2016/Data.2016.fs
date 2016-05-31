namespace AOrNotA.Sweepstake2016

open System

open AOrNotA.Sweepstake2016.Domain

module ``Data 2016`` =

    // 2016 squads &c.: https://en.wikipedia.org/wiki/UEFA_Euro_2016_squads.

    // Note: Seedings are based on "the UEFA National team coefficients updated after the completion of the qualifying group stage (excluding the play-offs)" (see https://en.wikipedia.org/wiki/UEFA_Euro_2016#Qualified_teams).

    // Group A.

    let france = { Name = "France"; Status = Active; Seeding = 7; Coach = "Didier Deschamps" }
    let switzerland = { Name = "Switzerland"; Status = Active; Seeding = 9; Coach = "Vladimir Petković" }
    let romania = { Name = "Romania"; Status = Active; Seeding = 16; Coach = "Anghel Iordănescu" }
    let albania = { Name = "Albania"; Status = Active; Seeding = 23; Coach = "Gianni De Biasi" }

    // Group B.

    let england = { Name = "England"; Status = Active; Seeding = 3; Coach = "Roy Hodgson" }
    let russia = { Name = "Russia"; Status = Active; Seeding = 8; Coach = "Leonid Slutsky" }
    let slovakia = { Name = "Slovakia"; Status = Active; Seeding = 17; Coach = "Ján Kozák" }
    let wales = { Name = "Wales"; Status = Active; Seeding = 22; Coach = "Chris Coleman" }

    // Group C.

    let germany = { Name = "Germany"; Status = Active; Seeding = 1; Coach = "Joachim Löw" }
    let ukraine = { Name = "Ukraine"; Status = Active; Seeding = 12; Coach = "Mykhaylo Fomenko" }
    let poland = { Name = "Poland"; Status = Active; Seeding = 15; Coach = "Adam Nawałka" }
    let northernIreland = { Name = "Northern Ireland"; Status = Active; Seeding = 24; Coach = "Michael O'Neill" }

    // Group D.

    let spain = { Name = "Spain"; Status = Active; Seeding = 2; Coach = "Vicente del Bosque" }
    let croatia = { Name = "Croatia"; Status = Active; Seeding = 11; Coach = "Ante Čačić" }
    let czechRepublic = { Name = "Czech Republic"; Status = Active; Seeding = 13; Coach = "Pavel Vrba" }
    let turkey = { Name = "Turkey"; Status = Active; Seeding = 19; Coach = "Fatih Terim" }

    // Group E.

    let belgium = { Name = "Belgium"; Status = Active; Seeding = 5; Coach = "Marc Wilmots" }
    let italy = { Name = "Italy"; Status = Active; Seeding = 6; Coach = "Antonio Conte" }
    let sweden = { Name = "Sweden"; Status = Active; Seeding = 14; Coach = "Erik Hamrén" }
    let republicOfIreland = { Name = "Republic of Ireland"; Status = Active; Seeding = 20; Coach = "Martin O'Neill" }

    // Group F.

    let portugal = { Name = "Portugal"; Status = Active; Seeding = 4; Coach = "Fernando Santos" }
    let austria = { Name = "Austria"; Status = Active; Seeding = 10; Coach = "Marcel Koller" }
    let hungary = { Name = "Hungary"; Status = Active; Seeding = 18; Coach = "Bernd Storck" }
    let iceland = { Name = "Iceland"; Status = Active; Seeding = 21; Coach = "Lars Lagerbäck & Heimir Hallgrímsson" }

    // Group A.

    let llorisHugo = { Name = "Hugo Lloris"; Team = france; Type = Goalkeeper; Status = OriginalSquad }
    let mandandaSteve = { Name = "Steve Mandanda"; Team = france; Type = Goalkeeper; Status = OriginalSquad }
    let costilBenoit = { Name = "Benoît Costil"; Team = france; Type = Goalkeeper; Status = OriginalSquad }
    let evraPatrice = { Name = "Patrice Evra"; Team = france; Type = Defender; Status = OriginalSquad }
    let sagnaBacary = { Name = "Bacary Sagna"; Team = france; Type = Defender; Status = OriginalSquad }
    let koscielnyLaurent = { Name = "Laurent Koscielny"; Team = france; Type = Defender; Status = OriginalSquad }
    let ramiAdil = { Name = "Adil Rami"; Team = france; Type = Defender; Status = OriginalSquad }
    let digneLucas = { Name = "Lucas Digne"; Team = france; Type = Defender; Status = OriginalSquad }
    let jalletChristophe = { Name = "Christophe Jallet"; Team = france; Type = Defender; Status = OriginalSquad }
    let mangalaEliaquim = { Name = "Eliaquim Mangala"; Team = france; Type = Defender; Status = OriginalSquad }
    let umtitiSamuel = { Name = "Samuel Umtiti"; Team = france; Type = Defender; Status = OriginalSquad }
    let cabayeYohan = { Name = "Yohan Cabaye"; Team = france; Type = Midfielder; Status = OriginalSquad }
    let matuidiBlaise = { Name = "Blaise Matuidi"; Team = france; Type = Midfielder; Status = OriginalSquad }
    let sissokoMoussa = { Name = "Moussa Sissoko"; Team = france; Type = Midfielder; Status = OriginalSquad }
    let diarraLassana = { Name = "Lassana Diarra"; Team = france; Type = Midfielder; Status = OriginalSquad }
    let pogbaPaul = { Name = "Paul Pogba"; Team = france; Type = Midfielder; Status = OriginalSquad }
    let payetDimitri = { Name = "Dimitri Payet"; Team = france; Type = Midfielder; Status = OriginalSquad }
    let kanteNGolo = { Name = "N'Golo Kanté"; Team = france; Type = Midfielder; Status = OriginalSquad }
    let giroudOlivier = { Name = "Olivier Giroud"; Team = france; Type = Forward; Status = OriginalSquad }
    let griezmannAntoine = { Name = "Antoine Griezmann"; Team = france; Type = Forward; Status = OriginalSquad }
    let gignacAndrePierre = { Name = "André-Pierre Gignac"; Team = france; Type = Forward; Status = OriginalSquad }
    let martialAnthony = { Name = "Anthony Martial"; Team = france; Type = Forward; Status = OriginalSquad }
    let comanKingsley = { Name = "Kingsley Coman"; Team = france; Type = Forward; Status = OriginalSquad }

    let franceSquad = { Team = france
                        Players = [ llorisHugo; mandandaSteve; costilBenoit; evraPatrice; sagnaBacary; koscielnyLaurent; ramiAdil; digneLucas; jalletChristophe; mangalaEliaquim; umtitiSamuel
                                    cabayeYohan; matuidiBlaise; sissokoMoussa; diarraLassana; pogbaPaul; payetDimitri; kanteNGolo; giroudOlivier; griezmannAntoine; gignacAndrePierre; martialAnthony
                                    comanKingsley ] }

    let sommerYann = { Name = "Yann Sommer"; Team = switzerland; Type = Goalkeeper; Status = OriginalSquad }
    let hitzMarwin = { Name = "Marwin Hitz"; Team = switzerland; Type = Goalkeeper; Status = OriginalSquad }
    let burkiRoman = { Name = "Roman Bürki"; Team = switzerland; Type = Goalkeeper; Status = OriginalSquad }
    let lichtsteinerStephan = { Name = "Stephan Lichtsteiner"; Team = switzerland; Type = Defender; Status = OriginalSquad }
    let moubandjeFrancois = { Name = "François Moubandje"; Team = switzerland; Type = Defender; Status = OriginalSquad }
    let elvediNico = { Name = "Nico Elvedi"; Team = switzerland; Type = Defender; Status = OriginalSquad }
    let vonBergenSteve = { Name = "Steve von Bergen"; Team = switzerland; Type = Defender; Status = OriginalSquad }
    let langMichael = { Name = "Michael Lang"; Team = switzerland; Type = Defender; Status = OriginalSquad }
    let rodriguezRicardo = { Name = "Ricardo Rodríguez"; Team = switzerland; Type = Defender; Status = OriginalSquad }
    let djourouJohan = { Name = "Johan Djourou"; Team = switzerland; Type = Defender; Status = OriginalSquad }
    let scharFabian = { Name = "Fabian Schär"; Team = switzerland; Type = Defender; Status = OriginalSquad }
    let freiFabian = { Name = "Fabian Frei"; Team = switzerland; Type = Midfielder; Status = OriginalSquad }
    let xhakaGranit = { Name = "Granit Xhaka"; Team = switzerland; Type = Midfielder; Status = OriginalSquad }
    let behramiValon = { Name = "Valon Behrami"; Team = switzerland; Type = Midfielder; Status = OriginalSquad }
    let zakariaDenis = { Name = "Denis Zakaria"; Team = switzerland; Type = Midfielder; Status = OriginalSquad }
    let dzemailiBlerim = { Name = "Blerim Džemaili"; Team = switzerland; Type = Midfielder; Status = OriginalSquad }
    let fernandesGelson = { Name = "Gélson Fernandes"; Team = switzerland; Type = Midfielder; Status = OriginalSquad }
    let tarashajShani = { Name = "Shani Tarashaj"; Team = switzerland; Type = Midfielder; Status = OriginalSquad }
    let shaqiriXherdan = { Name = "Xherdan Shaqiri"; Team = switzerland; Type = Midfielder; Status = OriginalSquad }
    let emboloBreel = { Name = "Breel Embolo"; Team = switzerland; Type = Forward; Status = OriginalSquad }
    let seferovicHaris = { Name = "Haris Seferović"; Team = switzerland; Type = Forward; Status = OriginalSquad }
    let mehmediAdmir = { Name = "Admir Mehmedi"; Team = switzerland; Type = Forward; Status = OriginalSquad }
    let derdiyokEren = { Name = "Eren Derdiyok"; Team = switzerland; Type = Forward; Status = OriginalSquad }

    let switzerlandSquad = { Team = switzerland
                             Players = [ sommerYann; hitzMarwin; burkiRoman; lichtsteinerStephan; moubandjeFrancois; elvediNico; vonBergenSteve; langMichael; rodriguezRicardo; djourouJohan
                                         scharFabian; freiFabian; xhakaGranit; behramiValon; zakariaDenis; dzemailiBlerim; fernandesGelson; tarashajShani; shaqiriXherdan; emboloBreel; seferovicHaris
                                         mehmediAdmir; derdiyokEren ] }

    (* let a = { Name = ""; Team = b; Type = Goalkeeper; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Defender; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Midfielder; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Forward; Status = OriginalSquad } *)

    let romaniaSquad = { Team = romania
                         Players = [ (* TODO *) ] }

    (* let a = { Name = ""; Team = b; Type = Goalkeeper; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Defender; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Midfielder; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Forward; Status = OriginalSquad } *)

    let albaniaSquad = { Team = albania
                         Players = [ (* TODO *) ] }

    // Group B.

    let hartJoe = { Name = "Joe Hart"; Team = england; Type = Goalkeeper; Status = OriginalSquad }
    let forsterFraser = { Name = "Fraser Forster"; Team = england; Type = Goalkeeper; Status = OriginalSquad }
    let heatonTom = { Name = "Tom Heaton"; Team = england; Type = Goalkeeper; Status = OriginalSquad }
    let cahillGary = { Name = "Gary Cahill"; Team = england; Type = Defender; Status = OriginalSquad }
    let smallingChris = { Name = "Chris Smalling"; Team = england; Type = Defender; Status = OriginalSquad }
    let walkerKyle = { Name = "Kyle Walker"; Team = england; Type = Defender; Status = OriginalSquad }
    let clyneNathaniel = { Name = "Nathaniel Clyne"; Team = england; Type = Defender; Status = OriginalSquad }
    let stonesJohn = { Name = "John Stones"; Team = england; Type = Defender; Status = OriginalSquad }
    let bertrandRyan = { Name = "Ryan Bertrand"; Team = england; Type = Defender; Status = OriginalSquad }
    let roseDanny = { Name = "Danny Rose"; Team = england; Type = Defender; Status = OriginalSquad }
    let milnerJames = { Name = "James Milner"; Team = england; Type = Midfielder; Status = OriginalSquad }
    let wilshereJack = { Name = "Jack Wilshere"; Team = england; Type = Midfielder; Status = OriginalSquad }
    let hendersonJordan = { Name = "Jordan Henderson"; Team = england; Type = Midfielder; Status = OriginalSquad }
    let dierEric = { Name = "Eric Dier"; Team = england; Type = Midfielder; Status = OriginalSquad }
    let sterlingRaheem = { Name = "Raheem Sterling"; Team = england; Type = Midfielder; Status = OriginalSquad }
    let lallanaAdam = { Name = "Adam Lallana"; Team = england; Type = Midfielder; Status = OriginalSquad }
    let barkleyRoss = { Name = "Ross Barkley"; Team = england; Type = Midfielder; Status = OriginalSquad }
    let alliDele = { Name = "Dele Alli"; Team = england; Type = Midfielder; Status = OriginalSquad }
    let kaneHarry = { Name = "Harry Kane"; Team = england; Type = Forward; Status = OriginalSquad }
    let rooneyWayne = { Name = "Wayne Rooney"; Team = england; Type = Forward; Status = OriginalSquad }
    let vardyJamie = { Name = "Jamie Vardy"; Team = england; Type = Forward; Status = OriginalSquad }
    let sturridgeDaniel = { Name = "Daniel Sturridge"; Team = england; Type = Forward; Status = OriginalSquad }
    let rashfordMarcus = { Name = "Marcus Rashford"; Team = england; Type = Forward; Status = OriginalSquad }

    let englandSquad = { Team = england
                         Players = [ hartJoe; forsterFraser; heatonTom; cahillGary; smallingChris; walkerKyle; clyneNathaniel; stonesJohn; bertrandRyan; roseDanny; milnerJames; wilshereJack
                                     hendersonJordan; dierEric; sterlingRaheem; lallanaAdam; barkleyRoss; alliDele; kaneHarry; rooneyWayne; vardyJamie; sturridgeDaniel; rashfordMarcus ] }

    let akinfeevIgor = { Name = "Igor Akinfeev"; Team = russia; Type = Goalkeeper; Status = OriginalSquad }
    let lodyginYuri = { Name = "Yuri Lodygin"; Team = russia; Type = Goalkeeper; Status = OriginalSquad }
    let marinatoGuilherme = { Name = "Guilherme Marinato"; Team = russia; Type = Goalkeeper; Status = OriginalSquad }
    let ignashevichSergei = { Name = "Sergei Ignashevich"; Team = russia; Type = Defender; Status = OriginalSquad }
    let berezutskiVasili = { Name = "Vasili Berezutski"; Team = russia; Type = Defender; Status = OriginalSquad }
    let berezutskiAleksei = { Name = "Aleksei Berezutski"; Team = russia; Type = Defender; Status = OriginalSquad }
    let kombarovDmitri = { Name = "Dmitri Kombarov"; Team = russia; Type = Defender; Status = OriginalSquad }
    let smolnikovIgor = { Name = "Igor Smolnikov"; Team = russia; Type = Defender; Status = OriginalSquad }
    let shishkinRoman = { Name = "Roman Shishkin"; Team = russia; Type = Defender; Status = OriginalSquad }
    let shchennikovGeorgi = { Name = "Georgi Shchennikov"; Team = russia; Type = Defender; Status = OriginalSquad }
    let neustadterRoman = { Name = "Roman Neustädter"; Team = russia; Type = Defender; Status = OriginalSquad }
    let shirokovRoman = { Name = "Roman Shirokov"; Team = russia; Type = Midfielder; Status = OriginalSquad }
    let denisovIgor = { Name = "Igor Denisov"; Team = russia; Type = Midfielder; Status = OriginalSquad }
    let glushakovDenis = { Name = "Denis Glushakov"; Team = russia; Type = Midfielder; Status = OriginalSquad }
    let samedovAleksandr = { Name = "Aleksandr Samedov"; Team = russia; Type = Midfielder; Status = OriginalSquad }
    let torbinskiDmitri = { Name = "Dmitri Torbinski"; Team = russia; Type = Midfielder; Status = OriginalSquad }
    let shatovOleg = { Name = "Oleg Shatov"; Team = russia; Type = Midfielder; Status = OriginalSquad }
    let mamayevPavel = { Name = "Pavel Mamayev"; Team = russia; Type = Midfielder; Status = OriginalSquad }
    let golovinAleksandr = { Name = "Aleksandr Golovin"; Team = russia; Type = Midfielder; Status = OriginalSquad }
    let ivanovOleg = { Name = "Oleg Ivanov"; Team = russia; Type = Midfielder; Status = OriginalSquad }
    let kokorinAleksandr = { Name = "Aleksandr Kokorin"; Team = russia; Type = Forward; Status = OriginalSquad }
    let dzyubaArtyom = { Name = "Artyom Dzyuba"; Team = russia; Type = Forward; Status = OriginalSquad }
    let smolovFyodor = { Name = "Fyodor Smolov"; Team = russia; Type = Forward; Status = OriginalSquad }

    let russiaSquad = { Team = russia
                        Players = [ akinfeevIgor; lodyginYuri; marinatoGuilherme; ignashevichSergei; berezutskiVasili; berezutskiAleksei; kombarovDmitri; smolnikovIgor; shishkinRoman
                                    shchennikovGeorgi; neustadterRoman; shirokovRoman; denisovIgor; glushakovDenis; samedovAleksandr; torbinskiDmitri; shatovOleg; mamayevPavel; golovinAleksandr
                                    ivanovOleg; kokorinAleksandr; dzyubaArtyom; smolovFyodor ] }

    let muchaJan = { Name = "Ján Mucha"; Team = slovakia; Type = Goalkeeper; Status = OriginalSquad }
    let kozacikMatus = { Name = "Matúš Kozáčik"; Team = slovakia; Type = Goalkeeper; Status = OriginalSquad }
    let novotnaJan = { Name = "Ján Novota"; Team = slovakia; Type = Goalkeeper; Status = OriginalSquad }
    let skrtelMartin = { Name = "Martin Škrtel"; Team = slovakia; Type = Defender; Status = OriginalSquad }
    let duricaJan = { Name = "Ján Ďurica"; Team = slovakia; Type = Defender; Status = OriginalSquad }
    let pekarikPeter = { Name = "Peter Pekarík"; Team = slovakia; Type = Defender; Status = OriginalSquad }
    let hubocanTomas = { Name = "Tomáš Hubočan"; Team = slovakia; Type = Defender; Status = OriginalSquad }
    let salataKornel = { Name = "Kornel Saláta"; Team = slovakia; Type = Defender; Status = OriginalSquad }
    let sventoDusan = { Name = "Dušan Švento"; Team = slovakia; Type = Defender; Status = OriginalSquad }
    let gyomberNorbert = { Name = "Norbert Gyömbér"; Team = slovakia; Type = Defender; Status = OriginalSquad }
    let skriniarMilan = { Name = "Milan Škriniar"; Team = slovakia; Type = Defender; Status = OriginalSquad }
    let hamsikMarek = { Name = "Marek Hamšík"; Team = slovakia; Type = Midfielder; Status = OriginalSquad }
    let sestakStanislav = { Name = "Stanislav Šesták"; Team = slovakia; Type = Midfielder; Status = OriginalSquad }
    let stochMiroslav = { Name = "Miroslav Stoch"; Team = slovakia; Type = Midfielder; Status = OriginalSquad }
    let weissVladimir = { Name = "Vladimír Weiss"; Team = slovakia; Type = Midfielder; Status = OriginalSquad }
    let kuckaJuraj = { Name = "Juraj Kucka"; Team = slovakia; Type = Midfielder; Status = OriginalSquad }
    let pecovskyViktor = { Name = "Viktor Pečovský"; Team = slovakia; Type = Midfielder; Status = OriginalSquad }
    let makRobert = { Name = "Róbert Mak"; Team = slovakia; Type = Midfielder; Status = OriginalSquad }
    let dudaOndrej = { Name = "Ondrej Duda"; Team = slovakia; Type = Midfielder; Status = OriginalSquad }
    let hrosovskyPatrik = { Name = "Patrik Hrošovský"; Team = slovakia; Type = Midfielder; Status = OriginalSquad }
    let gregusJan = { Name = "Ján Greguš"; Team = slovakia; Type = Midfielder; Status = OriginalSquad }
    let durisMichal = { Name = "Michal Ďuriš"; Team = slovakia; Type = Forward; Status = OriginalSquad }
    let nemecAdam = { Name = "Adam Nemec"; Team = slovakia; Type = Forward; Status = OriginalSquad }

    let slovakiaSquad = { Team = slovakia
                          Players = [ muchaJan; kozacikMatus; novotnaJan; skrtelMartin; duricaJan; pekarikPeter; hubocanTomas; salataKornel; sventoDusan; gyomberNorbert; skriniarMilan; hamsikMarek
                                      sestakStanislav; stochMiroslav; weissVladimir; kuckaJuraj; pecovskyViktor; makRobert; dudaOndrej; hrosovskyPatrik; gregusJan; durisMichal; nemecAdam ] }

    (* let a = { Name = ""; Team = b; Type = Goalkeeper; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Defender; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Midfielder; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Forward; Status = OriginalSquad } *)

    let walesSquad = { Team = wales
                       Players = [ (* TODO *) ] }

    // Group C.

    let neuerManuel = { Name = "Manuel Neuer"; Team = germany; Type = Goalkeeper; Status = OriginalSquad }
    let terStegenMarcAndre = { Name = "Marc-André ter Stegen"; Team = germany; Type = Goalkeeper; Status = OriginalSquad }
    let lenoBernd = { Name = "Bernd Leno"; Team = germany; Type = Goalkeeper; Status = OriginalSquad }
    let boatengJerome = { Name = "Jérôme Boateng"; Team = germany; Type = Defender; Status = OriginalSquad }
    let hummelsMatt = { Name = "Mats Hummels"; Team = germany; Type = Defender; Status = OriginalSquad }
    let howedesBenedikt = { Name = "Benedikt Höwedes"; Team = germany; Type = Defender; Status = OriginalSquad }
    let hectorJonas = { Name = "Jonas Hector"; Team = germany; Type = Defender; Status = OriginalSquad }
    let mustafiShkodran = { Name = "Shkodran Mustafi"; Team = germany; Type = Defender; Status = OriginalSquad }
    let rudigerAntonio = { Name = "Antonio Rüdiger"; Team = germany; Type = Defender; Status = OriginalSquad }
    let canEmre = { Name = "Emre Can"; Team = germany; Type = Defender; Status = OriginalSquad }
    let schweinsteigerBastian = { Name = "Bastian Schweinsteiger"; Team = germany; Type = Midfielder; Status = OriginalSquad }
    let ozilMesut = { Name = "Mesut Özil"; Team = germany; Type = Midfielder; Status = OriginalSquad }
    let kroosToni = { Name = "Toni Kroos"; Team = germany; Type = Midfielder; Status = OriginalSquad }
    let khediraSami = { Name = "Sami Khedira"; Team = germany; Type = Midfielder; Status = OriginalSquad }
    let gotzeMario = { Name = "Mario Götze"; Team = germany; Type = Midfielder; Status = OriginalSquad }
    let schurrleAndre = { Name = "André Schürrle"; Team = germany; Type = Midfielder; Status = OriginalSquad }
    let draxlerJulian = { Name = "Julian Draxler"; Team = germany; Type = Midfielder; Status = OriginalSquad }
    let saneLeroy = { Name = "Leroy Sané"; Team = germany; Type = Midfielder; Status = OriginalSquad }
    let weiglJulian = { Name = "Julian Weigl"; Team = germany; Type = Midfielder; Status = OriginalSquad }
    let kimmichJoshua = { Name = "Joshua Kimmich"; Team = germany; Type = Midfielder; Status = OriginalSquad }
    let podolskiLukas = { Name = "Lukas Podolski"; Team = germany; Type = Forward; Status = OriginalSquad }
    let mullerThomas = { Name = "Thomas Müller"; Team = germany; Type = Forward; Status = OriginalSquad }
    let gomezMario = { Name = "Mario Gómez"; Team = germany; Type = Forward; Status = OriginalSquad }

    let germanySquad = { Team = germany
                         Players = [ neuerManuel; terStegenMarcAndre; lenoBernd; boatengJerome; hummelsMatt; howedesBenedikt; hectorJonas; mustafiShkodran; rudigerAntonio; canEmre
                                     schweinsteigerBastian; ozilMesut; kroosToni; khediraSami; gotzeMario; schurrleAndre; draxlerJulian; saneLeroy; weiglJulian; kimmichJoshua; podolskiLukas
                                     mullerThomas; gomezMario ] }

    (* let a = { Name = ""; Team = b; Type = Goalkeeper; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Defender; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Midfielder; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Forward; Status = OriginalSquad } *)

    let ukraineSquad = { Team = ukraine
                         Players = [ (* TODO *) ] }

    let szczesnyWojciech = { Name = "Wojciech Szczęsny"; Team = poland; Type = Goalkeeper; Status = OriginalSquad }
    let borucArtur = { Name = "Artur Boruc"; Team = poland; Type = Goalkeeper; Status = OriginalSquad }
    let fabianskiLukasz = { Name = "Łukasz Fabiański"; Team = poland; Type = Goalkeeper; Status = OriginalSquad }
    let pazdanMichal = { Name = "Michał Pazdan"; Team = poland; Type = Defender; Status = OriginalSquad }
    let jedrzejczykArtur = { Name = "Artur Jędrzejczyk"; Team = poland; Type = Defender; Status = OriginalSquad }
    let cionekThiago = { Name = "Thiago Cionek"; Team = poland; Type = Defender; Status = OriginalSquad }
    let wawrzyniakJakub = { Name = "Jakub Wawrzyniak"; Team = poland; Type = Defender; Status = OriginalSquad }
    let glikKamil = { Name = "Kamil Glik"; Team = poland; Type = Defender; Status = OriginalSquad }
    let salamonBartosz = { Name = "Bartosz Salamon"; Team = poland; Type = Defender; Status = OriginalSquad }
    let piszczekLukasz = { Name = "Łukasz Piszczek"; Team = poland; Type = Defender; Status = OriginalSquad }
    let maczynskiKrzysztof = { Name = "Krzysztof Mączyński"; Team = poland; Type = Midfielder; Status = OriginalSquad }
    let jodlowiecTomasz = { Name = "Tomasz Jodłowiec"; Team = poland; Type = Midfielder; Status = OriginalSquad }
    let linettyKarol = { Name = "Karol Linetty"; Team = poland; Type = Midfielder; Status = OriginalSquad }
    let krychowiakGrzegorz = { Name = "Grzegorz Krychowiak"; Team = poland; Type = Midfielder; Status = OriginalSquad }
    let grosickiKamil = { Name = "Kamil Grosicki"; Team = poland; Type = Midfielder; Status = OriginalSquad }
    let blaszczykowskiJakub = { Name = "Jakub Błaszczykowski"; Team = poland; Type = Midfielder; Status = OriginalSquad }
    let peszkoSlawomir = { Name = "Sławomir Peszko"; Team = poland; Type = Midfielder; Status = OriginalSquad }
    let zielinskiPiotr = { Name = "Piotr Zieliński"; Team = poland; Type = Midfielder; Status = OriginalSquad }
    let kapustkaBartosz = { Name = "Bartosz Kapustka"; Team = poland; Type = Midfielder; Status = OriginalSquad }
    let starzynskiFilip = { Name = "Filip Starzyński"; Team = poland; Type = Midfielder; Status = OriginalSquad }
    let milikArkadiusz = { Name = "Arkadiusz Milik"; Team = poland; Type = Forward; Status = OriginalSquad }
    let lewandowskiRobert = { Name = "Robert Lewandowski"; Team = poland; Type = Forward; Status = OriginalSquad }
    let stepinskiMariusz = { Name = "Mariusz Stępiński"; Team = poland; Type = Forward; Status = OriginalSquad }

    let polandSquad = { Team = poland
                        Players = [ szczesnyWojciech; borucArtur; fabianskiLukasz; pazdanMichal; jedrzejczykArtur; cionekThiago; wawrzyniakJakub; glikKamil; salamonBartosz; piszczekLukasz
                                    maczynskiKrzysztof; jodlowiecTomasz; linettyKarol; krychowiakGrzegorz; grosickiKamil; blaszczykowskiJakub; peszkoSlawomir; zielinskiPiotr; kapustkaBartosz
                                    starzynskiFilip; milikArkadiusz; lewandowskiRobert; stepinskiMariusz ] }

    let carrollRoy = { Name = "Roy Carroll"; Team = northernIreland; Type = Goalkeeper; Status = OriginalSquad }
    let mcGovernMichael = { Name = "Michael McGovern"; Team = northernIreland; Type = Goalkeeper; Status = OriginalSquad }
    let mannusAlan = { Name = "Alan Mannus"; Team = northernIreland; Type = Goalkeeper; Status = OriginalSquad }
    let hughesAaron = { Name = "Aaron Hughes"; Team = northernIreland; Type = Defender; Status = OriginalSquad }
    let bairdChris = { Name = "Chris Baird"; Team = northernIreland; Type = Defender; Status = OriginalSquad }
    let mcAuleyGareth = { Name = "Gareth McAuley"; Team = northernIreland; Type = Defender; Status = OriginalSquad }
    let evansJonny = { Name = "Jonny Evans"; Team = northernIreland; Type = Defender; Status = OriginalSquad }
    let cathcartCraig = { Name = "Craig Cathcart"; Team = northernIreland; Type = Defender; Status = OriginalSquad }
    let mcLaughlinConor = { Name = "Conor McLaughlin"; Team = northernIreland; Type = Defender; Status = OriginalSquad }
    let hodsonLee = { Name = "Lee Hodson"; Team = northernIreland; Type = Defender; Status = OriginalSquad }
    let mcNairPaddy = { Name = "Paddy McNair"; Team = northernIreland; Type = Defender; Status = OriginalSquad }
    let mcCulloughLuke = { Name = "Luke McCullough"; Team = northernIreland; Type = Defender; Status = OriginalSquad }
    let davisSteven = { Name = "Steven Davis"; Team = northernIreland; Type = Midfielder; Status = OriginalSquad }
    let mcGinnNiall = { Name = "Niall McGinn"; Team = northernIreland; Type = Midfielder; Status = OriginalSquad }
    let evansCorry = { Name = "Corry Evans"; Team = northernIreland; Type = Midfielder; Status = OriginalSquad }
    let norwoodOliver = { Name = "Oliver Norwood"; Team = northernIreland; Type = Midfielder; Status = OriginalSquad }
    let fergusonShane = { Name = "Shane Ferguson"; Team = northernIreland; Type = Midfielder; Status = OriginalSquad }
    let dallasStuart = { Name = "Stuart Dallas"; Team = northernIreland; Type = Midfielder; Status = OriginalSquad }
    let laffertyKyle = { Name = "Kyle Lafferty"; Team = northernIreland; Type = Forward; Status = OriginalSquad }
    let wardJamie = { Name = "Jamie Ward"; Team = northernIreland; Type = Forward; Status = OriginalSquad }
    let magennisJosh = { Name = "Josh Magennis"; Team = northernIreland; Type = Forward; Status = OriginalSquad }
    let griggWill = { Name = "Will Grigg"; Team = northernIreland; Type = Forward; Status = OriginalSquad }
    let washingtonConor = { Name = "Conor Washington"; Team = northernIreland; Type = Forward; Status = OriginalSquad }

    let northernIrelandSquad = { Team = northernIreland
                                 Players = [ carrollRoy; mcGovernMichael; mannusAlan; hughesAaron; bairdChris; mcAuleyGareth; evansJonny; cathcartCraig; mcLaughlinConor; hodsonLee; mcNairPaddy
                                             mcCulloughLuke; davisSteven; mcGinnNiall; evansCorry; norwoodOliver; fergusonShane; dallasStuart; laffertyKyle; wardJamie; magennisJosh; griggWill
                                             washingtonConor ] }

    // Group D.

    (* let a = { Name = ""; Team = b; Type = Goalkeeper; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Defender; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Midfielder; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Forward; Status = OriginalSquad } *)

    let spainSquad = { Team = spain
                       Players = [ (* TODO *) ] }

    (* let a = { Name = ""; Team = b; Type = Goalkeeper; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Defender; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Midfielder; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Forward; Status = OriginalSquad } *)

    let croatiaSquad = { Team = croatia
                         Players = [ (* TODO *) ] }

    (* let a = { Name = ""; Team = b; Type = Goalkeeper; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Defender; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Midfielder; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Forward; Status = OriginalSquad } *)

    let czechRepublicSquad = { Team = czechRepublic
                               Players = [ (* TODO *) ] }

    (* let a = { Name = ""; Team = b; Type = Goalkeeper; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Defender; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Midfielder; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Forward; Status = OriginalSquad } *)

    let turkeySquad = { Team = turkey
                        Players = [ (* TODO *) ] }

    // Group E.

    let courtoisThibaut = { Name = "Thibaut Courtois"; Team = belgium; Type = Goalkeeper; Status = OriginalSquad }
    let mignoletSimon = { Name = "Simon Mignolet"; Team = belgium; Type = Goalkeeper; Status = OriginalSquad }
    let gilletJeanFrancois = { Name = "Jean-François Gillet"; Team = belgium; Type = Goalkeeper; Status = OriginalSquad }
    let vertonghenJan = { Name = "Jan Vertonghen"; Team = belgium; Type = Defender; Status = OriginalSquad }
    let alderweireldToby = { Name = "Toby Alderweireld"; Team = belgium; Type = Defender; Status = OriginalSquad }
    let vermaelenThomas = { Name = "Thomas Vermaelen"; Team = belgium; Type = Defender; Status = OriginalSquad }
    let cimanLaurent = { Name = "Laurent Ciman"; Team = belgium; Type = Defender; Status = OriginalSquad }
    let denayerJason = { Name = "Jason Denayer"; Team = belgium; Type = Defender; Status = OriginalSquad }
    let meunierThomas = { Name = "Thomas Meunier"; Team = belgium; Type = Defender; Status = OriginalSquad }
    let lukakuJordan = { Name = "Jordan Lukaku"; Team = belgium; Type = Defender; Status = OriginalSquad }
    let kabaseleChristian = { Name = "Christian Kabasele"; Team = belgium; Type = Defender; Status = OriginalSquad }
    let fellainiMarouane = { Name = "Marouane Fellaini"; Team = belgium; Type = Midfielder; Status = OriginalSquad }
    let witselAxel = { Name = "Axel Witsel"; Team = belgium; Type = Midfielder; Status = OriginalSquad }
    let dembeleMousa = { Name = "Mousa Dembélé"; Team = belgium; Type = Midfielder; Status = OriginalSquad }
    let nainggolanRadja = { Name = "Radja Nainggolan"; Team = belgium; Type = Midfielder; Status = OriginalSquad }
    let hazardEden = { Name = "Eden Hazard"; Team = belgium; Type = Forward; Status = OriginalSquad }
    let mertensDries = { Name = "Dries Mertens"; Team = belgium; Type = Forward; Status = OriginalSquad }
    let lukakuRomelu = { Name = "Romelu Lukaku"; Team = belgium; Type = Forward; Status = OriginalSquad }
    let deBruyneKevin = { Name = "Kevin De Bruyne"; Team = belgium; Type = Forward; Status = OriginalSquad }
    let bentekeChristian = { Name = "Christian Benteke"; Team = belgium; Type = Forward; Status = OriginalSquad }
    let origiDivock = { Name = "Divock Origi"; Team = belgium; Type = Forward; Status = OriginalSquad }
    let carrascoYannickFerreira = { Name = "Yannick Ferreira Carrasco"; Team = belgium; Type = Forward; Status = OriginalSquad }
    let batshuayiMichy = { Name = "Michy Batshuayi"; Team = belgium; Type = Forward; Status = OriginalSquad }

    let belgiumSquad = { Team = belgium
                         Players = [ courtoisThibaut; mignoletSimon; gilletJeanFrancois; vertonghenJan; alderweireldToby; vermaelenThomas; cimanLaurent; denayerJason; meunierThomas; lukakuJordan
                                     kabaseleChristian; fellainiMarouane; witselAxel; dembeleMousa; nainggolanRadja; hazardEden; mertensDries; lukakuRomelu; deBruyneKevin; bentekeChristian
                                     origiDivock; carrascoYannickFerreira; batshuayiMichy ] }

    (* let a = { Name = ""; Team = b; Type = Goalkeeper; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Defender; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Midfielder; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Forward; Status = OriginalSquad } *)

    let italySquad = { Team = italy
                       Players = [ (* TODO *) ] }

    let isakssonAndreas = { Name = "Andreas Isaksson"; Team = sweden; Type = Goalkeeper; Status = OriginalSquad }
    let olsenRobin = { Name = "Robin Olsen"; Team = sweden; Type = Goalkeeper; Status = OriginalSquad }
    let carlgrenPatrik = { Name = "Patrik Carlgren"; Team = sweden; Type = Goalkeeper; Status = OriginalSquad }
    let granqvistAndreas = { Name = "Andreas Granqvist"; Team = sweden; Type = Defender; Status = OriginalSquad }
    let lustigMikael = { Name = "Mikael Lustig"; Team = sweden; Type = Defender; Status = OriginalSquad }
    let olssonMartin = { Name = "Martin Olsson"; Team = sweden; Type = Defender; Status = OriginalSquad }
    let johanssonErik = { Name = "Erik Johansson"; Team = sweden; Type = Defender; Status = OriginalSquad }
    let janssonPontus = { Name = "Pontus Jansson"; Team = sweden; Type = Defender; Status = OriginalSquad }
    let augustinssonLudwig = { Name = "Ludwig Augustinsson"; Team = sweden; Type = Defender; Status = OriginalSquad }
    let lindelofVictor = { Name = "Victor Lindelöf"; Team = sweden; Type = Defender; Status = OriginalSquad }
    let kallstromKim = { Name = "Kim Källström"; Team = sweden; Type = Midfielder; Status = OriginalSquad }
    let larssonSebastian = { Name = "Sebastian Larsson"; Team = sweden; Type = Midfielder; Status = OriginalSquad }
    let wernbloomPontus = { Name = "Pontus Wernbloom"; Team = sweden; Type = Midfielder; Status = OriginalSquad }
    let durmazJimmy = { Name = "Jimmy Durmaz"; Team = sweden; Type = Midfielder; Status = OriginalSquad }
    let ekdalAlbin = { Name = "Albin Ekdal"; Team = sweden; Type = Midfielder; Status = OriginalSquad }
    let zenginErkan = { Name = "Erkan Zengin"; Team = sweden; Type = Midfielder; Status = OriginalSquad }
    let forsbergEmil = { Name = "Emil Forsberg"; Team = sweden; Type = Midfielder; Status = OriginalSquad }
    let hiljemarkOscar = { Name = "Oscar Hiljemark"; Team = sweden; Type = Midfielder; Status = OriginalSquad }
    let lewickiOscar = { Name = "Oscar Lewicki"; Team = sweden; Type = Midfielder; Status = OriginalSquad }
    let ibrahimovicZlatan = { Name = "Zlatan Ibrahimović"; Team = sweden; Type = Forward; Status = OriginalSquad }
    let bergMarcus = { Name = "Marcus Berg"; Team = sweden; Type = Forward; Status = OriginalSquad }
    let guidettiJohn = { Name = "John Guidetti"; Team = sweden; Type = Forward; Status = OriginalSquad }
    let kujovicEmir = { Name = "Emir Kujović"; Team = sweden; Type = Forward; Status = OriginalSquad }

    let swedenSquad = { Team = sweden
                        Players = [ isakssonAndreas; olsenRobin; carlgrenPatrik; granqvistAndreas; lustigMikael; olssonMartin; johanssonErik; janssonPontus; augustinssonLudwig; lindelofVictor
                                    kallstromKim; larssonSebastian; wernbloomPontus; durmazJimmy; ekdalAlbin; zenginErkan; forsbergEmil; hiljemarkOscar; lewickiOscar; ibrahimovicZlatan; bergMarcus
                                    guidettiJohn; kujovicEmir ] }

    (* let a = { Name = ""; Team = b; Type = Goalkeeper; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Defender; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Midfielder; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Forward; Status = OriginalSquad } *)

    let republicOfIrelandSquad = { Team = republicOfIreland
                                   Players = [ (* TODO *) ] }

    // Group F.

    let patricioRui = { Name = "Rui Patrício"; Team = portugal; Type = Goalkeeper; Status = OriginalSquad }
    let eduardo = { Name = "Eduardo"; Team = portugal; Type = Goalkeeper; Status = OriginalSquad }
    let lopesAnthony = { Name = "Anthony Lopes"; Team = portugal; Type = Goalkeeper; Status = OriginalSquad }
    let alvesBruno = { Name = "Bruno Alves"; Team = portugal; Type = Defender; Status = OriginalSquad }
    let carvalhoRicardo = { Name = "Ricardo Carvalho"; Team = portugal; Type = Defender; Status = OriginalSquad }
    let pepe = { Name = "Pepe"; Team = portugal; Type = Defender; Status = OriginalSquad }
    let vieirinha = { Name = "Vieirinha"; Team = portugal; Type = Defender; Status = OriginalSquad }
    let eliseu = { Name = "Eliseu"; Team = portugal; Type = Defender; Status = OriginalSquad }
    let fonteJose = { Name = "José Fonte"; Team = portugal; Type = Defender; Status = OriginalSquad }
    let cedric = { Name = "Cédric"; Team = portugal; Type = Defender; Status = OriginalSquad }
    let guerreiroRaphael = { Name = "Raphaël Guerreiro"; Team = portugal; Type = Defender; Status = OriginalSquad }
    let moutinhoJoao = { Name = "João Moutinho"; Team = portugal; Type = Midfielder; Status = OriginalSquad }
    let carvalhoWilliam = { Name = "William Carvalho"; Team = portugal; Type = Midfielder; Status = OriginalSquad }
    let pereiraDanilo = { Name = "Danilo Pereira"; Team = portugal; Type = Midfielder; Status = OriginalSquad }
    let marioJoao = { Name = "João Mário"; Team = portugal; Type = Midfielder; Status = OriginalSquad }
    let silvaAdrien = { Name = "Adrien Silva"; Team = portugal; Type = Midfielder; Status = OriginalSquad }
    let gomesAndre = { Name = "André Gomes"; Team = portugal; Type = Midfielder; Status = OriginalSquad }
    let sanchesRenato = { Name = "Renato Sanches"; Team = portugal; Type = Midfielder; Status = OriginalSquad }
    let ronaldoCristiano = { Name = "Cristiano Ronaldo"; Team = portugal; Type = Forward; Status = OriginalSquad }
    let nani = { Name = "Nani"; Team = portugal; Type = Forward; Status = OriginalSquad }
    let quaresmaRicardo = { Name = "Ricardo Quaresma"; Team = portugal; Type = Forward; Status = OriginalSquad }
    let eder = { Name = "Éder"; Team = portugal; Type = Forward; Status = OriginalSquad }
    let silvaRafa = { Name = "Rafa Silva"; Team = portugal; Type = Forward; Status = OriginalSquad }

    let portugalSquad = { Team = portugal
                          Players = [ patricioRui; eduardo; lopesAnthony; alvesBruno; carvalhoRicardo; pepe; vieirinha; eliseu; fonteJose; cedric; guerreiroRaphael; moutinhoJoao; carvalhoWilliam;
                                      pereiraDanilo; marioJoao; silvaAdrien; gomesAndre; sanchesRenato; ronaldoCristiano; nani; quaresmaRicardo; eder; silvaRafa ] }

    (* let a = { Name = ""; Team = b; Type = Goalkeeper; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Defender; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Midfielder; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Forward; Status = OriginalSquad } *)

    let austriaSquad = { Team = austria
                         Players = [ (* TODO *) ] }

    (* let a = { Name = ""; Team = b; Type = Goalkeeper; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Defender; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Midfielder; Status = OriginalSquad }
    let a = { Name = ""; Team = b; Type = Forward; Status = OriginalSquad } *)

    let hungarySquad = { Team = hungary
                         Players = [ (* TODO *) ] }

    let halldorssonHannesThor = { Name = "Hannes Þór Halldórsson"; Team = iceland; Type = Goalkeeper; Status = OriginalSquad }
    let kristinssonOgmundur = { Name = "Ögmundur Kristinsson"; Team = iceland; Type = Goalkeeper; Status = OriginalSquad }
    let jonssonIngvar = { Name = "Ingvar Jónsson"; Team = iceland; Type = Goalkeeper; Status = OriginalSquad }
    let saevarssonBirkirMar = { Name = "Birkir Már Sævarsson"; Team = iceland; Type = Defender; Status = OriginalSquad }
    let sigurdssonRagnar = { Name = "Ragnar Sigurðsson"; Team = iceland; Type = Defender; Status = OriginalSquad }
    let arnasonKari = { Name = "Kári Árnason"; Team = iceland; Type = Defender; Status = OriginalSquad }
    let skulasonAriFreyr = { Name = "Ari Freyr Skúlason"; Team = iceland; Type = Defender; Status = OriginalSquad }
    let haukssonHaukurHeidar = { Name = "Haukur Heiðar Hauksson"; Team = iceland; Type = Defender; Status = OriginalSquad }
    let ingasonSverrirIngi = { Name = "Sverrir Ingi Ingason"; Team = iceland; Type = Defender; Status = OriginalSquad }
    let magnussonHordurBjorgvin = { Name = "Hörður Björgvin Magnússon"; Team = iceland; Type = Defender; Status = OriginalSquad }
    let hermannssonHjortur = { Name = "Hjörtur Hermannsson"; Team = iceland; Type = Defender; Status = OriginalSquad }
    let gunnarssonAron = { Name = "Aron Gunnarsson"; Team = iceland; Type = Midfielder; Status = OriginalSquad }
    let hallfredssonEmil = { Name = "Emil Hallfreðsson"; Team = iceland; Type = Midfielder; Status = OriginalSquad }
    let bjarnasonBirkir = { Name = "Birkir Bjarnason"; Team = iceland; Type = Midfielder; Status = OriginalSquad }
    let gudmundssonJohannBerg = { Name = "Jóhann Berg Guðmundsson"; Team = iceland; Type = Midfielder; Status = OriginalSquad }
    let sigurdssonGylfi = { Name = "Gylfi Sigurðsson"; Team = iceland; Type = Midfielder; Status = OriginalSquad }
    let bjarnssonTheodorElmar = { Name = "Theódór Elmar Bjarnason"; Team = iceland; Type = Midfielder; Status = OriginalSquad }
    let sigurjonssonRunarMar = { Name = "Rúnar Már Sigurjónsson"; Team = iceland; Type = Midfielder; Status = OriginalSquad }
    let traustasonArnorIngvi = { Name = "Arnór Ingvi Traustason"; Team = iceland; Type = Midfielder; Status = OriginalSquad }
    let gudjohnsenEidur = { Name = "Eiður Guðjohnsen"; Team = iceland; Type = Forward; Status = OriginalSquad }
    let sigthorssonKolbeinn = { Name = "Kolbeinn Sigþórsson"; Team = iceland; Type = Forward; Status = OriginalSquad }
    let finnbogasonAlfred = { Name = "Alfreð Finnbogason"; Team = iceland; Type = Forward; Status = OriginalSquad }
    let bodvarssonJonDadi = { Name = "Jón Daði Böðvarsson"; Team = iceland; Type = Forward; Status = OriginalSquad }

    let icelandSquad = { Team = iceland
                         Players = [ halldorssonHannesThor; kristinssonOgmundur; jonssonIngvar; saevarssonBirkirMar; sigurdssonRagnar; arnasonKari; skulasonAriFreyr; haukssonHaukurHeidar
                                     ingasonSverrirIngi; magnussonHordurBjorgvin; hermannssonHjortur; gunnarssonAron; hallfredssonEmil; bjarnasonBirkir; gudmundssonJohannBerg; sigurdssonGylfi
                                     bjarnssonTheodorElmar; sigurjonssonRunarMar; traustasonArnorIngvi; gudjohnsenEidur; sigthorssonKolbeinn; finnbogasonAlfred; bodvarssonJonDadi ] }

    let teams = [ france; switzerland; romania; albania
                  england; russia; slovakia; wales
                  germany; ukraine; poland; northernIreland
                  spain; croatia; czechRepublic; turkey
                  belgium; italy; sweden; republicOfIreland
                  portugal; austria; hungary; iceland ]

    let coaches = teams |> List.map (fun team -> team.Coach, team)

    let squads = [ franceSquad; switzerlandSquad; romaniaSquad; albaniaSquad
                   englandSquad; russiaSquad; slovakiaSquad; walesSquad
                   germanySquad; ukraineSquad; polandSquad; northernIrelandSquad
                   spainSquad; croatiaSquad; czechRepublicSquad; turkeySquad
                   belgiumSquad; italySquad; swedenSquad; republicOfIrelandSquad
                   portugalSquad; austriaSquad; hungarySquad; icelandSquad ]

    let players = squads |> List.collect (fun squad -> squad.Players |> List.map id)

    let groupA = Group ('A', [ france; switzerland; romania; albania ] )
    let groupB = Group ('B', [ england; russia; slovakia; wales ] )
    let groupC = Group ('C', [ germany; ukraine; poland; northernIreland ] )
    let groupD = Group ('D', [ spain; croatia; czechRepublic; turkey ] )
    let groupE = Group ('E', [ belgium; italy; sweden; republicOfIreland ] )
    let groupF = Group ('F', [ portugal; austria; hungary; iceland ] )

    // Group A matches: https://en.wikipedia.org/wiki/UEFA_Euro_2016_Group_A.

    let groupAFranceVsRomania = { Team1Score = TeamMatchScore (france, 0<goal>, None); Team2Score = TeamMatchScore (romania, 0<goal>, None)
                                  Number = 1; Stage = groupA; KickOff = DateTime (2016, 06, 10, 20, 00, 00)
                                  Events = [ (* france *) (* romania *) ] }

    let groupAAlbaniaVsSwitzerland = { Team1Score = TeamMatchScore (albania, 0<goal>, None); Team2Score = TeamMatchScore (switzerland, 0<goal>, None)
                                       Number = 2; Stage = groupA; KickOff = DateTime (2016, 06, 11, 14, 00, 00)
                                       Events = [ (* albania *) (* switzerland *) ] }
                                           
    let groupARomaniaVsSwitzerland = { Team1Score = TeamMatchScore (romania, 0<goal>, None); Team2Score = TeamMatchScore (switzerland, 0<goal>, None)
                                       Number = 14; Stage = groupA; KickOff = DateTime (2016, 06, 15, 17, 00, 00)
                                       Events = [ (* romania *) (* switzerland *) ] }
                                           
    let groupAFranceVsAlbania = { Team1Score = TeamMatchScore (france, 0<goal>, None); Team2Score = TeamMatchScore (albania, 0<goal>, None)
                                  Number = 15; Stage = groupA; KickOff = DateTime (2016, 06, 15, 20, 00, 00)
                                  Events = [ (* france *) (* albania *) ] }
                                           
    let groupARomaniaVsAlbania = { Team1Score = TeamMatchScore (romania, 0<goal>, None); Team2Score = TeamMatchScore (albania, 0<goal>, None)
                                   Number = 25; Stage = groupA; KickOff = DateTime (2016, 06, 19, 20, 00, 00)
                                   Events = [ (* romania *) (* albania *) ] }
                                           
    let groupASwitzerlandVsFrance = { Team1Score = TeamMatchScore (switzerland, 0<goal>, None); Team2Score = TeamMatchScore (france, 0<goal>, None)
                                      Number = 26; Stage = groupA; KickOff = DateTime (2016, 06, 19, 20, 00, 00)
                                      Events = [ (* switzerland *) (* france *) ] }
                                           
    let groupAMatches = [ groupAFranceVsRomania; groupAAlbaniaVsSwitzerland; groupARomaniaVsSwitzerland; groupAFranceVsAlbania; groupARomaniaVsAlbania; groupASwitzerlandVsFrance ]

    // Group B matches: https://en.wikipedia.org/wiki/UEFA_Euro_2016_Group_B.

    let groupBWalesVsSlovakia = { Team1Score = TeamMatchScore (wales, 0<goal>, None); Team2Score = TeamMatchScore (slovakia, 0<goal>, None)
                                  Number = 3; Stage = groupB; KickOff = DateTime (2016, 06, 11, 17, 00, 00)
                                  Events = [ (* wales *) (* slovakia *) ] }
                                           
    let groupBEnglandVsRussia = { Team1Score = TeamMatchScore (england, 0<goal>, None); Team2Score = TeamMatchScore (russia, 0<goal>, None)
                                  Number = 4; Stage = groupB; KickOff = DateTime (2016, 06, 11, 20, 00, 00)
                                  Events = [ (* england *) (* russia *) ] }
                                           
    let groupBRussiaVsSlovakia = { Team1Score = TeamMatchScore (russia, 0<goal>, None); Team2Score = TeamMatchScore (slovakia, 0<goal>, None)
                                   Number = 13; Stage = groupB; KickOff = DateTime (2016, 06, 15, 14, 00, 00)
                                   Events = [ (* russia *) (* slovakia *) ] }
                                           
    let groupBEnglandVsWales = { Team1Score = TeamMatchScore (england, 0<goal>, None); Team2Score = TeamMatchScore (wales, 0<goal>, None)
                                 Number = 16; Stage = groupB; KickOff = DateTime (2016, 06, 16, 14, 00, 00)
                                 Events = [ (* england *) (* wales *) ] }
                                           
    let groupBRussiaVsWales = { Team1Score = TeamMatchScore (russia, 0<goal>, None); Team2Score = TeamMatchScore (wales, 0<goal>, None)
                                Number = 27; Stage = groupB; KickOff = DateTime (2016, 06, 20, 20, 00, 00)
                                Events = [ (* russia *) (* wales *) ] }
                                           
    let groupBSlovakiaVsEngland = { Team1Score = TeamMatchScore (slovakia, 0<goal>, None); Team2Score = TeamMatchScore (england, 0<goal>, None)
                                    Number = 28; Stage = groupB; KickOff = DateTime (2016, 06, 20, 20, 00, 00)
                                    Events = [ (* slovakia *) (* england *) ] }
                                           
    let groupBMatches = [ groupBWalesVsSlovakia; groupBEnglandVsRussia; groupBRussiaVsSlovakia; groupBEnglandVsWales; groupBRussiaVsWales; groupBSlovakiaVsEngland ]

    // Group C matches: https://en.wikipedia.org/wiki/UEFA_Euro_2016_Group_C.

    let groupCPolandVsNorthernIreland = { Team1Score = TeamMatchScore (poland, 0<goal>, None); Team2Score = TeamMatchScore (northernIreland, 0<goal>, None)
                                          Number = 6; Stage = groupC; KickOff = DateTime (2016, 06, 12, 17, 00, 00)
                                          Events = [ (* poland *) (* northernIreland *) ] }
                                           
    let groupCGermanyVsUkraine = { Team1Score = TeamMatchScore (germany, 0<goal>, None); Team2Score = TeamMatchScore (ukraine, 0<goal>, None)
                                   Number = 7; Stage = groupC; KickOff = DateTime (2016, 06, 12, 20, 00, 00)
                                   Events = [ (* germany *) (* ukraine *) ] }
                                           
    let groupCUkraineVsNorthernIreland = { Team1Score = TeamMatchScore (ukraine, 0<goal>, None); Team2Score = TeamMatchScore (northernIreland, 0<goal>, None)
                                           Number = 17; Stage = groupC; KickOff = DateTime (2016, 06, 16, 17, 00, 00)
                                           Events = [ (* ukraine *) (* northernIreland *) ] }
                                           
    let groupCGermanyVsPoland = { Team1Score = TeamMatchScore (germany, 0<goal>, None); Team2Score = TeamMatchScore (poland, 0<goal>, None)
                                  Number = 18; Stage = groupC; KickOff = DateTime (2016, 06, 16, 20, 00, 00)
                                  Events = [ (* germany *) (* poland *) ] }
                                           
    let groupCUkraineVsPoland = { Team1Score = TeamMatchScore (ukraine, 0<goal>, None); Team2Score = TeamMatchScore (poland, 0<goal>, None)
                                  Number = 29; Stage = groupC; KickOff = DateTime (2016, 06, 21, 17, 00, 00)
                                  Events = [ (* ukraine *) (* poland *) ] }
                                           
    let groupCNorthernIrelandVsGermany = { Team1Score = TeamMatchScore (northernIreland, 0<goal>, None); Team2Score = TeamMatchScore (germany, 0<goal>, None)
                                           Number = 30; Stage = groupC; KickOff = DateTime (2016, 06, 21, 17, 00, 00)
                                           Events = [ (* northernIreland *) (* germany *) ] }
                                           
    let groupCMatches = [ groupCPolandVsNorthernIreland; groupCGermanyVsUkraine; groupCUkraineVsNorthernIreland; groupCGermanyVsPoland; groupCUkraineVsPoland; groupCNorthernIrelandVsGermany ]

    // Group D matches: https://en.wikipedia.org/wiki/UEFA_Euro_2016_Group_D.

    let groupDTurkeyVsCroatia = { Team1Score = TeamMatchScore (turkey, 0<goal>, None); Team2Score = TeamMatchScore (croatia, 0<goal>, None)
                                  Number = 5; Stage = groupD; KickOff = DateTime (2016, 06, 12, 12, 00, 00)
                                  Events = [ (* turkey *) (* croatia *) ] }
                                           
    let groupDSpainVsCzechRepublic = { Team1Score = TeamMatchScore (spain, 0<goal>, None); Team2Score = TeamMatchScore (czechRepublic, 0<goal>, None)
                                       Number = 8; Stage = groupD; KickOff = DateTime (2016, 06, 13, 12, 00, 00)
                                       Events = [ (* spain *) (* czechRepublic *) ] }
                                           
    let groupDCzechRepublicVsCroatia = { Team1Score = TeamMatchScore (czechRepublic, 0<goal>, None); Team2Score = TeamMatchScore (croatia, 0<goal>, None)
                                         Number = 20; Stage = groupD; KickOff = DateTime (2016, 06, 17, 17, 00, 00)
                                         Events = [ (* czechRepublic *) (* croatia *) ] }
                                           
    let groupDSpainVsTurkey = { Team1Score = TeamMatchScore (spain, 0<goal>, None); Team2Score = TeamMatchScore (turkey, 0<goal>, None)
                                Number = 21; Stage = groupD; KickOff = DateTime (2016, 06, 17, 20, 00, 00)
                                Events = [ (* spain *) (* turkey *) ] }
                                           
    let groupDCzechRepublicVsTurkey = { Team1Score = TeamMatchScore (czechRepublic, 0<goal>, None); Team2Score = TeamMatchScore (turkey, 0<goal>, None)
                                        Number = 31; Stage = groupD; KickOff = DateTime (2016, 06, 21, 20, 00, 00)
                                        Events = [ (* czechRepublic *) (* turkey *) ] }
                                           
    let groupDCroatiaVsSpain = { Team1Score = TeamMatchScore (croatia, 0<goal>, None); Team2Score = TeamMatchScore (spain, 0<goal>, None)
                                 Number = 32; Stage = groupD; KickOff = DateTime (2016, 06, 21, 20, 00, 00)
                                 Events = [ (* croatia *) (* spain *) ] }
                                           
    let groupDMatches = [ groupDTurkeyVsCroatia; groupDSpainVsCzechRepublic; groupDCzechRepublicVsCroatia; groupDSpainVsTurkey; groupDCzechRepublicVsTurkey; groupDCroatiaVsSpain ]

    // Group E matches: https://en.wikipedia.org/wiki/UEFA_Euro_2016_Group_E.

    let groupERepublicOfIrelandVsSweden = { Team1Score = TeamMatchScore (republicOfIreland, 0<goal>, None); Team2Score = TeamMatchScore (sweden, 0<goal>, None)
                                            Number = 9; Stage = groupE; KickOff = DateTime (2016, 06, 13, 17, 00, 00)
                                            Events = [ (* republicOfIreland *) (* sweden *) ] }
                                           
    let groupEBelgiumVsItaly = { Team1Score = TeamMatchScore (belgium, 0<goal>, None); Team2Score = TeamMatchScore (italy, 0<goal>, None)
                                 Number = 10; Stage = groupE; KickOff = DateTime (2016, 06, 13, 20, 00, 00)
                                 Events = [ (* belgium *) (* italy *) ] }
                                           
    let groupEItalyVsSweden = { Team1Score = TeamMatchScore (italy, 0<goal>, None); Team2Score = TeamMatchScore (sweden, 0<goal>, None)
                                Number = 19; Stage = groupE; KickOff = DateTime (2016, 06, 17, 14, 00, 00)
                                Events = [ (* italy *) (* sweden *) ] }
                                           
    let groupEBelgiumVsRepublicOfIreland = { Team1Score = TeamMatchScore (belgium, 0<goal>, None); Team2Score = TeamMatchScore (republicOfIreland, 0<goal>, None)
                                             Number = 22; Stage = groupE; KickOff = DateTime (2016, 06, 18, 14, 00, 00)
                                             Events = [ (* belgium *) (* republicOfIreland *) ] }
                                           
    let groupEItalyVsRepublicOfIreland = { Team1Score = TeamMatchScore (italy, 0<goal>, None); Team2Score = TeamMatchScore (republicOfIreland, 0<goal>, None)
                                           Number = 35; Stage = groupE; KickOff = DateTime (2016, 06, 22, 20, 00, 00)
                                           Events = [ (* italy *) (* republicOfIreland *) ] }
                                           
    let groupESwedenVsBelgium = { Team1Score = TeamMatchScore (sweden, 0<goal>, None); Team2Score = TeamMatchScore (belgium, 0<goal>, None)
                                  Number = 36; Stage = groupE; KickOff = DateTime (2016, 06, 22, 20, 00, 00)
                                  Events = [ (* sweden *) (* belgium *) ] }
                                           
    let groupEMatches = [ groupERepublicOfIrelandVsSweden; groupEBelgiumVsItaly; groupEItalyVsSweden; groupEBelgiumVsRepublicOfIreland; groupEItalyVsRepublicOfIreland; groupESwedenVsBelgium ]

    // Group F matches: https://en.wikipedia.org/wiki/UEFA_Euro_2016_Group_F.

    let groupFAustriaVsHungary = { Team1Score = TeamMatchScore (austria, 0<goal>, None); Team2Score = TeamMatchScore (hungary, 0<goal>, None)
                                   Number = 11; Stage = groupF; KickOff = DateTime (2016, 06, 14, 17, 00, 00)
                                   Events = [ (* austria *) (* hungary *) ] }
                                           
    let groupFPortugalVsIceland = { Team1Score = TeamMatchScore (portugal, (* TEMP... *) 0<goal> (* <0>goal ...TEMP *), None)
                                    Team2Score = TeamMatchScore (iceland, (* TEMP... *) 3<goal> (* <0>goal ...TEMP *), None)
                                    Number = 12; Stage = groupF; KickOff = (* TEMP... *) DateTime (2016, 05, 06, 20, 00, 00) (* DateTime (2016, 06, 14, 20, 00, 00) ...TEMP *)
                                    Events = [ (* portugal *) (* iceland *)                                                
                                 (* TEMP... *) ManOfTheMatch sigurdssonGylfi
                                               YellowCard (ronaldoCristiano, Some 4<min>) (* portugal *)                                             
                                               YellowCard (carvalhoRicardo, Some 16<min>)
                                               Penalty (ronaldoCristiano, false, Some 37<min>, None, Some halldorssonHannesThor)
                                               YellowCard (moutinhoJoao, Some 61<min>)
                                               RedCard (ronaldoCristiano, Some 82<min>)
                                               RedCard (fonteJose, Some 86<min>)
                                               OwnGoal (iceland, ronaldoCristiano, Some 3<min>) (* iceland *)
                                               YellowCard (skulasonAriFreyr, Some 29<min>)
                                               Goal (gudjohnsenEidur, Some 81<min>, Some sigurdssonGylfi)
                                               Penalty (sigurdssonGylfi, true, Some 87<min>, Some sigurdssonGylfi, None)
                                               CleanSheet (halldorssonHannesThor, Some kristinssonOgmundur) (* ...TEMP *) ] }

    let groupFIcelandVsHungary = { Team1Score = TeamMatchScore (iceland, 0<goal>, None); Team2Score = TeamMatchScore (hungary, 0<goal>, None)
                                   Number = 23; Stage = groupF; KickOff = DateTime (2016, 06, 18, 17, 00, 00)
                                   Events = [ (* iceland *) (* hungary *) ] }
                                           
    let groupFPortugalVsAustria = { Team1Score = TeamMatchScore (portugal, 0<goal>, None); Team2Score = TeamMatchScore (austria, 0<goal>, None)
                                    Number = 24; Stage = groupF; KickOff = DateTime (2016, 06, 18, 20, 00, 00)
                                    Events = [ (* portugal *) (* austria *) ] }
                                           
    let groupFIcelandVsAustria = { Team1Score = TeamMatchScore (iceland, 0<goal>, None); Team2Score = TeamMatchScore (austria, 0<goal>, None)
                                   Number = 33; Stage = groupF; KickOff = DateTime (2016, 06, 22, 17, 00, 00)
                                   Events = [ (* iceland *) (* austria *) ] }
                                           
    let groupFHungaryVsPortugal = { Team1Score = TeamMatchScore (hungary, 0<goal>, None); Team2Score = TeamMatchScore (portugal, 0<goal>, None)
                                    Number = 34; Stage = groupF; KickOff = DateTime (2016, 06, 22, 17, 00, 00)
                                    Events = [ (* hungary *) (* portugal *) ] }
                                           
    let groupFMatches = [ groupFAustriaVsHungary; groupFPortugalVsIceland; groupFIcelandVsHungary; groupFPortugalVsAustria; groupFIcelandVsAustria; groupFHungaryVsPortugal ]

    // Knockout matches: https://en.wikipedia.org/wiki/UEFA_Euro_2016#Knockout_phase.

    // TEMP: Placeholders until the actual teams are known...
    let winnerA = { Name = "Winner A"; Status = Active; Seeding = 1; Coach = "Winner A" }
    let winnerB = { Name = "Winner B"; Status = Active; Seeding = 2; Coach = "Winner B" }
    let winnerC = { Name = "Winner C"; Status = Active; Seeding = 3; Coach = "Winner C" }
    let winnerD = { Name = "Winner D"; Status = Active; Seeding = 4; Coach = "Winner D" }
    let winnerE = { Name = "Winner E"; Status = Active; Seeding = 5; Coach = "Winner E" }
    let winnerF = { Name = "Winner F"; Status = Active; Seeding = 6; Coach = "Winner F" }

    let runnerUpA = { Name = "Runner-up A"; Status = Active; Seeding = 7; Coach = "Runner-up A" }
    let runnerUpB = { Name = "Runner-up B"; Status = Active; Seeding = 8; Coach = "Runner-up B" }
    let runnerUpC = { Name = "Runner-up C"; Status = Active; Seeding = 9; Coach = "Runner-up C" }
    let runnerUpD = { Name = "Runner-up D"; Status = Active; Seeding = 10; Coach = "Runner-up D" }
    let runnerUpE = { Name = "Runner-up E"; Status = Active; Seeding = 11; Coach = "Runner-up E" }
    let runnerUpF = { Name = "Runner-up F"; Status = Active; Seeding = 12; Coach = "Runner-up F" }

    let thirdABF = { Name = "Third place A/B/F"; Status = Active; Seeding = 13; Coach = "Third place A/B/F" }
    let thirdACD = { Name = "Third place A/C/D"; Status = Active; Seeding = 14; Coach = "Third place A/C/D" }
    let thirdBEF = { Name = "Third place B/E/F"; Status = Active; Seeding = 15; Coach = "Third place B/E/F" }
    let thirdCDE = { Name = "Third place C/D/E"; Status = Active; Seeding = 16; Coach = "Third place C/D/E" }

    let winnerMatch37 = { Name = "Winner match 37"; Status = Active; Seeding = 1; Coach = "Winner match 37" } 
    let winnerMatch38 = { Name = "Winner match 38"; Status = Active; Seeding = 2; Coach = "Winner match 38" } 
    let winnerMatch39 = { Name = "Winner match 39"; Status = Active; Seeding = 3; Coach = "Winner match 39" } 
    let winnerMatch40 = { Name = "Winner match 40"; Status = Active; Seeding = 4; Coach = "Winner match 40" } 
    let winnerMatch41 = { Name = "Winner match 41"; Status = Active; Seeding = 5; Coach = "Winner match 41" } 
    let winnerMatch42 = { Name = "Winner match 42"; Status = Active; Seeding = 6; Coach = "Winner match 42" } 
    let winnerMatch43 = { Name = "Winner match 43"; Status = Active; Seeding = 7; Coach = "Winner match 43" } 
    let winnerMatch44 = { Name = "Winner match 44"; Status = Active; Seeding = 8; Coach = "Winner match 44" } 

    let winnerQF1 = { Name = "Winner QF1"; Status = Active; Seeding = 1; Coach = "Winner QF1" }
    let winnerQF2 = { Name = "Winner QF2"; Status = Active; Seeding = 2; Coach = "Winner QF2" }
    let winnerQF3 = { Name = "Winner QF3"; Status = Active; Seeding = 3; Coach = "Winner QF3" }
    let winnerQF4 = { Name = "Winner QF4"; Status = Active; Seeding = 4; Coach = "Winner QF4" }

    let winnerSF1 = { Name = "Winner SF1"; Status = Active; Seeding = 1; Coach = "Winner SF1" }
    let winnerSF2 = { Name = "Winner SF2"; Status = Active; Seeding = 2; Coach = "Winner SF2" }
    // ...TEMP

    let match37XVsY = { Team1Score = TeamMatchScore (runnerUpA, 0<goal>, None); Team2Score = TeamMatchScore (runnerUpC, 0<goal>, None)
                        Number = 37; Stage = RoundOf16 37; KickOff = DateTime (2016, 06, 25, 14, 00, 00)
                        Events = [ (* runnerUpA *) (* runnerUpC *) ] }
                                           
    let match38XVsY = { Team1Score = TeamMatchScore (winnerB, 0<goal>, None); Team2Score = TeamMatchScore (thirdACD, 0<goal>, None)
                        Number = 38; Stage = RoundOf16 38; KickOff = DateTime (2016, 06, 25, 17, 00, 00)
                        Events = [ (* winnerB *) (* thirdACD *) ] }

    let match39XVsY = { Team1Score = TeamMatchScore (winnerD, 0<goal>, None); Team2Score = TeamMatchScore (thirdBEF, 0<goal>, None)
                        Number = 39; Stage = RoundOf16 39; KickOff = DateTime (2016, 06, 25, 20, 00, 00)
                        Events = [ (* winnerD *) (* thirdBEF *) ] }

    let match40XVsY = { Team1Score = TeamMatchScore ((* TEMP... *) france (* winnerA ...TEMP *), (* TEMP... *) 1<goal> (* <0>goal ...TEMP *), Some 4<shootoutPenalty>)
                        Team2Score = TeamMatchScore ((* TEMP... *) iceland (* thirdCDE ...TEMP *), (* TEMP... *) 1<goal> (* <0>goal ...TEMP *), Some 2<shootoutPenalty>)
                        Number = 40; Stage = RoundOf16 40; KickOff = (* TEMP... *) DateTime (2016, 05, 20, 14, 00, 00) (* DateTime (2016, 06, 26, 14, 00, 00) ...TEMP *)
                        Events = [ (* winnerA *) (* thirdCDE *)
                     (* TEMP... *) ManOfTheMatch kanteNGolo
                                   YellowCard (koscielnyLaurent, Some 38<min>) (* france *)                                             
                                   Penalty (giroudOlivier, false, Some 48<min>, Some payetDimitri, None)
                                   YellowCard (martialAnthony, Some 75<min>)
                                   Goal (griezmannAntoine, Some 118<min>, Some cabayeYohan)
                                   ShootoutPenalty (pogbaPaul, true)
                                   ShootoutPenalty (cabayeYohan, true)
                                   ShootoutPenalty (giroudOlivier, false)
                                   ShootoutPenalty (griezmannAntoine, true)
                                   ShootoutPenalty (payetDimitri, true)
                                   YellowCard (saevarssonBirkirMar, Some 47<min>) (* iceland *)
                                   YellowCard (gunnarssonAron, Some 94<min>)                                  
                                   Goal (sigurdssonGylfi, Some 107<min>, Some sigurjonssonRunarMar)
                                   ShootoutPenalty (gudjohnsenEidur, true)
                                   ShootoutPenalty (sigurdssonGylfi, true)
                                   ShootoutPenalty (sigurjonssonRunarMar, false)
                                   ShootoutPenalty (saevarssonBirkirMar, false) (* ...TEMP *) ] }

    let match41XVsY = { Team1Score = TeamMatchScore (winnerC, 0<goal>, None); Team2Score = TeamMatchScore (thirdABF, 0<goal>, None)
                        Number = 41; Stage = RoundOf16 41; KickOff = DateTime (2016, 06, 26, 17, 00, 00)
                        Events = [ (* winnerC *) (* thirdABF *) ] }

    let match42XVsY = { Team1Score = TeamMatchScore (winnerF, 0<goal>, None); Team2Score = TeamMatchScore (runnerUpE, 0<goal>, None)
                        Number = 42; Stage = RoundOf16 42; KickOff = DateTime (2016, 06, 26, 20, 00, 00)
                        Events = [ (* winnerF *) (* runnerUpE *) ] }
                         
    let match43XVsY = { Team1Score = TeamMatchScore (winnerE, 0<goal>, None); Team2Score = TeamMatchScore (runnerUpD, 0<goal>, None)
                        Number = 43; Stage = RoundOf16 43; KickOff = DateTime (2016, 06, 27, 17, 00, 00)
                        Events = [ (* winnerE *) (* runnerUpD *) ] }

    let match44XVsY = { Team1Score = TeamMatchScore (runnerUpB, 0<goal>, None); Team2Score = TeamMatchScore (runnerUpF, 0<goal>, None)
                        Number = 44; Stage = RoundOf16 44; KickOff = DateTime (2016, 06, 27, 20, 00, 00)
                        Events = [ (* runnerUpB *) (* runnerUpF *) ] }

    let quarterFinal1XVsY = { Team1Score = TeamMatchScore (winnerMatch37, 0<goal>, None); Team2Score = TeamMatchScore (winnerMatch39, 0<goal>, None)
                              Number = 45; Stage = QuarterFinal 1; KickOff = DateTime (2016, 06, 30, 20, 00, 00)
                              Events = [ (* winnerMatch37 *) (* winnerMatch39 *) ] }

    let quarterFinal2XVsY = { Team1Score = TeamMatchScore (winnerMatch38, 0<goal>, None); Team2Score = TeamMatchScore (winnerMatch42, 0<goal>, None)
                              Number = 46; Stage = QuarterFinal 2; KickOff = DateTime (2016, 07, 01, 20, 00, 00)
                              Events = [ (* winnerMatch38 *) (* winnerMatch42 *) ] }

    let quarterFinal3XVsY = { Team1Score = TeamMatchScore (winnerMatch41, 0<goal>, None); Team2Score = TeamMatchScore (winnerMatch43, 0<goal>, None)
                              Number = 47; Stage = QuarterFinal 3; KickOff = DateTime (2016, 07, 02, 20, 00, 00)
                              Events = [ (* winnerMatch41 *) (* winnerMatch43 *) ] }

    let quarterFinal4XVsY = { Team1Score = TeamMatchScore (winnerMatch40, 0<goal>, None); Team2Score = TeamMatchScore (winnerMatch44, 0<goal>, None)
                              Number = 48; Stage = QuarterFinal 4; KickOff = DateTime (2016, 07, 03, 20, 00, 00)
                              Events = [ (* winnerMatch40 *) (* winnerMatch44 *) ] }

    let semiFinal1XVsY = { Team1Score = TeamMatchScore (winnerQF1, 0<goal>, None); Team2Score = TeamMatchScore (winnerQF2, 0<goal>, None)
                           Number = 49; Stage = SemiFinal 1; KickOff = DateTime (2016, 07, 06, 20, 00, 00)
                           Events = [ (* winnerQF1 *) (* winnerQF2 *) ] }

    let semiFinal2XVsY = { Team1Score = TeamMatchScore (winnerQF3, 0<goal>, None); Team2Score = TeamMatchScore (winnerQF4, 0<goal>, None)
                           Number = 50; Stage = SemiFinal 2; KickOff = DateTime (2016, 07, 07, 20, 00, 00)
                           Events = [ (* winnerQF3 *) (* winnerQF4 *) ] }

    let finalXVsY = { Team1Score = TeamMatchScore (winnerSF1, 0<goal>, None); Team2Score = TeamMatchScore (winnerSF2, 0<goal>, None)
                      Number = 50; Stage = Final; KickOff = DateTime (2016, 07, 10, 20, 00, 00)
                      Events = [ (* winnerSF1 *) (* winnerSF2 *) ] }

    let knockoutMatches = [ match37XVsY; match38XVsY; match39XVsY; match40XVsY; match41XVsY; match42XVsY; match43XVsY; match44XVsY
                            quarterFinal1XVsY; quarterFinal2XVsY; quarterFinal3XVsY; quarterFinal4XVsY
                            semiFinal1XVsY; semiFinal2XVsY
                            finalXVsY ]

    let matches = groupAMatches @ groupBMatches @ groupCMatches @ groupDMatches @ groupEMatches @ groupFMatches @ knockoutMatches

