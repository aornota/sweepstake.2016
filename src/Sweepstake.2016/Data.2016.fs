namespace AOrNotA.Sweepstake2016

open System

open AOrNotA.Sweepstake2016.Domain

module ``Data 2016`` =

    // 2016 squads &c.: https://en.wikipedia.org/wiki/UEFA_Euro_2016_squads.

    // Note: Seedings are based on "the UEFA National team coefficients updated after the completion of the qualifying group stage (excluding the play-offs)" (see https://en.wikipedia.org/wiki/UEFA_Euro_2016#Qualified_teams).

    // Group A.

    let france = { Name = "France"; Status = Active; Seeding = 7; Coach = "Didier Deschamps" }
    let switzerland = { Name = "Switzerland"; Status = Active; Seeding = 9; Coach = "Vladimir Petković" }
    let romania = { Name = "Romania"; Status = Eliminated; Seeding = 16; Coach = "Anghel Iordănescu" }
    let albania = { Name = "Albania"; Status = Active; Seeding = 23; Coach = "Gianni De Biasi" }

    // Group B.

    let england = { Name = "England"; Status = Active; Seeding = 3; Coach = "Roy Hodgson" }
    let russia = { Name = "Russia"; Status = Eliminated; Seeding = 8; Coach = "Leonid Slutsky" }
    let slovakia = { Name = "Slovakia"; Status = Active; Seeding = 17; Coach = "Ján Kozák" }
    let wales = { Name = "Wales"; Status = Active; Seeding = 22; Coach = "Chris Coleman" }

    // Group C.

    let germany = { Name = "Germany"; Status = Active; Seeding = 1; Coach = "Joachim Löw" }
    let ukraine = { Name = "Ukraine"; Status = Eliminated; Seeding = 12; Coach = "Mykhaylo Fomenko" }
    let poland = { Name = "Poland"; Status = Active; Seeding = 15; Coach = "Adam Nawałka" }
    let northernIreland = { Name = "Northern Ireland"; Status = Active; Seeding = 24; Coach = "Michael O'Neill" }

    // Group D.

    let spain = { Name = "Spain"; Status = Active; Seeding = 2; Coach = "Vicente del Bosque" }
    let croatia = { Name = "Croatia"; Status = Active; Seeding = 11; Coach = "Ante Čačić" }
    let czechRepublic = { Name = "Czech Republic"; Status = Eliminated; Seeding = 13; Coach = "Pavel Vrba" }
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
    let schneiderlinMorgan = { Name = "Morgan Schneiderlin"; Team = france; Type = Midfielder; Status = OriginalSquad }
    let pogbaPaul = { Name = "Paul Pogba"; Team = france; Type = Midfielder; Status = OriginalSquad }
    let payetDimitri = { Name = "Dimitri Payet"; Team = france; Type = Midfielder; Status = OriginalSquad }
    let kanteNGolo = { Name = "N'Golo Kanté"; Team = france; Type = Midfielder; Status = OriginalSquad }
    let giroudOlivier = { Name = "Olivier Giroud"; Team = france; Type = Forward; Status = OriginalSquad }
    let griezmannAntoine = { Name = "Antoine Griezmann"; Team = france; Type = Forward; Status = OriginalSquad }
    let gignacAndrePierre = { Name = "André-Pierre Gignac"; Team = france; Type = Forward; Status = OriginalSquad }
    let martialAnthony = { Name = "Anthony Martial"; Team = france; Type = Forward; Status = OriginalSquad }
    let comanKingsley = { Name = "Kingsley Coman"; Team = france; Type = Forward; Status = OriginalSquad }

    let private franceSquad = { Team = france
                                Players = [ llorisHugo; mandandaSteve; costilBenoit; evraPatrice; sagnaBacary; koscielnyLaurent; ramiAdil; digneLucas; jalletChristophe; mangalaEliaquim
                                            umtitiSamuel; cabayeYohan; matuidiBlaise; sissokoMoussa; schneiderlinMorgan; pogbaPaul; payetDimitri; kanteNGolo; giroudOlivier; griezmannAntoine
                                            gignacAndrePierre; martialAnthony; comanKingsley ] }

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

    let private switzerlandSquad = { Team = switzerland
                                     Players = [ sommerYann; hitzMarwin; burkiRoman; lichtsteinerStephan; moubandjeFrancois; elvediNico; vonBergenSteve; langMichael; rodriguezRicardo; djourouJohan
                                                 scharFabian; freiFabian; xhakaGranit; behramiValon; zakariaDenis; dzemailiBlerim; fernandesGelson; tarashajShani; shaqiriXherdan; emboloBreel
                                                 seferovicHaris; mehmediAdmir; derdiyokEren ] }

    let tatarusanuCiprian = { Name = "Ciprian Tătărușanu"; Team = romania; Type = Goalkeeper; Status = OriginalSquad }
    let pantilimonCostel = { Name = "Costel Pantilimon"; Team = romania; Type = Goalkeeper; Status = OriginalSquad }
    let lungJrSilviu = { Name = "Silviu Lung Jr."; Team = romania; Type = Goalkeeper; Status = OriginalSquad }
    let ratRazvan = { Name = "Răzvan Raț"; Team = romania; Type = Defender; Status = OriginalSquad }
    let chirichesVlad = { Name = "Vlad Chiricheș"; Team = romania; Type = Defender; Status = OriginalSquad }
    let grigoreDragos = { Name = "Dragoș Grigore"; Team = romania; Type = Defender; Status = OriginalSquad }
    let matelAlexandru = { Name = "Alexandru Mățel"; Team = romania; Type = Defender; Status = OriginalSquad }
    let gamanValerica = { Name = "Valerică Găman"; Team = romania; Type = Defender; Status = OriginalSquad }
    let sapunaruCristian = { Name = "Cristian Săpunaru"; Team = romania; Type = Defender; Status = OriginalSquad }
    let motiCosmin = { Name = "Cosmin Moți"; Team = romania; Type = Defender; Status = OriginalSquad }
    let filipSteliano = { Name = "Steliano Filip"; Team = romania; Type = Defender; Status = OriginalSquad }
    let torjeGabriel = { Name = "Gabriel Torje"; Team = romania; Type = Midfielder; Status = OriginalSquad }
    let pintiliiMihai = { Name = "Mihai Pintilii"; Team = romania; Type = Midfielder; Status = OriginalSquad }
    let chipciuAlexandru = { Name = "Alexandru Chipciu"; Team = romania; Type = Midfielder; Status = OriginalSquad }
    let hobanOvidiu = { Name = "Ovidiu Hoban"; Team = romania; Type = Midfielder; Status = OriginalSquad }
    let sanmarteanLucian = { Name = "Lucian Sânmărtean"; Team = romania; Type = Midfielder; Status = OriginalSquad }
    let popaAdrian = { Name = "Adrian Popa"; Team = romania; Type = Midfielder; Status = OriginalSquad }
    let prepelitaAndrei = { Name = "Andrei Prepeliță"; Team = romania; Type = Midfielder; Status = OriginalSquad }
    let stanciuNicolae = { Name = "Nicolae Stanciu"; Team = romania; Type = Midfielder; Status = OriginalSquad }
    let stancuBogdan = { Name = "Bogdan Stancu"; Team = romania; Type = Forward; Status = OriginalSquad }
    let keseruClaudiu = { Name = "Claudiu Keșerü"; Team = romania; Type = Forward; Status = OriginalSquad }
    let andoneFlorin = { Name = "Florin Andone"; Team = romania; Type = Forward; Status = OriginalSquad }
    let alibecDenis = { Name = "Denis Alibec"; Team = romania; Type = Forward; Status = OriginalSquad }

    let private romaniaSquad = { Team = romania
                                 Players = [ tatarusanuCiprian; pantilimonCostel; lungJrSilviu; ratRazvan; chirichesVlad; grigoreDragos; matelAlexandru; gamanValerica; sapunaruCristian; motiCosmin
                                             filipSteliano; torjeGabriel; pintiliiMihai; chipciuAlexandru; hobanOvidiu; sanmarteanLucian; popaAdrian; prepelitaAndrei; stanciuNicolae; stancuBogdan
                                             keseruClaudiu; andoneFlorin; alibecDenis ] }

    let berishaEtrit = { Name = "Etrit Berisha"; Team = albania; Type = Goalkeeper; Status = OriginalSquad }
    let shehiOrges = { Name = "Orges Shehi"; Team = albania; Type = Goalkeeper; Status = OriginalSquad }
    let hoxhaAlban = { Name = "Alban Hoxha"; Team = albania; Type = Goalkeeper; Status = OriginalSquad }
    let lilaAndi = { Name = "Andi Lila"; Team = albania; Type = Defender; Status = OriginalSquad }
    let hysajElseid = { Name = "Elseid Hysaj"; Team = albania; Type = Defender; Status = OriginalSquad }
    let canaLorik = { Name = "Lorik Cana"; Team = albania; Type = Defender; Status = OriginalSquad }
    let veseliFrederik = { Name = "Frederik Veseli"; Team = albania; Type = Defender; Status = OriginalSquad }
    let agolliAnsi = { Name = "Ansi Agolli"; Team = albania; Type = Defender; Status = OriginalSquad }
    let mavrajMergim = { Name = "Mërgim Mavraj"; Team = albania; Type = Defender; Status = OriginalSquad }
    let alijiNaser = { Name = "Naser Aliji"; Team = albania; Type = Defender; Status = OriginalSquad }
    let ajetiArlind = { Name = "Arlind Ajeti"; Team = albania; Type = Defender; Status = OriginalSquad }
    let lenjaniErmir = { Name = "Ermir Lenjani"; Team = albania; Type = Midfielder; Status = OriginalSquad }
    let bashaMigjen = { Name = "Migjen Basha"; Team = albania; Type = Midfielder; Status = OriginalSquad }
    let memushajLedian = { Name = "Ledian Memushaj"; Team = albania; Type = Midfielder; Status = OriginalSquad }
    let gashiShkelzen = { Name = "Shkëlzen Gashi"; Team = albania; Type = Midfielder; Status = OriginalSquad }
    let kukeliBurim = { Name = "Burim Kukeli"; Team = albania; Type = Midfielder; Status = OriginalSquad }
    let xhakaTaulant = { Name = "Taulant Xhaka"; Team = albania; Type = Midfielder; Status = OriginalSquad }
    let kaceErgys = { Name = "Ergys Kaçe"; Team = albania; Type = Midfielder; Status = OriginalSquad }
    let roshiOdise = { Name = "Odise Roshi"; Team = albania; Type = Midfielder; Status = OriginalSquad }
    let abrashiAmir = { Name = "Amir Abrashi"; Team = albania; Type = Midfielder; Status = OriginalSquad }
    let sadikuArmando = { Name = "Armando Sadiku"; Team = albania; Type = Forward; Status = OriginalSquad }
    let cikalleshiSokol = { Name = "Sokol Cikalleshi"; Team = albania; Type = Forward; Status = OriginalSquad }
    let balajBekim = { Name = "Bekim Balaj"; Team = albania; Type = Forward; Status = OriginalSquad }

    let private albaniaSquad = { Team = albania
                                 Players = [ berishaEtrit; shehiOrges; hoxhaAlban; lilaAndi; hysajElseid; canaLorik; veseliFrederik; agolliAnsi; mavrajMergim; alijiNaser; ajetiArlind; lenjaniErmir
                                             bashaMigjen; memushajLedian; gashiShkelzen; kukeliBurim; xhakaTaulant; kaceErgys; roshiOdise; abrashiAmir; sadikuArmando; cikalleshiSokol; balajBekim ] }

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

    let private englandSquad = { Team = england
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
    let yusupovArtur = { Name = "Artur Yusupov"; Team = russia; Type = Midfielder; Status = OriginalSquad }
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

    let private russiaSquad = { Team = russia
                                Players = [ akinfeevIgor; lodyginYuri; marinatoGuilherme; ignashevichSergei; berezutskiVasili; berezutskiAleksei; kombarovDmitri; smolnikovIgor; shishkinRoman
                                            shchennikovGeorgi; neustadterRoman; shirokovRoman; yusupovArtur; glushakovDenis; samedovAleksandr; torbinskiDmitri; shatovOleg; mamayevPavel
                                            golovinAleksandr; ivanovOleg; kokorinAleksandr; dzyubaArtyom; smolovFyodor ] }

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

    let private slovakiaSquad = { Team = slovakia
                                  Players = [ muchaJan; kozacikMatus; novotnaJan; skrtelMartin; duricaJan; pekarikPeter; hubocanTomas; salataKornel; sventoDusan; gyomberNorbert; skriniarMilan
                                              hamsikMarek; sestakStanislav; stochMiroslav; weissVladimir; kuckaJuraj; pecovskyViktor; makRobert; dudaOndrej; hrosovskyPatrik; gregusJan; durisMichal
                                              nemecAdam ] }

    let hennesseyWayne = { Name = "Wayne Hennessey"; Team = wales; Type = Goalkeeper; Status = OriginalSquad }
    let williamsOwainFon = { Name = "Owain Fôn Williams"; Team = wales; Type = Goalkeeper; Status = OriginalSquad }
    let wardDanny = { Name = "Danny Ward"; Team = wales; Type = Goalkeeper; Status = OriginalSquad }
    let gunterChris = { Name = "Chris Gunter"; Team = wales; Type = Defender; Status = OriginalSquad }
    let williamsAshley = { Name = "Ashley Williams"; Team = wales; Type = Defender; Status = OriginalSquad }
    let collinsJames = { Name = "James Collins"; Team = wales; Type = Defender; Status = OriginalSquad }
    let taylorNeil = { Name = "Neil Taylor"; Team = wales; Type = Defender; Status = OriginalSquad }
    let daviesBen = { Name = "Ben Davies"; Team = wales; Type = Defender; Status = OriginalSquad }
    let chesterJames = { Name = "James Chester"; Team = wales; Type = Defender; Status = OriginalSquad }
    let richardsJazz = { Name = "Jazz Richards"; Team = wales; Type = Defender; Status = OriginalSquad }
    let ledleyJoe = { Name = "Joe Ledley"; Team = wales; Type = Midfielder; Status = OriginalSquad }
    let vaughanDavid = { Name = "David Vaughan"; Team = wales; Type = Midfielder; Status = OriginalSquad }
    let ramseyAaron = { Name = "Aaron Ramsey"; Team = wales; Type = Midfielder; Status = OriginalSquad }
    let kingAndy = { Name = "Andy King"; Team = wales; Type = Midfielder; Status = OriginalSquad }
    let edwardsDavid = { Name = "David Edwards"; Team = wales; Type = Midfielder; Status = OriginalSquad }
    let allenJoe = { Name = "Joe Allen"; Team = wales; Type = Midfielder; Status = OriginalSquad }
    let cotterillDavid = { Name = "David Cotterill"; Team = wales; Type = Midfielder; Status = OriginalSquad }
    let williamsJonathan = { Name = "Jonathan Williams"; Team = wales; Type = Midfielder; Status = OriginalSquad }
    let baleGareth = { Name = "Gareth Bale"; Team = wales; Type = Forward; Status = OriginalSquad }
    let vokesSam = { Name = "Sam Vokes"; Team = wales; Type = Forward; Status = OriginalSquad }
    let churchSimon = { Name = "Simon Church"; Team = wales; Type = Forward; Status = OriginalSquad }
    let robsonKanuHal = { Name = "Hal Robson-Kanu"; Team = wales; Type = Forward; Status = OriginalSquad }
    let williamsGeorge = { Name = "George Williams"; Team = wales; Type = Forward; Status = OriginalSquad }

    let private walesSquad = { Team = wales
                               Players = [ hennesseyWayne; williamsOwainFon; wardDanny; gunterChris; williamsAshley; collinsJames; taylorNeil; daviesBen; chesterJames; richardsJazz; ledleyJoe
                                           vaughanDavid; ramseyAaron; kingAndy; edwardsDavid; allenJoe; cotterillDavid; williamsJonathan; baleGareth; vokesSam; churchSimon; robsonKanuHal
                                           williamsGeorge ] }

    // Group C.

    let neuerManuel = { Name = "Manuel Neuer"; Team = germany; Type = Goalkeeper; Status = OriginalSquad }
    let terStegenMarcAndre = { Name = "Marc-André ter Stegen"; Team = germany; Type = Goalkeeper; Status = OriginalSquad }
    let lenoBernd = { Name = "Bernd Leno"; Team = germany; Type = Goalkeeper; Status = OriginalSquad }
    let boatengJerome = { Name = "Jérôme Boateng"; Team = germany; Type = Defender; Status = OriginalSquad }
    let hummelsMatt = { Name = "Mats Hummels"; Team = germany; Type = Defender; Status = OriginalSquad }
    let howedesBenedikt = { Name = "Benedikt Höwedes"; Team = germany; Type = Defender; Status = OriginalSquad }
    let hectorJonas = { Name = "Jonas Hector"; Team = germany; Type = Defender; Status = OriginalSquad }
    let mustafiShkodran = { Name = "Shkodran Mustafi"; Team = germany; Type = Defender; Status = OriginalSquad }
    let tahJonathan = { Name = "Jonathan Tah"; Team = germany; Type = Defender; Status = OriginalSquad }
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

    let private germanySquad = { Team = germany
                                 Players = [ neuerManuel; terStegenMarcAndre; lenoBernd; boatengJerome; hummelsMatt; howedesBenedikt; hectorJonas; mustafiShkodran; tahJonathan; canEmre
                                             schweinsteigerBastian; ozilMesut; kroosToni; khediraSami; gotzeMario; schurrleAndre; draxlerJulian; saneLeroy; weiglJulian; kimmichJoshua; podolskiLukas
                                             mullerThomas; gomezMario ] }

    let pyatovAndriy = { Name = "Andriy Pyatov"; Team = ukraine; Type = Goalkeeper; Status = OriginalSquad }
    let boykoDenys = { Name = "Denys Boyko"; Team = ukraine; Type = Goalkeeper; Status = OriginalSquad }
    let shevchenkoMykyta = { Name = "Mykyta Shevchenko"; Team = ukraine; Type = Goalkeeper; Status = OriginalSquad }
    let shevchukVyacheslav = { Name = "Vyacheslav Shevchuk"; Team = ukraine; Type = Defender; Status = OriginalSquad }
    let kucherOleksandr = { Name = "Oleksandr Kucher"; Team = ukraine; Type = Defender; Status = OriginalSquad }
    let fedetskyiArtem = { Name = "Artem Fedetskyi"; Team = ukraine; Type = Defender; Status = OriginalSquad }
    let khacheridiYevhen = { Name = "Yevhen Khacheridi"; Team = ukraine; Type = Defender; Status = OriginalSquad }
    let rakitskiyYaroslav = { Name = "Yaroslav Rakitskiy"; Team = ukraine; Type = Defender; Status = OriginalSquad }
    let butkoBohdan = { Name = "Bohdan Butko"; Team = ukraine; Type = Defender; Status = OriginalSquad }
    let tymoshchukAnatoliy = { Name = "Anatoliy Tymoshchuk "; Team = ukraine; Type = Midfielder; Status = OriginalSquad }
    let rotanRuslan = { Name = "Ruslan Rotan"; Team = ukraine; Type = Midfielder; Status = OriginalSquad }
    let yarmolenkoAndriy = { Name = "Andriy Yarmolenko"; Team = ukraine; Type = Midfielder; Status = OriginalSquad }
    let konoplyankaYevhen = { Name = "Yevhen Konoplyanka"; Team = ukraine; Type = Midfielder; Status = OriginalSquad }
    let stepanenkoTaras = { Name = "Taras Stepanenko"; Team = ukraine; Type = Midfielder; Status = OriginalSquad }
    let harmashDenys = { Name = "Denys Harmash"; Team = ukraine; Type = Midfielder; Status = OriginalSquad }
    let sydorchukSerhiy = { Name = "Serhiy Sydorchuk"; Team = ukraine; Type = Midfielder; Status = OriginalSquad }
    let rybalkaSerhiy = { Name = "Serhiy Rybalka"; Team = ukraine; Type = Midfielder; Status = OriginalSquad }
    let zinchenkoOleksandr = { Name = "Oleksandr Zinchenko"; Team = ukraine; Type = Midfielder; Status = OriginalSquad }
    let karavayevOleksandr = { Name = "Oleksandr Karavayev"; Team = ukraine; Type = Midfielder; Status = OriginalSquad }
    let kovalenkoViktor = { Name = "Viktor Kovalenko"; Team = ukraine; Type = Midfielder; Status = OriginalSquad }
    let seleznyovYevhen = { Name = "Yevhen Seleznyov"; Team = ukraine; Type = Forward; Status = OriginalSquad }
    let zozulyaRoman = { Name = "Roman Zozulya"; Team = ukraine; Type = Forward; Status = OriginalSquad }
    let budkivskyiPylyp = { Name = "Pylyp Budkivskyi"; Team = ukraine; Type = Forward; Status = OriginalSquad }

    let private ukraineSquad = { Team = ukraine
                                 Players = [ pyatovAndriy; boykoDenys; shevchenkoMykyta; shevchukVyacheslav; kucherOleksandr; fedetskyiArtem; khacheridiYevhen; rakitskiyYaroslav; butkoBohdan
                                             tymoshchukAnatoliy; rotanRuslan; yarmolenkoAndriy; konoplyankaYevhen; stepanenkoTaras; harmashDenys; sydorchukSerhiy; rybalkaSerhiy; zinchenkoOleksandr
                                             karavayevOleksandr; kovalenkoViktor; seleznyovYevhen; zozulyaRoman; budkivskyiPylyp ] }

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

    let private polandSquad = { Team = poland
                                Players = [ szczesnyWojciech; borucArtur; fabianskiLukasz; pazdanMichal; jedrzejczykArtur; cionekThiago; wawrzyniakJakub; glikKamil; salamonBartosz; piszczekLukasz
                                            maczynskiKrzysztof; jodlowiecTomasz; linettyKarol; krychowiakGrzegorz; grosickiKamil; blaszczykowskiJakub; peszkoSlawomir; zielinskiPiotr
                                            kapustkaBartosz; starzynskiFilip; milikArkadiusz; lewandowskiRobert; stepinskiMariusz ] }

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

    let private northernIrelandSquad = { Team = northernIreland
                                         Players = [ carrollRoy; mcGovernMichael; mannusAlan; hughesAaron; bairdChris; mcAuleyGareth; evansJonny; cathcartCraig; mcLaughlinConor; hodsonLee
                                                     mcNairPaddy; mcCulloughLuke; davisSteven; mcGinnNiall; evansCorry; norwoodOliver; fergusonShane; dallasStuart; laffertyKyle; wardJamie
                                                     magennisJosh; griggWill; washingtonConor ] }

    // Group D.

    let casillasIker = { Name = "Iker Casillas"; Team = spain; Type = Goalkeeper; Status = OriginalSquad }
    let deGeaDavid = { Name = "David de Gea"; Team = spain; Type = Goalkeeper; Status = OriginalSquad }
    let ricoSergio = { Name = "Sergio Rico"; Team = spain; Type = Goalkeeper; Status = OriginalSquad }
    let ramosSergio = { Name = "Sergio Ramos"; Team = spain; Type = Defender; Status = OriginalSquad }
    let piqueGerard = { Name = "Gerard Piqué"; Team = spain; Type = Defender; Status = OriginalSquad }
    let albaJordi = { Name = "Jordi Alba"; Team = spain; Type = Defender; Status = OriginalSquad }
    let juanfran = { Name = "Juanfran"; Team = spain; Type = Defender; Status = OriginalSquad }
    let azpilicuetaCesar = { Name = "César Azpilicueta"; Team = spain; Type = Defender; Status = OriginalSquad }
    let bartraMarc = { Name = "Marc Bartra"; Team = spain; Type = Defender; Status = OriginalSquad }
    let sanJoseMikel = { Name = "Mikel San José"; Team = spain; Type = Defender; Status = OriginalSquad }
    let bellerinHector = { Name = "Héctor Bellerín"; Team = spain; Type = Defender; Status = OriginalSquad }
    let iniestaAndres = { Name = "Andrés Iniesta"; Team = spain; Type = Midfielder; Status = OriginalSquad }
    let fabregasCesc = { Name = "Cesc Fàbregas"; Team = spain; Type = Midfielder; Status = OriginalSquad }
    let silvaDavid = { Name = "David Silva"; Team = spain; Type = Midfielder; Status = OriginalSquad }
    let busquetsSergio = { Name = "Sergio Busquets"; Team = spain; Type = Midfielder; Status = OriginalSquad }
    let koke = { Name = "Koke"; Team = spain; Type = Midfielder; Status = OriginalSquad }
    let thiago = { Name = "Thiago"; Team = spain; Type = Midfielder; Status = OriginalSquad }
    let sorianoBruno = { Name = "Bruno Soriano"; Team = spain; Type = Midfielder; Status = OriginalSquad }
    let vazquezLucas = { Name = "Lucas Vázquez"; Team = spain; Type = Midfielder; Status = OriginalSquad }
    let pedro = { Name = "Pedro"; Team = spain; Type = Forward; Status = OriginalSquad }
    let morataAlvaro = { Name = "Álvaro Morata"; Team = spain; Type = Forward; Status = OriginalSquad }
    let nolito = { Name = "Nolito"; Team = spain; Type = Forward; Status = OriginalSquad }
    let adurizAritz = { Name = "Aritz Aduriz"; Team = spain; Type = Forward; Status = OriginalSquad }

    let private spainSquad = { Team = spain
                               Players = [ casillasIker; deGeaDavid; ricoSergio; ramosSergio; piqueGerard; albaJordi; juanfran; azpilicuetaCesar; bartraMarc; sanJoseMikel; bellerinHector
                                           iniestaAndres; fabregasCesc; silvaDavid; busquetsSergio; koke; thiago; sorianoBruno; vazquezLucas; pedro; morataAlvaro; nolito; adurizAritz ] }

    let subasicDanijel = { Name = "Danijel Subašić"; Team = croatia; Type = Goalkeeper; Status = OriginalSquad }
    let kalinicLovre = { Name = "Lovre Kalinić"; Team = croatia; Type = Goalkeeper; Status = OriginalSquad }
    let vargicIvan = { Name = "Ivan Vargić"; Team = croatia; Type = Goalkeeper; Status = OriginalSquad }
    let srnaDarijo = { Name = "Darijo Srna"; Team = croatia; Type = Defender; Status = OriginalSquad }
    let corlukaVedran = { Name = "Vedran Ćorluka"; Team = croatia; Type = Defender; Status = OriginalSquad }
    let vidaDomagoj = { Name = "Domagoj Vida"; Team = croatia; Type = Defender; Status = OriginalSquad }
    let strinicIvan = { Name = "Ivan Strinić"; Team = croatia; Type = Defender; Status = OriginalSquad }
    let schildenfeldGordon = { Name = "Gordon Schildenfeld"; Team = croatia; Type = Defender; Status = OriginalSquad }
    let vrsaljkoSime = { Name = "Šime Vrsaljko"; Team = croatia; Type = Defender; Status = OriginalSquad }
    let jedvajTin = { Name = "Tin Jedvaj"; Team = croatia; Type = Defender; Status = OriginalSquad }
    let modricLuka = { Name = "Luka Modrić"; Team = croatia; Type = Midfielder; Status = OriginalSquad }
    let rakiticIvan = { Name = "Ivan Rakitić"; Team = croatia; Type = Midfielder; Status = OriginalSquad }
    let perisicIvan = { Name = "Ivan Perišić"; Team = croatia; Type = Midfielder; Status = OriginalSquad }
    let kovacicMateo = { Name = "Mateo Kovačić"; Team = croatia; Type = Midfielder; Status = OriginalSquad }
    let badeljMilan = { Name = "Milan Badelj"; Team = croatia; Type = Midfielder; Status = OriginalSquad }
    let brozovicMarcelo = { Name = "Marcelo Brozović"; Team = croatia; Type = Midfielder; Status = OriginalSquad }
    let rogMarko = { Name = "Marko Rog"; Team = croatia; Type = Midfielder; Status = OriginalSquad }
    let coricAnte = { Name = "Ante Ćorić"; Team = croatia; Type = Midfielder; Status = OriginalSquad }
    let mandzukicMario = { Name = "Mario Mandžukić"; Team = croatia; Type = Forward; Status = OriginalSquad }
    let kalinicNikola = { Name = "Nikola Kalinić"; Team = croatia; Type = Forward; Status = OriginalSquad }
    let kramaricAndrej = { Name = "Andrej Kramarić"; Team = croatia; Type = Forward; Status = OriginalSquad }
    let pjacaMarko = { Name = "Marko Pjaca"; Team = croatia; Type = Forward; Status = OriginalSquad }
    let copDuje = { Name = "Duje Čop"; Team = croatia; Type = Forward; Status = OriginalSquad }

    let private croatiaSquad = { Team = croatia
                                 Players = [ subasicDanijel; kalinicLovre; vargicIvan; srnaDarijo; corlukaVedran; vidaDomagoj; strinicIvan; schildenfeldGordon; vrsaljkoSime; jedvajTin; modricLuka
                                             rakiticIvan; perisicIvan; kovacicMateo; badeljMilan; brozovicMarcelo; rogMarko; coricAnte; mandzukicMario; kalinicNikola; kramaricAndrej; pjacaMarko
                                             copDuje ] }

    let cechPetr = { Name = "Petr Čech"; Team = czechRepublic; Type = Goalkeeper; Status = OriginalSquad }
    let vaclikTomas = { Name = "Tomáš Vaclík"; Team = czechRepublic; Type = Goalkeeper; Status = OriginalSquad }
    let koubekTomas = { Name = "Tomáš Koubek"; Team = czechRepublic; Type = Goalkeeper; Status = OriginalSquad }
    let kadlecMichal = { Name = "Michal Kadlec"; Team = czechRepublic; Type = Defender; Status = OriginalSquad }
    let sivokTomas = { Name = "Tomáš Sivok"; Team = czechRepublic; Type = Defender; Status = OriginalSquad }
    let limberskyDavid = { Name = "David Limberský"; Team = czechRepublic; Type = Defender; Status = OriginalSquad }
    let selassieTheodorGebre = { Name = "Theodor Gebre Selassie"; Team = czechRepublic; Type = Defender; Status = OriginalSquad }
    let pudilDaniel = { Name = "Daniel Pudil"; Team = czechRepublic; Type = Defender; Status = OriginalSquad }
    let suchyMarek = { Name = "Marek Suchý"; Team = czechRepublic; Type = Defender; Status = OriginalSquad }
    let hubnikRoman = { Name = "Roman Hubník"; Team = czechRepublic; Type = Defender; Status = OriginalSquad }
    let kaderabekPavel = { Name = "Pavel Kadeřábek"; Team = czechRepublic; Type = Defender; Status = OriginalSquad }
    let rosickyTomas = { Name = "Tomáš Rosický"; Team = czechRepublic; Type = Midfielder; Status = OriginalSquad }
    let plasilJaroslav = { Name = "Jaroslav Plašil"; Team = czechRepublic; Type = Midfielder; Status = OriginalSquad }
    let daridaVladimir = { Name = "Vladimír Darida"; Team = czechRepublic; Type = Midfielder; Status = OriginalSquad }
    let kolarDaniel = { Name = "Daniel Kolář"; Team = czechRepublic; Type = Midfielder; Status = OriginalSquad }
    let dockalBorek = { Name = "Bořek Dočkal"; Team = czechRepublic; Type = Midfielder; Status = OriginalSquad }
    let krejciLadislav = { Name = "Ladislav Krejčí"; Team = czechRepublic; Type = Midfielder; Status = OriginalSquad }
    let suralJosef = { Name = "Josef Šural"; Team = czechRepublic; Type = Midfielder; Status = OriginalSquad }
    let skalakJiri = { Name = "Jiří Skalák"; Team = czechRepublic; Type = Midfielder; Status = OriginalSquad }
    let pavelkaDavid = { Name = "David Pavelka"; Team = czechRepublic; Type = Midfielder; Status = OriginalSquad }
    let lafataDavid = { Name = "David Lafata"; Team = czechRepublic; Type = Forward; Status = OriginalSquad }
    let necidTomas = { Name = "Tomáš Necid"; Team = czechRepublic; Type = Forward; Status = OriginalSquad }
    let skodaMilan = { Name = "Milan Škoda"; Team = czechRepublic; Type = Forward; Status = OriginalSquad }

    let private czechRepublicSquad = { Team = czechRepublic
                                       Players = [ cechPetr; vaclikTomas; koubekTomas; kadlecMichal; sivokTomas; limberskyDavid; selassieTheodorGebre; pudilDaniel; suchyMarek; hubnikRoman
                                                   kaderabekPavel; rosickyTomas; plasilJaroslav; daridaVladimir; kolarDaniel; dockalBorek; krejciLadislav; suralJosef; skalakJiri; pavelkaDavid
                                                   lafataDavid; necidTomas; skodaMilan ] }

    let babacanVolkan = { Name = "Volkan Babacan"; Team = turkey; Type = Goalkeeper; Status = OriginalSquad }
    let kivrakOnurRecep = { Name = "Onur Recep Kıvrak"; Team = turkey; Type = Goalkeeper; Status = OriginalSquad }
    let tekinHarun = { Name = "Harun Tekin"; Team = turkey; Type = Goalkeeper; Status = OriginalSquad }
    let topalMehmet = { Name = "Mehmet Topal"; Team = turkey; Type = Defender; Status = OriginalSquad }
    let gonulGokhan = { Name = "Gökhan Gönül"; Team = turkey; Type = Defender; Status = OriginalSquad }
    let erkinCaner = { Name = "Caner Erkin"; Team = turkey; Type = Defender; Status = OriginalSquad }
    let baltaHakanKadir = { Name = "Hakan Kadir Balta"; Team = turkey; Type = Defender; Status = OriginalSquad }
    let kayaSemih = { Name = "Semih Kaya"; Team = turkey; Type = Defender; Status = OriginalSquad }
    let koybasiIsmail = { Name = "İsmail Köybaşı"; Team = turkey; Type = Defender; Status = OriginalSquad }
    let ozbayrakliSener = { Name = "Şener Özbayraklı"; Team = turkey; Type = Defender; Status = OriginalSquad }
    let calikAhmetYilmaz = { Name = "Ahmet Yılmaz Çalık"; Team = turkey; Type = Defender; Status = OriginalSquad }
    let turanArda = { Name = "Arda Turan "; Team = turkey; Type = Midfielder; Status = OriginalSquad }
    let inanSelcuk = { Name = "Selçuk İnan"; Team = turkey; Type = Midfielder; Status = OriginalSquad }
    let sahinNuri = { Name = "Nuri Şahin"; Team = turkey; Type = Midfielder; Status = OriginalSquad }
    let sahanOlcay = { Name = "Olcay Şahan"; Team = turkey; Type = Midfielder; Status = OriginalSquad }
    let tufanOzan = { Name = "Ozan Tufan"; Team = turkey; Type = Midfielder; Status = OriginalSquad }
    let calhanogluHakan = { Name = "Hakan Çalhanoğlu"; Team = turkey; Type = Midfielder; Status = OriginalSquad }
    let ozyakupOguzhan = { Name = "Oğuzhan Özyakup"; Team = turkey; Type = Midfielder; Status = OriginalSquad }
    let senVolkan = { Name = "Volkan Şen"; Team = turkey; Type = Midfielder; Status = OriginalSquad }
    let morEmre = { Name = "Emre Mor"; Team = turkey; Type = Midfielder; Status = OriginalSquad }
    let yilmazBurak = { Name = "Burak Yılmaz"; Team = turkey; Type = Forward; Status = OriginalSquad }
    let tosunCenk = { Name = "Cenk Tosun"; Team = turkey; Type = Forward; Status = OriginalSquad }
    let malliYunus = { Name = "Yunus Mallı"; Team = turkey; Type = Forward; Status = OriginalSquad }

    let private turkeySquad = { Team = turkey
                                Players = [ babacanVolkan; kivrakOnurRecep; tekinHarun; topalMehmet; gonulGokhan; erkinCaner; baltaHakanKadir; kayaSemih; koybasiIsmail; ozbayrakliSener
                                            calikAhmetYilmaz; turanArda; inanSelcuk; sahinNuri; sahanOlcay; tufanOzan; calhanogluHakan; ozyakupOguzhan; senVolkan; morEmre; yilmazBurak; tosunCenk
                                            malliYunus ] }

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

    let private belgiumSquad = { Team = belgium
                                 Players = [ courtoisThibaut; mignoletSimon; gilletJeanFrancois; vertonghenJan; alderweireldToby; vermaelenThomas; cimanLaurent; denayerJason; meunierThomas
                                             lukakuJordan; kabaseleChristian; fellainiMarouane; witselAxel; dembeleMousa; nainggolanRadja; hazardEden; mertensDries; lukakuRomelu; deBruyneKevin
                                             bentekeChristian; origiDivock; carrascoYannickFerreira; batshuayiMichy ] }

    let buffonGianluigi = { Name = "Gianluigi Buffon"; Team = italy; Type = Goalkeeper; Status = OriginalSquad }
    let siriguSalvatore = { Name = "Salvatore Sirigu"; Team = italy; Type = Goalkeeper; Status = OriginalSquad }
    let marchettiFederico = { Name = "Federico Marchetti"; Team = italy; Type = Goalkeeper; Status = OriginalSquad }
    let deSciglioMattia = { Name = "Mattia De Sciglio"; Team = italy; Type = Defender; Status = OriginalSquad }
    let chielliniGiorgio = { Name = "Giorgio Chiellini"; Team = italy; Type = Defender; Status = OriginalSquad }
    let darmianMatteo = { Name = "Matteo Darmian"; Team = italy; Type = Defender; Status = OriginalSquad }
    let ogbonnaAngelo = { Name = "Angelo Ogbonna"; Team = italy; Type = Defender; Status = OriginalSquad }
    let barzagliAndrea = { Name = "Andrea Barzagli"; Team = italy; Type = Defender; Status = OriginalSquad }
    let bonucciLeonardo = { Name = "Leonardo Bonucci"; Team = italy; Type = Defender; Status = OriginalSquad }
    let candrevaAntonio = { Name = "Antonio Candreva"; Team = italy; Type = Midfielder; Status = OriginalSquad }
    let florenziAlessandro = { Name = "Alessandro Florenzi"; Team = italy; Type = Midfielder; Status = OriginalSquad }
    let mottaThiago = { Name = "Thiago Motta"; Team = italy; Type = Midfielder; Status = OriginalSquad }
    let sturaroStefano = { Name = "Stefano Sturaro"; Team = italy; Type = Midfielder; Status = OriginalSquad }
    let deRossiDaniele = { Name = "Daniele De Rossi"; Team = italy; Type = Midfielder; Status = OriginalSquad }
    let paroloMarco = { Name = "Marco Parolo"; Team = italy; Type = Midfielder; Status = OriginalSquad }
    let bernardeschiFederico = { Name = "Federico Bernardeschi"; Team = italy; Type = Midfielder; Status = OriginalSquad }
    let giaccheriniEmanuele = { Name = "Emanuele Giaccherini"; Team = italy; Type = Midfielder; Status = OriginalSquad }
    let zazaSimone = { Name = "Simone Zaza"; Team = italy; Type = Forward; Status = OriginalSquad }
    let pelleGraciano = { Name = "Graziano Pellè"; Team = italy; Type = Forward; Status = OriginalSquad }
    let immobileCiro = { Name = "Ciro Immobile"; Team = italy; Type = Forward; Status = OriginalSquad }
    let eder_Italy = { Name = "Éder"; Team = italy; Type = Forward; Status = OriginalSquad }
    let insigneLorenzo = { Name = "Lorenzo Insigne"; Team = italy; Type = Forward; Status = OriginalSquad }
    let elShaarawyStephan = { Name = "Stephan El Shaarawy"; Team = italy; Type = Forward; Status = OriginalSquad }

    let private italySquad = { Team = italy
                               Players = [ buffonGianluigi; siriguSalvatore; marchettiFederico; deSciglioMattia; chielliniGiorgio; darmianMatteo; ogbonnaAngelo; barzagliAndrea; bonucciLeonardo
                                           candrevaAntonio; florenziAlessandro; mottaThiago; sturaroStefano; deRossiDaniele; paroloMarco; bernardeschiFederico; giaccheriniEmanuele; zazaSimone
                                           pelleGraciano; immobileCiro; eder_Italy; insigneLorenzo; elShaarawyStephan ] }

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

    let private swedenSquad = { Team = sweden
                                Players = [ isakssonAndreas; olsenRobin; carlgrenPatrik; granqvistAndreas; lustigMikael; olssonMartin; johanssonErik; janssonPontus; augustinssonLudwig
                                            lindelofVictor; kallstromKim; larssonSebastian; wernbloomPontus; durmazJimmy; ekdalAlbin; zenginErkan; forsbergEmil; hiljemarkOscar; lewickiOscar
                                            ibrahimovicZlatan; bergMarcus; guidettiJohn; kujovicEmir ] }

    let westwoodKieren = { Name = "Keiren Westwood"; Team = republicOfIreland; Type = Goalkeeper; Status = OriginalSquad }
    let givenShay = { Name = "Shay Given"; Team = republicOfIreland; Type = Goalkeeper; Status = OriginalSquad }
    let randolphDarren = { Name = "Darren Randolph"; Team = republicOfIreland; Type = Goalkeeper; Status = OriginalSquad }
    let colemanSeamus = { Name = "Séamus Coleman"; Team = republicOfIreland; Type = Defender; Status = OriginalSquad }
    let clarkCiaran = { Name = "Ciaran Clark"; Team = republicOfIreland; Type = Defender; Status = OriginalSquad }
    let oSheaJohn = { Name = "John O'Shea"; Team = republicOfIreland; Type = Defender; Status = OriginalSquad }
    let keoghRichard = { Name = "Richard Keogh"; Team = republicOfIreland; Type = Defender; Status = OriginalSquad }
    let duffyShane = { Name = "Shane Duffy"; Team = republicOfIreland; Type = Defender; Status = OriginalSquad }
    let christieCyrus = { Name = "Cyrus Christie"; Team = republicOfIreland; Type = Defender; Status = OriginalSquad }
    let wardStephen = { Name = "Stephen Ward"; Team = republicOfIreland; Type = Defender; Status = OriginalSquad }
    let whelanGlenn = { Name = "Glenn Whelan"; Team = republicOfIreland; Type = Midfielder; Status = OriginalSquad }
    let mcGeadyAiden = { Name = "Aiden McGeady"; Team = republicOfIreland; Type = Midfielder; Status = OriginalSquad }
    let mcCarthyJames = { Name = "James McCarthy"; Team = republicOfIreland; Type = Midfielder; Status = OriginalSquad }
    let mcCleanJames = { Name = "James McClean"; Team = republicOfIreland; Type = Midfielder; Status = OriginalSquad }
    let hendrickJeff = { Name = "Jeff Hendrick"; Team = republicOfIreland; Type = Midfielder; Status = OriginalSquad }
    let meylerDavid = { Name = "David Meyler"; Team = republicOfIreland; Type = Midfielder; Status = OriginalSquad }
    let bradyRobbie = { Name = "Robbie Brady"; Team = republicOfIreland; Type = Midfielder; Status = OriginalSquad }
    let hoolahanWes = { Name = "Wes Hoolahan"; Team = republicOfIreland; Type = Midfielder; Status = OriginalSquad }
    let quinnStephen = { Name = "Stephen Quinn"; Team = republicOfIreland; Type = Midfielder; Status = OriginalSquad }
    let longShane = { Name = "Shane Long"; Team = republicOfIreland; Type = Forward; Status = OriginalSquad }
    let keaneRobbie = { Name = "Robbie Keane"; Team = republicOfIreland; Type = Forward; Status = OriginalSquad }
    let waltersJonathan = { Name = "Jonathan Walters"; Team = republicOfIreland; Type = Forward; Status = OriginalSquad }
    let murphyDaryl = { Name = "Daryl Murphy"; Team = republicOfIreland; Type = Forward; Status = OriginalSquad }

    let private republicOfIrelandSquad = { Team = republicOfIreland
                                           Players = [ westwoodKieren; givenShay; randolphDarren; colemanSeamus; clarkCiaran; oSheaJohn; keoghRichard; duffyShane; christieCyrus; wardStephen
                                                       whelanGlenn; mcGeadyAiden; mcCarthyJames; mcCleanJames; hendrickJeff; meylerDavid; bradyRobbie; hoolahanWes; quinnStephen; longShane
                                                       keaneRobbie; waltersJonathan; murphyDaryl ] }

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
    let eder_Portugal = { Name = "Éder"; Team = portugal; Type = Forward; Status = OriginalSquad }
    let silvaRafa = { Name = "Rafa Silva"; Team = portugal; Type = Forward; Status = OriginalSquad }

    let private portugalSquad = { Team = portugal
                                  Players = [ patricioRui; eduardo; lopesAnthony; alvesBruno; carvalhoRicardo; pepe; vieirinha; eliseu; fonteJose; cedric; guerreiroRaphael; moutinhoJoao
                                              carvalhoWilliam; pereiraDanilo; marioJoao; silvaAdrien; gomesAndre; sanchesRenato; ronaldoCristiano; nani; quaresmaRicardo; eder_Portugal; silvaRafa ] }

    let almerRobert = { Name = "Robert Almer"; Team = austria; Type = Goalkeeper; Status = OriginalSquad }
    let lindnerHeinz = { Name = "Heinz Lindner"; Team = austria; Type = Goalkeeper; Status = OriginalSquad }
    let ozcanRamazan = { Name = "Ramazan Özcan"; Team = austria; Type = Goalkeeper; Status = OriginalSquad }
    let fuchsChristian = { Name = "Christian Fuchs"; Team = austria; Type = Defender; Status = OriginalSquad }
    let prodlSebastian = { Name = "Sebastian Prödl"; Team = austria; Type = Defender; Status = OriginalSquad }
    let dragovicAleksandar = { Name = "Aleksandar Dragović"; Team = austria; Type = Defender; Status = OriginalSquad }
    let garicsGyorgy = { Name = "György Garics"; Team = austria; Type = Defender; Status = OriginalSquad }
    let kleinFlorian = { Name = "Florian Klein"; Team = austria; Type = Defender; Status = OriginalSquad }
    let suttnerMarkus = { Name = "Markus Suttner"; Team = austria; Type = Defender; Status = OriginalSquad }
    let hintereggerMartin = { Name = "Martin Hinteregger"; Team = austria; Type = Defender; Status = OriginalSquad }
    let wimmerKevin = { Name = "Kevin Wimmer"; Team = austria; Type = Defender; Status = OriginalSquad }
    let harnikMartin = { Name = "Martin Harnik"; Team = austria; Type = Midfielder; Status = OriginalSquad }
    let arnautovicMarko = { Name = "Marko Arnautović"; Team = austria; Type = Midfielder; Status = OriginalSquad }
    let junuzovicZlatko = { Name = "Zlatko Junuzović"; Team = austria; Type = Midfielder; Status = OriginalSquad }
    let alabaDavid = { Name = "David Alaba"; Team = austria; Type = Midfielder; Status = OriginalSquad }
    let baumgartlingerJulian = { Name = "Julian Baumgartlinger"; Team = austria; Type = Midfielder; Status = OriginalSquad }
    let jantscherJakob = { Name = "Jakob Jantscher"; Team = austria; Type = Midfielder; Status = OriginalSquad }
    let sabitzerMarcel = { Name = "Marcel Sabitzer"; Team = austria; Type = Midfielder; Status = OriginalSquad }
    let ilsankerStefan = { Name = "Stefan Ilsanker"; Team = austria; Type = Midfielder; Status = OriginalSquad }
    let schopfAlessandro = { Name = "Alessandro Schöpf"; Team = austria; Type = Midfielder; Status = OriginalSquad }
    let jankoMarc = { Name = "Marc Janko"; Team = austria; Type = Forward; Status = OriginalSquad }
    let okotieRubin = { Name = "Rubin Okotie"; Team = austria; Type = Forward; Status = OriginalSquad }
    let hinterseerLukas = { Name = "Lukas Hinterseer"; Team = austria; Type = Forward; Status = OriginalSquad }

    let private austriaSquad = { Team = austria
                                 Players = [ almerRobert; lindnerHeinz; ozcanRamazan; fuchsChristian; prodlSebastian; dragovicAleksandar; garicsGyorgy; kleinFlorian; suttnerMarkus
                                             hintereggerMartin; wimmerKevin; harnikMartin; arnautovicMarko; junuzovicZlatko; alabaDavid; baumgartlingerJulian; jantscherJakob; sabitzerMarcel
                                             ilsankerStefan; schopfAlessandro; jankoMarc; okotieRubin; hinterseerLukas ] }

    let kiralyGabor = { Name = "Gábor Király"; Team = hungary; Type = Goalkeeper; Status = OriginalSquad }
    let dibuszDenes = { Name = "Dénes Dibusz"; Team = hungary; Type = Goalkeeper; Status = OriginalSquad }
    let gulacsiPeter = { Name = "Péter Gulácsi"; Team = hungary; Type = Goalkeeper; Status = OriginalSquad }
    let beseBarnabas = { Name = "Barnabás Bese"; Team = hungary; Type = Defender; Status = OriginalSquad }
    let fiolaAttila = { Name = "Attila Fiola"; Team = hungary; Type = Defender; Status = OriginalSquad }
    let guzmicsRichard = { Name = "Richárd Guzmics"; Team = hungary; Type = Defender; Status = OriginalSquad }
    let juhaszRoland = { Name = "Roland Juhász"; Team = hungary; Type = Defender; Status = OriginalSquad }
    let kadarTamas = { Name = "Tamás Kádár"; Team = hungary; Type = Defender; Status = OriginalSquad }
    let korhutMihaly = { Name = "Mihály Korhut"; Team = hungary; Type = Defender; Status = OriginalSquad }
    let langAdam = { Name = "Ádám Lang"; Team = hungary; Type = Defender; Status = OriginalSquad }
    let elekAkos = { Name = "Ákos Elek"; Team = hungary; Type = Midfielder; Status = OriginalSquad }
    let geraZoltan = { Name = "Zoltán Gera"; Team = hungary; Type = Midfielder; Status = OriginalSquad }
    let kleinheislerLaszlo = { Name = "László Kleinheisler"; Team = hungary; Type = Midfielder; Status = OriginalSquad }
    let lovrencsicsGergo = { Name = "Gergő Lovrencsics"; Team = hungary; Type = Midfielder; Status = OriginalSquad }
    let nagyAdam = { Name = "Ádám Nagy"; Team = hungary; Type = Midfielder; Status = OriginalSquad }
    let pinterAdam = { Name = "Ádám Pintér"; Team = hungary; Type = Midfielder; Status = OriginalSquad }
    let stieberZoltan = { Name = "Zoltán Stieber"; Team = hungary; Type = Midfielder; Status = OriginalSquad }
    let bodeDaniel = { Name = "Dániel Böde"; Team = hungary; Type = Forward; Status = OriginalSquad }
    let dzsudzsakBalazs = { Name = "Balázs Dzsudzsák"; Team = hungary; Type = Forward; Status = OriginalSquad }
    let nemethKrisztian = { Name = "Krisztián Németh"; Team = hungary; Type = Forward; Status = OriginalSquad }
    let nikolicNemanja = { Name = "Nemanja Nikolić"; Team = hungary; Type = Forward; Status = OriginalSquad }
    let priskinTamas = { Name = "Tamás Priskin"; Team = hungary; Type = Forward; Status = OriginalSquad }
    let szalaiAdam = { Name = "Ádám Szalai"; Team = hungary; Type = Forward; Status = OriginalSquad }

    let private hungarySquad = { Team = hungary
                                 Players = [ kiralyGabor; dibuszDenes; gulacsiPeter; beseBarnabas; fiolaAttila; guzmicsRichard; juhaszRoland; kadarTamas; korhutMihaly; langAdam; elekAkos
                                             geraZoltan; kleinheislerLaszlo; lovrencsicsGergo; nagyAdam; pinterAdam; stieberZoltan; bodeDaniel; dzsudzsakBalazs; nemethKrisztian; nikolicNemanja
                                             priskinTamas; szalaiAdam ] }

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

    let private icelandSquad = { Team = iceland
                                 Players = [ halldorssonHannesThor; kristinssonOgmundur; jonssonIngvar; saevarssonBirkirMar; sigurdssonRagnar; arnasonKari; skulasonAriFreyr; haukssonHaukurHeidar
                                             ingasonSverrirIngi; magnussonHordurBjorgvin; hermannssonHjortur; gunnarssonAron; hallfredssonEmil; bjarnasonBirkir; gudmundssonJohannBerg
                                             sigurdssonGylfi; bjarnssonTheodorElmar; sigurjonssonRunarMar; traustasonArnorIngvi; gudjohnsenEidur; sigthorssonKolbeinn; finnbogasonAlfred
                                             bodvarssonJonDadi ] }

    let teams = [ france; switzerland; romania; albania
                  england; russia; slovakia; wales
                  germany; ukraine; poland; northernIreland
                  spain; croatia; czechRepublic; turkey
                  belgium; italy; sweden; republicOfIreland
                  portugal; austria; hungary; iceland ]

    let private coaches = teams |> List.map (fun team -> team.Coach, team)

    let private squads = [ franceSquad; switzerlandSquad; romaniaSquad; albaniaSquad
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

    let groupAFranceVsRomania = { Team1Score = TeamMatchScore (france, 2<goal>, None); Team2Score = TeamMatchScore (romania, 1<goal>, None)
                                  Number = 1; Stage = groupA; KickOff = DateTime (2016, 06, 10, 20, 00, 00)
                                  Events = [ ManOfTheMatch payetDimitri
                                             Goal (giroudOlivier, Some 57<min>, Some payetDimitri) (* france *)
                                             YellowCard (giroudOlivier, Some 69<min>)
                                             Goal (payetDimitri, Some 89<min>, Some kanteNGolo)
                                             YellowCard (chirichesVlad, Some 32<min>) (* romania *)
                                             YellowCard (ratRazvan, Some 45<min>)
                                             Penalty (stancuBogdan, true, Some 65<min>, Some stanciuNicolae, None)
                                             YellowCard (popaAdrian, Some 78<min>) ] }

    let groupAAlbaniaVsSwitzerland = { Team1Score = TeamMatchScore (albania, 0<goal>, None); Team2Score = TeamMatchScore (switzerland, 1<goal>, None)
                                       Number = 2; Stage = groupA; KickOff = DateTime (2016, 06, 11, 14, 00, 00)
                                       Events = [ ManOfTheMatch xhakaGranit
                                                  YellowCard (canaLorik, Some 23<min>) (* albania *)
                                                  YellowCard (canaLorik, Some 36<min>)
                                                  YellowCard (kaceErgys, Some 63<min>)
                                                  YellowCard (kukeliBurim, Some 89<min>)
                                                  YellowCard (mavrajMergim, Some 92<min>)
                                                  Goal (scharFabian, Some 5<min>, Some shaqiriXherdan) (* switzerland *)
                                                  YellowCard (scharFabian, Some 14<min>)
                                                  YellowCard (behramiValon, Some 67<min>)
                                                  CleanSheet (sommerYann, None) ] }
                                           
    let groupARomaniaVsSwitzerland = { Team1Score = TeamMatchScore (romania, 1<goal>, None); Team2Score = TeamMatchScore (switzerland, 1<goal>, None)
                                       Number = 14; Stage = groupA; KickOff = DateTime (2016, 06, 15, 17, 00, 00)
                                       Events = [ ManOfTheMatch xhakaGranit
                                                  Penalty (stancuBogdan, true, Some 18<min>, Some chipciuAlexandru, None) (* romania *)
                                                  YellowCard (prepelitaAndrei, Some 22<min>)
                                                  YellowCard (chipciuAlexandru, Some 24<min>)
                                                  YellowCard (keseruClaudiu, Some 37<min>)
                                                  YellowCard (grigoreDragos, Some 76<min>)
                                                  YellowCard (xhakaGranit, Some 50<min>) (* switzerland *)
                                                  Goal (mehmediAdmir, Some 57<min>, Some djourouJohan) ] }
                                           
    let groupAFranceVsAlbania = { Team1Score = TeamMatchScore (france, 2<goal>, None); Team2Score = TeamMatchScore (albania, 0<goal>, None)
                                  Number = 15; Stage = groupA; KickOff = DateTime (2016, 06, 15, 20, 00, 00)
                                  Events = [ ManOfTheMatch payetDimitri
                                             YellowCard (kanteNGolo, Some 88<min>) (* france *)
                                             Goal (griezmannAntoine, Some 90<min>, Some ramiAdil)
                                             Goal (payetDimitri, Some 96<min>, Some gignacAndrePierre)
                                             CleanSheet (llorisHugo, None)
                                             YellowCard (kukeliBurim, Some 55<min>) (* albania *)
                                             YellowCard (abrashiAmir, Some 81<min>) ] }
                                           
    let groupARomaniaVsAlbania = { Team1Score = TeamMatchScore (romania, 0<goal>, None); Team2Score = TeamMatchScore (albania, 1<goal>, None)
                                   Number = 25; Stage = groupA; KickOff = DateTime (2016, 06, 19, 20, 00, 00)
                                   Events = [ ManOfTheMatch ajetiArlind
                                              YellowCard (matelAlexandru, Some 54<min>) (* romania *)
                                              YellowCard (sapunaruCristian, Some 85<min>)
                                              YellowCard (torjeGabriel, Some 93<min>)
                                              YellowCard (bashaMigjen, Some 6<min>) (* albania *)
                                              Goal (sadikuArmando, Some 43<min>, Some memushajLedian)
                                              YellowCard (memushajLedian, Some 85<min>)
                                              YellowCard (hysajElseid, Some 94<min>)
                                              CleanSheet (berishaEtrit, None) ] }
                                           
    let groupASwitzerlandVsFrance = { Team1Score = TeamMatchScore (switzerland, 0<goal>, None); Team2Score = TeamMatchScore (france, 0<goal>, None)
                                      Number = 26; Stage = groupA; KickOff = DateTime (2016, 06, 19, 20, 00, 00)
                                      Events = [ ManOfTheMatch sommerYann                                                
                                                 CleanSheet (sommerYann, None) (* switzerland *)
                                                 YellowCard (ramiAdil, Some 25<min>) (* france *)
                                                 YellowCard (koscielnyLaurent, Some 83<min>)                                               
                                                 CleanSheet (llorisHugo, None) ] }
                                           
    let private groupAMatches = [ groupAFranceVsRomania; groupAAlbaniaVsSwitzerland; groupARomaniaVsSwitzerland; groupAFranceVsAlbania; groupARomaniaVsAlbania; groupASwitzerlandVsFrance ]

    // Group B matches: https://en.wikipedia.org/wiki/UEFA_Euro_2016_Group_B.

    let groupBWalesVsSlovakia = { Team1Score = TeamMatchScore (wales, 2<goal>, None); Team2Score = TeamMatchScore (slovakia, 1<goal>, None)
                                  Number = 3; Stage = groupB; KickOff = DateTime (2016, 06, 11, 17, 00, 00)
                                  Events = [ ManOfTheMatch allenJoe
                                             Goal (baleGareth, Some 10<min>, Some williamsJonathan) (* wales *)
                                             Goal (robsonKanuHal, Some 81<min>, Some ramseyAaron)
                                             YellowCard (hrosovskyPatrik, Some 31<min>) (* slovakia *)
                                             Goal (dudaOndrej, Some 61<min>, Some makRobert)
                                             YellowCard (makRobert, Some 78<min>)
                                             YellowCard (weissVladimir, Some 80<min>)
                                             YellowCard (kuckaJuraj, Some 83<min>)
                                             YellowCard (skrtelMartin, Some 92<min>) ] }
                                           
    let groupBEnglandVsRussia = { Team1Score = TeamMatchScore (england, 1<goal>, None); Team2Score = TeamMatchScore (russia, 1<goal>, None)
                                  Number = 4; Stage = groupB; KickOff = DateTime (2016, 06, 11, 20, 00, 00)
                                  Events = [ ManOfTheMatch dierEric
                                             YellowCard (cahillGary, Some 62<min>) (* england *)
                                             Goal (dierEric, Some 73<min>, Some alliDele)
                                             YellowCard (shchennikovGeorgi, Some 72<min>) (* russia *)
                                             Goal (berezutskiVasili, Some 92<min>, Some smolnikovIgor) ] }
                                           
    let groupBRussiaVsSlovakia = { Team1Score = TeamMatchScore (russia, 1<goal>, None); Team2Score = TeamMatchScore (slovakia, 2<goal>, None)
                                   Number = 13; Stage = groupB; KickOff = DateTime (2016, 06, 15, 14, 00, 00)
                                   Events = [ ManOfTheMatch hamsikMarek
                                              Goal (glushakovDenis, Some 80<min>, Some shatovOleg) (* russia *)
                                              Goal (weissVladimir, Some 32<min>, Some hamsikMarek) (* slovakia *)
                                              Goal (hamsikMarek, Some 45<min>, Some weissVladimir)
                                              YellowCard (duricaJan, Some 46<min>) ] }
                                           
    let groupBEnglandVsWales = { Team1Score = TeamMatchScore (england, 2<goal>, None); Team2Score = TeamMatchScore (wales, 1<goal>, None)
                                 Number = 16; Stage = groupB; KickOff = DateTime (2016, 06, 16, 14, 00, 00)
                                 Events = [ ManOfTheMatch walkerKyle
                                            Goal (vardyJamie, Some 56<min>, None) (* england *)
                                            Goal (sturridgeDaniel, Some 92<min>, Some alliDele)
                                            Goal (baleGareth, Some 42<min>, Some robsonKanuHal) (* wales *)
                                            YellowCard (daviesBen, Some 61<min>) ] }
                                           
    let groupBRussiaVsWales = { Team1Score = TeamMatchScore (russia, 0<goal>, None); Team2Score = TeamMatchScore (wales, 3<goal>, None)
                                Number = 27; Stage = groupB; KickOff = DateTime (2016, 06, 20, 20, 00, 00)
                                Events = [ ManOfTheMatch ramseyAaron
                                           YellowCard (mamayevPavel, Some 64<min>) (* russia *)
                                           Goal (ramseyAaron, Some 11<min>, Some allenJoe) (* wales *)
                                           YellowCard (vokesSam, Some 16<min>)
                                           Goal (taylorNeil, Some 20<min>, None)
                                           Goal (baleGareth, Some 67<min>, Some ramseyAaron)
                                           CleanSheet (hennesseyWayne, None) ] }
                                           
    let groupBSlovakiaVsEngland = { Team1Score = TeamMatchScore (slovakia, 0<goal>, None); Team2Score = TeamMatchScore (england, 0<goal>, None)
                                    Number = 28; Stage = groupB; KickOff = DateTime (2016, 06, 20, 20, 00, 00)
                                    Events = [ ManOfTheMatch kozacikMatus
                                               YellowCard (pecovskyViktor, Some 24<min>) (* slovakia *)
                                               CleanSheet (kozacikMatus, None)
                                               YellowCard (bertrandRyan, Some 52<min>) (* england *)
                                               CleanSheet (hartJoe, None) ] }
                                           
    let private groupBMatches = [ groupBWalesVsSlovakia; groupBEnglandVsRussia; groupBRussiaVsSlovakia; groupBEnglandVsWales; groupBRussiaVsWales; groupBSlovakiaVsEngland ]

    // Group C matches: https://en.wikipedia.org/wiki/UEFA_Euro_2016_Group_C.

    let groupCPolandVsNorthernIreland = { Team1Score = TeamMatchScore (poland, 1<goal>, None); Team2Score = TeamMatchScore (northernIreland, 0<goal>, None)
                                          Number = 6; Stage = groupC; KickOff = DateTime (2016, 06, 12, 17, 00, 00)
                                          Events = [ ManOfTheMatch krychowiakGrzegorz
                                                     Goal (milikArkadiusz, Some 51<min>, Some blaszczykowskiJakub) (* poland *)
                                                     YellowCard (kapustkaBartosz, Some 65<min>)
                                                     YellowCard (piszczekLukasz, Some 89<min>)
                                                     CleanSheet (szczesnyWojciech, None)
                                                     YellowCard (cathcartCraig, Some 69<min>) (* northernIreland *) ] }
                                           
    let groupCGermanyVsUkraine = { Team1Score = TeamMatchScore (germany, 2<goal>, None); Team2Score = TeamMatchScore (ukraine, 0<goal>, None)
                                   Number = 7; Stage = groupC; KickOff = DateTime (2016, 06, 12, 20, 00, 00)
                                   Events = [ ManOfTheMatch kroosToni
                                              Goal (mustafiShkodran, Some 19<min>, Some kroosToni) (* germany *)
                                              Goal (schweinsteigerBastian, Some 92<min>, Some ozilMesut)
                                              CleanSheet (neuerManuel, None)
                                              YellowCard (konoplyankaYevhen, Some 68<min>) (* ukraine *) ] }
                                           
    let groupCUkraineVsNorthernIreland = { Team1Score = TeamMatchScore (ukraine, 0<goal>, None); Team2Score = TeamMatchScore (northernIreland, 2<goal>, None)
                                           Number = 17; Stage = groupC; KickOff = DateTime (2016, 06, 16, 17, 00, 00)
                                           Events = [ ManOfTheMatch mcAuleyGareth
                                                      YellowCard (seleznyovYevhen, Some 40<min>) (* ukraine *)
                                                      YellowCard (sydorchukSerhiy, Some 67<min>)
                                                      Goal (mcAuleyGareth, Some 49<min>, Some norwoodOliver) (* northernIreland *)
                                                      YellowCard (wardJamie, Some 61<min>)
                                                      YellowCard (dallasStuart, Some 87<min>)
                                                      YellowCard (evansJonny, Some 94<min>)
                                                      Goal (mcGinnNiall, Some 96<min>, None)
                                                      CleanSheet (mcGovernMichael, None) ] }
                                           
    let groupCGermanyVsPoland = { Team1Score = TeamMatchScore (germany, 0<goal>, None); Team2Score = TeamMatchScore (poland, 0<goal>, None)
                                  Number = 18; Stage = groupC; KickOff = DateTime (2016, 06, 16, 20, 00, 00)
                                  Events = [ ManOfTheMatch boatengJerome
                                             YellowCard (khediraSami, Some 3<min>) (* germany *)
                                             YellowCard (ozilMesut, Some 34<min>)
                                             YellowCard (boatengJerome, Some 67<min>)
                                             CleanSheet (neuerManuel, None)
                                             YellowCard (maczynskiKrzysztof, Some 45<min>) (* poland *)
                                             YellowCard (grosickiKamil, Some 55<min>)
                                             YellowCard (peszkoSlawomir, Some 93<min>)
                                             CleanSheet (fabianskiLukasz, None) ] }
                                           
    let groupCUkraineVsPoland = { Team1Score = TeamMatchScore (ukraine, 0<goal>, None); Team2Score = TeamMatchScore (poland, 1<goal>, None)
                                  Number = 29; Stage = groupC; KickOff = DateTime (2016, 06, 21, 17, 00, 00)
                                  Events = [ ManOfTheMatch rotanRuslan
                                             YellowCard (rotanRuslan, Some 25<min>) (* ukraine *)
                                             YellowCard (kucherOleksandr, Some 38<min>)
                                             CleanSheet (pyatovAndriy, None)
                                             Goal (blaszczykowskiJakub, Some 54<min>, Some milikArkadiusz) (* poland *)
                                             YellowCard (kapustkaBartosz, Some 60<min>)
                                             CleanSheet (fabianskiLukasz, None) ] }
                                           
    let groupCNorthernIrelandVsGermany = { Team1Score = TeamMatchScore (northernIreland, 0<goal>, None); Team2Score = TeamMatchScore (germany, 1<goal>, None)
                                           Number = 30; Stage = groupC; KickOff = DateTime (2016, 06, 21, 17, 00, 00)
                                           Events = [ ManOfTheMatch ozilMesut
                                                      (* northernIreland *)
                                                      Goal (gomezMario, Some 30<min>, Some mullerThomas) (* germany *)
                                                      CleanSheet (neuerManuel, None) ] }
                                           
    let private groupCMatches = [ groupCPolandVsNorthernIreland; groupCGermanyVsUkraine; groupCUkraineVsNorthernIreland; groupCGermanyVsPoland; groupCUkraineVsPoland
                                  groupCNorthernIrelandVsGermany ]

    // Group D matches: https://en.wikipedia.org/wiki/UEFA_Euro_2016_Group_D.

    let groupDTurkeyVsCroatia = { Team1Score = TeamMatchScore (turkey, 0<goal>, None); Team2Score = TeamMatchScore (croatia, 1<goal>, None)
                                  Number = 5; Stage = groupD; KickOff = DateTime (2016, 06, 12, 14, 00, 00)
                                  Events = [ ManOfTheMatch modricLuka
                                             YellowCard (tosunCenk, Some 31<min>) (* turkey *)
                                             YellowCard (baltaHakanKadir, Some 48<min>)
                                             YellowCard (senVolkan, Some 91<min>)
                                             Goal (modricLuka, Some 41<min>, None) (* croatia *)
                                             YellowCard (strinicIvan, Some 80<min>)
                                             CleanSheet (subasicDanijel, None) ] }
                                           
    let groupDSpainVsCzechRepublic = { Team1Score = TeamMatchScore (spain, 1<goal>, None); Team2Score = TeamMatchScore (czechRepublic, 0<goal>, None)
                                       Number = 8; Stage = groupD; KickOff = DateTime (2016, 06, 13, 14, 00, 00)
                                       Events = [ ManOfTheMatch iniestaAndres
                                                  Goal (piqueGerard, Some 87<min>, Some iniestaAndres) (* spain *)
                                                  CleanSheet (deGeaDavid, None)
                                                  YellowCard (limberskyDavid, Some 61<min>) (* czechRepublic *) ] }
                                           
    let groupDCzechRepublicVsCroatia = { Team1Score = TeamMatchScore (czechRepublic, 2<goal>, None); Team2Score = TeamMatchScore (croatia, 2<goal>, None)
                                         Number = 20; Stage = groupD; KickOff = DateTime (2016, 06, 17, 17, 00, 00)
                                         Events = [ ManOfTheMatch rakiticIvan
                                                    YellowCard (sivokTomas, Some 72<min>) (* czechRepublic *)
                                                    Goal (skodaMilan, Some 76<min>, Some rosickyTomas)
                                                    Penalty (necidTomas, true, Some 94<min>, None, None)
                                                    YellowCard (badeljMilan, Some 14<min>) (* croatia *)
                                                    Goal (perisicIvan, Some 37<min>, Some badeljMilan)
                                                    Goal (rakiticIvan, Some 59<min>, Some brozovicMarcelo)
                                                    YellowCard (brozovicMarcelo, Some 74<min>)
                                                    YellowCard (vidaDomagoj, Some 93<min>) ] }
                                           
    let groupDSpainVsTurkey = { Team1Score = TeamMatchScore (spain, 3<goal>, None); Team2Score = TeamMatchScore (turkey, 0<goal>, None)
                                Number = 21; Stage = groupD; KickOff = DateTime (2016, 06, 17, 20, 00, 00)
                                Events = [ ManOfTheMatch iniestaAndres
                                           YellowCard (ramosSergio, Some 2<min>) (* spain *)
                                           Goal (morataAlvaro, Some 34<min>, Some nolito)
                                           Goal (nolito, Some 37<min>, None)
                                           Goal (morataAlvaro, Some 48<min>, Some albaJordi)
                                           CleanSheet (deGeaDavid, None)
                                           YellowCard (yilmazBurak, Some 9<min>) (* turkey *)
                                           YellowCard (tufanOzan, Some 41<min>) ] }
                                           
    let groupDCzechRepublicVsTurkey = { Team1Score = TeamMatchScore (czechRepublic, 0<goal>, None); Team2Score = TeamMatchScore (turkey, 2<goal>, None)
                                        Number = 31; Stage = groupD; KickOff = DateTime (2016, 06, 21, 20, 00, 00)
                                        Events = [ ManOfTheMatch yilmazBurak
                                                   YellowCard (plasilJaroslav, Some 36<min>) (* czechRepublic *)
                                                   YellowCard (pavelkaDavid, Some 39<min>)
                                                   YellowCard (suralJosef, Some 87<min>)
                                                   Goal (yilmazBurak, Some 10<min>, Some morEmre) (* turkey *)
                                                   YellowCard (koybasiIsmail, Some 35<min>)
                                                   YellowCard (baltaHakanKadir, Some 50<min>)
                                                   Goal (tufanOzan, Some 65<min>, Some topalMehmet)
                                                   CleanSheet (babacanVolkan, None) ] }
                                           
    let groupDCroatiaVsSpain = { Team1Score = TeamMatchScore (croatia, 2<goal>, None); Team2Score = TeamMatchScore (spain, 1<goal>, None)
                                 Number = 32; Stage = groupD; KickOff = DateTime (2016, 06, 21, 20, 00, 00)
                                 Events = [ ManOfTheMatch perisicIvan
                                            YellowCard (rogMarko, Some 29<min>) (* croatia *)
                                            Goal (kalinicNikola, Some 45<min>, Some perisicIvan)
                                            YellowCard (vrsaljkoSime, Some 70<min>)
                                            YellowCard (srnaDarijo, Some 70<min>)
                                            Goal (perisicIvan, Some 87<min>, Some kalinicNikola)
                                            YellowCard (perisicIvan, Some 88<min>)
                                            Goal (morataAlvaro, Some 7<min>, Some fabregasCesc) (* spain *)
                                            Penalty (ramosSergio, false, Some 71<min>, Some silvaDavid, Some subasicDanijel) ] }
                                           
    let private groupDMatches = [ groupDTurkeyVsCroatia; groupDSpainVsCzechRepublic; groupDCzechRepublicVsCroatia; groupDSpainVsTurkey; groupDCzechRepublicVsTurkey; groupDCroatiaVsSpain ]

    // Group E matches: https://en.wikipedia.org/wiki/UEFA_Euro_2016_Group_E.

    let groupERepublicOfIrelandVsSweden = { Team1Score = TeamMatchScore (republicOfIreland, 1<goal>, None); Team2Score = TeamMatchScore (sweden, 1<goal>, None)
                                            Number = 9; Stage = groupE; KickOff = DateTime (2016, 06, 13, 17, 00, 00)
                                            Events = [ ManOfTheMatch hoolahanWes
                                                       YellowCard (mcCarthyJames, Some 43<min>) (* republicOfIreland *)
                                                       Goal (hoolahanWes, Some 48<min>, Some colemanSeamus)
                                                       OwnGoal (sweden, clarkCiaran, Some 71<min>, Some ibrahimovicZlatan)
                                                       YellowCard (whelanGlenn, Some 77<min>)
                                                       YellowCard (lindelofVictor, Some 61<min>) (* sweden *) ] }
                                           
    let groupEBelgiumVsItaly = { Team1Score = TeamMatchScore (belgium, 0<goal>, None); Team2Score = TeamMatchScore (italy, 2<goal>, None)
                                 Number = 10; Stage = groupE; KickOff = DateTime (2016, 06, 13, 20, 00, 00)
                                 Events = [ ManOfTheMatch giaccheriniEmanuele
                                            YellowCard (vertonghenJan, Some 92<min>) (* belgium *)
                                            Goal (giaccheriniEmanuele, Some 32<min>, Some bonucciLeonardo) (* italy *)
                                            YellowCard (chielliniGiorgio, Some 66<min>)
                                            YellowCard (eder_Italy, Some 75<min>)
                                            YellowCard (bonucciLeonardo, Some 78<min>)
                                            YellowCard (mottaThiago, Some 84<min>)
                                            Goal (pelleGraciano, Some 93<min>, Some candrevaAntonio)
                                            CleanSheet (buffonGianluigi, None) ] }
                                           
    let groupEItalyVsSweden = { Team1Score = TeamMatchScore (italy, 1<goal>, None); Team2Score = TeamMatchScore (sweden, 0<goal>, None)
                                Number = 19; Stage = groupE; KickOff = DateTime (2016, 06, 17, 14, 00, 00)
                                Events = [ ManOfTheMatch eder_Italy
                                           YellowCard (deRossiDaniele, Some 69<min>) (* italy *)
                                           Goal (eder_Italy, Some 88<min>, Some zazaSimone)
                                           YellowCard (buffonGianluigi, Some 93<min>)
                                           CleanSheet (buffonGianluigi, None)
                                           YellowCard (olssonMartin, Some 93<min>) (* sweden *) ] }
                                           
    let groupEBelgiumVsRepublicOfIreland = { Team1Score = TeamMatchScore (belgium, 3<goal>, None); Team2Score = TeamMatchScore (republicOfIreland, 0<goal>, None)
                                             Number = 22; Stage = groupE; KickOff = DateTime (2016, 06, 18, 14, 00, 00)
                                             Events = [ ManOfTheMatch witselAxel
                                                        Goal (lukakuRomelu, Some 48<min>, Some deBruyneKevin) (* belgium *)
                                                        YellowCard (vermaelenThomas, Some 49<min>)
                                                        Goal (witselAxel, Some 61<min>, Some meunierThomas)
                                                        Goal (lukakuRomelu, Some 70<min>, Some hazardEden)
                                                        CleanSheet (courtoisThibaut, None)
                                                        YellowCard (hendrickJeff, Some 42<min>) (* republicOfIreland *) ] }
                                           
    let groupEItalyVsRepublicOfIreland = { Team1Score = TeamMatchScore (italy, 0<goal>, None); Team2Score = TeamMatchScore (republicOfIreland, 0<goal>, None)
                                           Number = 35; Stage = groupE; KickOff = DateTime (2016, 06, 22, 20, 00, 00)
                                           Events = [ (* italy *) (* republicOfIreland *) ] }
                                           
    let groupESwedenVsBelgium = { Team1Score = TeamMatchScore (sweden, 0<goal>, None); Team2Score = TeamMatchScore (belgium, 0<goal>, None)
                                  Number = 36; Stage = groupE; KickOff = DateTime (2016, 06, 22, 20, 00, 00)
                                  Events = [ (* sweden *) (* belgium *) ] }
                                           
    let private groupEMatches = [ groupERepublicOfIrelandVsSweden; groupEBelgiumVsItaly; groupEItalyVsSweden; groupEBelgiumVsRepublicOfIreland; groupEItalyVsRepublicOfIreland
                                  groupESwedenVsBelgium ]

    // Group F matches: https://en.wikipedia.org/wiki/UEFA_Euro_2016_Group_F.

    let groupFAustriaVsHungary = { Team1Score = TeamMatchScore (austria, 0<goal>, None); Team2Score = TeamMatchScore (hungary, 2<goal>, None)
                                   Number = 11; Stage = groupF; KickOff = DateTime (2016, 06, 14, 17, 00, 00)
                                   Events = [ ManOfTheMatch kleinheislerLaszlo
                                              YellowCard (dragovicAleksandar, Some 33<min>) (* austria *)
                                              YellowCard (dragovicAleksandar, Some 66<min>)
                                              Goal (szalaiAdam, Some 62<min>, Some kleinheislerLaszlo) (* hungary *)
                                              YellowCard (nemethKrisztian, Some 80<min>)
                                              Goal (stieberZoltan, Some 87<min>, Some priskinTamas)
                                              CleanSheet (kiralyGabor, None) ] }
                                           
    let groupFPortugalVsIceland = { Team1Score = TeamMatchScore (portugal, 1<goal>, None); Team2Score = TeamMatchScore (iceland, 1<goal>, None)
                                    Number = 12; Stage = groupF; KickOff = DateTime (2016, 06, 14, 20, 00, 00)
                                    Events = [ ManOfTheMatch nani
                                               Goal (nani, Some 31<min>, Some gomesAndre) (* portugal *)
                                               Goal (bjarnasonBirkir, Some 50<min>, Some gudmundssonJohannBerg) (* iceland *)
                                               YellowCard (bjarnasonBirkir, Some 55<min>)
                                               YellowCard (finnbogasonAlfred, Some 94<min>) ] }

    let groupFIcelandVsHungary = { Team1Score = TeamMatchScore (iceland, 1<goal>, None); Team2Score = TeamMatchScore (hungary, 1<goal>, None)
                                   Number = 23; Stage = groupF; KickOff = DateTime (2016, 06, 18, 17, 00, 00)
                                   Events = [ ManOfTheMatch sigthorssonKolbeinn
                                              Penalty (sigurdssonGylfi, true, Some 40<min>, Some gunnarssonAron, None) (* iceland *)
                                              YellowCard (gudmundssonJohannBerg, Some 42<min>)
                                              YellowCard (finnbogasonAlfred, Some 75<min>)
                                              YellowCard (saevarssonBirkirMar, Some 77<min>)
                                              OwnGoal (hungary, saevarssonBirkirMar, Some 88<min>, Some nikolicNemanja)                                              
                                              YellowCard (kadarTamas, Some 81<min>) (* hungary *)
                                              YellowCard (kleinheislerLaszlo, Some 83<min>)
                                              YellowCard (nagyAdam, Some 91<min>) ] }
                                           
    let groupFPortugalVsAustria = { Team1Score = TeamMatchScore (portugal, 0<goal>, None); Team2Score = TeamMatchScore (austria, 0<goal>, None)
                                    Number = 24; Stage = groupF; KickOff = DateTime (2016, 06, 18, 20, 00, 00)
                                    Events = [ ManOfTheMatch moutinhoJoao
                                               YellowCard (quaresmaRicardo, Some 31<min>) (* portugal *)
                                               YellowCard (pepe, Some 40<min>)
                                               Penalty (ronaldoCristiano, false, Some 78<min>, Some ronaldoCristiano, None)
                                               CleanSheet (patricioRui, None)
                                               YellowCard (harnikMartin, Some 47<min>) (* austria *)      
                                               YellowCard (fuchsChristian, Some 60<min>)
                                               YellowCard (hintereggerMartin, Some 78<min>)
                                               YellowCard (schopfAlessandro, Some 86<min>)
                                               CleanSheet (almerRobert, None) ] }
                                           
    let groupFIcelandVsAustria = { Team1Score = TeamMatchScore (iceland, 0<goal>, None); Team2Score = TeamMatchScore (austria, 0<goal>, None)
                                   Number = 33; Stage = groupF; KickOff = DateTime (2016, 06, 22, 17, 00, 00)
                                   Events = [ (* iceland *) (* austria *) ] }
                                           
    let groupFHungaryVsPortugal = { Team1Score = TeamMatchScore (hungary, 0<goal>, None); Team2Score = TeamMatchScore (portugal, 0<goal>, None)
                                    Number = 34; Stage = groupF; KickOff = DateTime (2016, 06, 22, 17, 00, 00)
                                    Events = [ (* hungary *) (* portugal *) ] }
                                           
    let private groupFMatches = [ groupFAustriaVsHungary; groupFPortugalVsIceland; groupFIcelandVsHungary; groupFPortugalVsAustria; groupFIcelandVsAustria; groupFHungaryVsPortugal ]

    // Knockout matches: https://en.wikipedia.org/wiki/UEFA_Euro_2016#Knockout_phase.

    // TEMP: Placeholders until the actual teams are known...
    let winnerF = { Name = "Winner F"; Status = Active; Seeding = 6; Coach = "Winner F" }

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

    let match37SwitzerlandVsPoland = { Team1Score = TeamMatchScore (switzerland, 0<goal>, None); Team2Score = TeamMatchScore (poland, 0<goal>, None)
                                       Number = 37; Stage = RoundOf16 37; KickOff = DateTime (2016, 06, 25, 14, 00, 00)
                                       Events = [ (* switzerland *) (* poland *) ] }
                                           
    let match38WalesVsY = { Team1Score = TeamMatchScore (wales, 0<goal>, None); Team2Score = TeamMatchScore (thirdACD, 0<goal>, None)
                            Number = 38; Stage = RoundOf16 38; KickOff = DateTime (2016, 06, 25, 17, 00, 00)
                            Events = [ (* wales *) (* thirdACD *) ] }

    let match39CroatiaVsY = { Team1Score = TeamMatchScore (croatia, 0<goal>, None); Team2Score = TeamMatchScore (thirdBEF, 0<goal>, None)
                              Number = 39; Stage = RoundOf16 39; KickOff = DateTime (2016, 06, 25, 20, 00, 00)
                              Events = [ (* croatia *) (* thirdBEF *) ] }

    let match40FranceVsY = { Team1Score = TeamMatchScore (france, 0<goal>, None); Team2Score = TeamMatchScore (thirdCDE, 0<goal>, None)
                             Number = 40; Stage = RoundOf16 40; KickOff = DateTime (2016, 06, 26, 14, 00, 00)
                             Events = [ (* france *) (* thirdCDE *) ] }

    let match41GermanyVsY = { Team1Score = TeamMatchScore (germany, 0<goal>, None); Team2Score = TeamMatchScore (thirdABF, 0<goal>, None)
                              Number = 41; Stage = RoundOf16 41; KickOff = DateTime (2016, 06, 26, 17, 00, 00)
                              Events = [ (* germany *) (* thirdABF *) ] }

    let match42XVsY = { Team1Score = TeamMatchScore (winnerF, 0<goal>, None); Team2Score = TeamMatchScore (runnerUpE, 0<goal>, None)
                        Number = 42; Stage = RoundOf16 42; KickOff = DateTime (2016, 06, 26, 20, 00, 00)
                        Events = [ (* winnerF *) (* runnerUpE *) ] }
                         
    let match43ItalyVsSpain = { Team1Score = TeamMatchScore (italy, 0<goal>, None); Team2Score = TeamMatchScore (spain, 0<goal>, None)
                                Number = 43; Stage = RoundOf16 43; KickOff = DateTime (2016, 06, 27, 17, 00, 00)
                                Events = [ (* italy *) (* spain *) ] }

    let match44EnglandVsY = { Team1Score = TeamMatchScore (england, 0<goal>, None); Team2Score = TeamMatchScore (runnerUpF, 0<goal>, None)
                              Number = 44; Stage = RoundOf16 44; KickOff = DateTime (2016, 06, 27, 20, 00, 00)
                              Events = [ (* england *) (* runnerUpF *) ] }

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

    let private knockoutMatches = [ match37SwitzerlandVsPoland; match38WalesVsY; match39CroatiaVsY; match40FranceVsY; match41GermanyVsY; match42XVsY; match43ItalyVsSpain; match44EnglandVsY
                                    quarterFinal1XVsY; quarterFinal2XVsY; quarterFinal3XVsY; quarterFinal4XVsY
                                    semiFinal1XVsY; semiFinal2XVsY
                                    finalXVsY ]

    let matches = groupAMatches @ groupBMatches @ groupCMatches @ groupDMatches @ groupEMatches @ groupFMatches @ knockoutMatches

