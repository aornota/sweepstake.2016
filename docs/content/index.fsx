(*** hide ***)
#I "../../src/Sweepstake.2016/bin/Release"

#r "Sweepstake.2016.dll"
open AOrNotA.Sweepstake2016.Content
open AOrNotA.Sweepstake2016.``Data 2016``
open AOrNotA.Sweepstake2016.IndexContent

let lastUpdated = getLastUpdated ()
let indexSummaryAndLinksHtml = getIndexSummaryAndLinksHtml ()
let upcomingFixturesHtml = getUpcomingFixturesHtml 8

let semiFinal2GermanyVsFranceHtml = getMatchDetailsHtml semiFinal2GermanyVsFrance

let semiFinal1PortugalVsWalesHtml = getMatchDetailsHtml semiFinal1PortugalVsWales
let quarterFinal4FranceVsIcelandHtml = getMatchDetailsHtml quarterFinal4FranceVsIceland
let quarterFinal3GermanyVsItalyHtml = getMatchDetailsHtml quarterFinal3GermanyVsItaly
let quarterFinal2WalesVsBelgiumHtml = getMatchDetailsHtml quarterFinal2WalesVsBelgium
let quarterFinal1PolandVsPortugalHtml = getMatchDetailsHtml quarterFinal1PolandVsPortugal
let match44EnglandVsIcelandHtml = getMatchDetailsHtml match44EnglandVsIceland
let match43ItalyVsSpainHtml = getMatchDetailsHtml match43ItalyVsSpain
let match42HungaryVsBelgiumHtml = getMatchDetailsHtml match42HungaryVsBelgium
let match41GermanyVsSlovakiaHtml = getMatchDetailsHtml match41GermanyVsSlovakia
let match40FranceVsRepublicOfIrelandHtml = getMatchDetailsHtml match40FranceVsRepublicOfIreland
let match39CroatiaVsPortugalHtml = getMatchDetailsHtml match39CroatiaVsPortugal
let match38WalesVsNorthernIrelandHtml = getMatchDetailsHtml match38WalesVsNorthernIreland
let match37SwitzerlandVsPolandHtml = getMatchDetailsHtml match37SwitzerlandVsPoland
let groupESwedenVsBelgiumHtml = getMatchDetailsHtml groupESwedenVsBelgium
let groupEItalyVsRepublicOfIrelandHtml = getMatchDetailsHtml groupEItalyVsRepublicOfIreland
let groupFHungaryVsPortugalHtml = getMatchDetailsHtml groupFHungaryVsPortugal
let groupFIcelandVsAustriaHtml = getMatchDetailsHtml groupFIcelandVsAustria
let groupDCroatiaVsSpainHtml = getMatchDetailsHtml groupDCroatiaVsSpain
let groupDCzechRepublicVsTurkeyHtml = getMatchDetailsHtml groupDCzechRepublicVsTurkey
let groupCNorthernIrelandVsGermanyHtml = getMatchDetailsHtml groupCNorthernIrelandVsGermany
let groupCUkraineVsPolandHtml = getMatchDetailsHtml groupCUkraineVsPoland
let groupBSlovakiaVsEnglandHtml = getMatchDetailsHtml groupBSlovakiaVsEngland
let groupBRussiaVsWalesHtml = getMatchDetailsHtml groupBRussiaVsWales
let groupASwitzerlandVsFranceHtml = getMatchDetailsHtml groupASwitzerlandVsFrance
let groupARomaniaVsAlbaniaHtml = getMatchDetailsHtml groupARomaniaVsAlbania
let groupFPortugalVsAustriaHtml = getMatchDetailsHtml groupFPortugalVsAustria
let groupFIcelandVsHungaryHtml = getMatchDetailsHtml groupFIcelandVsHungary
let groupEBelgiumVsRepublicOfIrelandHtml = getMatchDetailsHtml groupEBelgiumVsRepublicOfIreland
let groupDSpainVsTurkeyHtml = getMatchDetailsHtml groupDSpainVsTurkey
let groupDCzechRepublicVsCroatiaHtml = getMatchDetailsHtml groupDCzechRepublicVsCroatia
let groupEItalyVsSwedenHtml = getMatchDetailsHtml groupEItalyVsSweden
let groupCGermanyVsPolandHtml = getMatchDetailsHtml groupCGermanyVsPoland
let groupCUkraineVsNorthernIrelandHtml = getMatchDetailsHtml groupCUkraineVsNorthernIreland
let groupBEnglandVsWalesHtml = getMatchDetailsHtml groupBEnglandVsWales
let groupAFranceVsAlbaniaHtml = getMatchDetailsHtml groupAFranceVsAlbania
let groupARomaniaVsSwitzerlandHtml = getMatchDetailsHtml groupARomaniaVsSwitzerland
let groupBRussiaVsSlovakiaHtml = getMatchDetailsHtml groupBRussiaVsSlovakia
let groupFPortugalVsIceland = getMatchDetailsHtml groupFPortugalVsIceland
let groupFAustriaVsHungaryHtml = getMatchDetailsHtml groupFAustriaVsHungary
let groupEBelgiumVsItalyHtml = getMatchDetailsHtml groupEBelgiumVsItaly
let groupERepublicOfIrelandVsSwedenHtml = getMatchDetailsHtml groupERepublicOfIrelandVsSweden
let groupDSpainVsCzechRepublicHtml = getMatchDetailsHtml groupDSpainVsCzechRepublic
let groupCGermanyVsUkraineHtml = getMatchDetailsHtml groupCGermanyVsUkraine
let groupCPolandVsNorthernIrelandHtml = getMatchDetailsHtml groupCPolandVsNorthernIreland
let groupDTurkeyVsCroatiaHtml = getMatchDetailsHtml groupDTurkeyVsCroatia
let groupBEnglandVsRussiaHtml = getMatchDetailsHtml groupBEnglandVsRussia
let groupBWalesVsSlovakiaHtml = getMatchDetailsHtml groupBWalesVsSlovakia
let groupAAlbaniaVsSwitzerlandHtml = getMatchDetailsHtml groupAAlbaniaVsSwitzerland
let groupAFranceVsRomaniaHtml = getMatchDetailsHtml groupAFranceVsRomania
let indexDetailHtml = getIndexDetailHtml ()

(**
Latest news
===========
*)

(*** include-value: lastUpdated ***)

(*** include-value: indexSummaryAndLinksHtml ***)

(*** include-value: upcomingFixturesHtml ***)

(**
## Thursday 7th July
*)

(*** include-value: semiFinal2GermanyVsFranceHtml ***)

(**
A fine first half - followed by a second half so dull that I spent most of it reading _Private Eye_ and listening to a wonderful Hungarian 
jazz/folk cimbalom duo (the aptly-named Cimbalomduo, pop pickers) - sees France through to Sunday's final thanks to a rather questionable 
penalty and a masterpiece of hubristic defending. (And, to be fair, a few world-class saves from Hugo Lloris - who is also the world's only 
venomous goalkeeper...)

On the sweepstake front, a classy performance from Antoine Griezmann sees Rosie leap into mid-table obscurity - and pretty much guaranteed 
to finish above Hugh (unless Rui Patricio does something extraordinary). Jem reclaims second place and both him and Will look sure to finish 
in the top three - and retain plausible hopes of beating Steve M to the title (and the big money). Everyone apart from Josh and Susie still 
has players left; Rob somehow has six - but won't be able to prevent Chris from claiming the wooden spoon even if all of them get sent-off 
in the final. (Well, unless Andre-Pierre Gignac scores some points. Which he won't.)
*)

(**
## Wednesday 6th July
*)

(*** include-value: semiFinal1PortugalVsWalesHtml ***)

(**
After finally managing to win a match in ninety minutes, a workmanlike Portugal team makes it through to Sunday's final; belated consolation 
for Welsh fans as Ryan Giggs actually shows up for a game. Will and Jem close the gap at the top of the table (with the former moving into 
second place); points also for Hugh and Steve S. 
*)

(**
## Sunday 3rd July
*)

(*** include-value: quarterFinal4FranceVsIcelandHtml ***)

(**
"The word 'enigma' was almost invented for Olivier Giroud, wasn't it?" No. (And as for Glenn Hoddle's "fatigueness" neologism...)

Impressive stuff from the French, though they still look shaky in defense. Lots of goals means lots of points: Steve S starts a late charge; 
Steve M stretches his lead still further; Rosie overtakes Hugh; Jem and Will are now second and third respectively.
*)

(**
## Saturday 2nd July
*)

(*** include-value: quarterFinal3GermanyVsItalyHtml ***)

(**
"The ball hasn't come down yet..."

Germany finally get the better of Italy in a major tournament and go through to yet another semi-final. Thomas Muller not only missed 
in the shootout but also clearly missed his calling as a mime artist - and lovers of dreadful penalties will be savouring the risible 
efforts from Simone Zaza, Graziano Pelle and Bastian Schweinsteiger for years to come.

Steve M picks up more points and will be hard to catch; Denis keeps alive his hopes of a top-three finish; Rosie gets a boost to her 
chances of overhauling Hugh.
*)

(**
## Friday 1st July
*)

(*** include-value: quarterFinal2WalesVsBelgiumHtml ***)

(**
"Look at these bouncing, dancing, prancing Welshmen..."

That's more like it. A purposeful Welsh team progresses to a showdown against Portugal next Wednesday as a weakened Belgian defense 
leaks three goals to, uh, Ashley Williams, Hal Robson-Kanu and Sam Vokes. (Hell, even Neil Taylor nearly scored again.) Just a shame 
about an unlucky yellow card that rules Aaron Ramsey out of the semi-final.

More losers than winners on the sweepstake side of things: Jem draws level with Josh in second; Neph sneaks ahead of Denis.
*)

(**
## Thursday 30th June
*)

(*** include-value: quarterFinal1PolandVsPortugalHtml ***)

(**
Not quite as poor as the Wales vs Northern Ireland game - but close (especially during extra time) as an uninspired Poland fail to halt 
the relentless trudge of a misfiring Portuguese team. Will loses his coach/team but narrows the gap to the top three thanks to the 
industrious Renato Sanches; Hugh continues his slow climb to the top half of the table; points also for Steve S and Jem; and Rosie's 
attempts to foul her way to the wooden spoon are helped by Bartosz Kapustka's third yellow card in four games.
*)

(**
## Monday 27th June
*)

(*** include-value: match44EnglandVsIcelandHtml ***)

(**
Clive Tyldesley, understated as ever: "...and the inquests may just overshadow everything else that's going on in the UK at the moment."

(Or, to quote a random friend: Sigur Ros 2 - 1 Coldplay.)

After the shock and chaos of the last few days, a Karmic fable for our troubled times as Iceland's newly-elected President is greeted by 
a display of passion and guile whereas the English can add a bucket of pigshit to the plunging pound and expanding vacuum at the centre 
of civic life. And in the light of the successful managerial partnership of Lars Lagerback and Heimir Hallgrimsson, is it too early to 
suggest a Boris-and-Nigel "dream team" to follow Roy Hodgson?

As for the sweepstake: Steve M moves further ahead; Susie climbs out of the bottom three; little of note for anyone else.
*)

(*** include-value: match43ItalyVsSpainHtml ***)

(**
An Italian performance full of commitment and camaraderie puts paid to Spanish hopes of a third successive title. Chris is now a clear 
favourite for the coveted wooden spoon; Steve M extends his lead; Josh returns to second; points also for Susie and Hugh.
*)

(**
## Sunday 26th June
*)

(*** include-value: match42HungaryVsBelgiumHtml ***)

(**
Three late goals make an impressive Belgian win look a little more one-sided than it was. The Hazard and De Bruyne show takes Jem to second 
ahead of Josh; Steve M consolidates his lead; and Steve S and Rob grab useful points.
*)

(*** include-value: match41GermanyVsSlovakiaHtml ***)

(**
Three and easy for Germany. Steve M and Josh pull away from the pack; Denis benefits from yet another clean sheet for Manuel Neuer; Rosie 
curses a lame penalty from Mesut Ozil.
*)

(*** include-value: match40FranceVsRepublicOfIrelandHtml ***)

(**
A game too far for Ireland as the hosts find their mojo in the second half to book a quarter-final against England or Iceland. Antoine 
Griezmann helps Rosie get going at last; Jem joins Josh in fourth; scraps for Steve S and Denis; and a temporary setback for Rob.
*)

(**
## Saturday 25th June
*)

(*** include-value: match39CroatiaVsPortugalHtml ***)

(**
Another less than enthralling game, though credit to Fernando Santos for getting the tactics spot on and stifling Croatian exuberance. Will 
moves up to second; Steve S climbs off the bottom; points also for Hugh and Rob. Neph loses his coach/team and several players (though Mario 
Mandzukic is no great loss).
*)

(*** include-value: match38WalesVsNorthernIrelandHtml ***)

(**
Fuck all to say about that; terrible game. Josh splutters back into life and returns to the top three, although only 24 points separate the 
top six.
*)

(*** include-value: match37SwitzerlandVsPolandHtml ***)

(**
Things looked ominous for Poland after a sublime goal from Xherdan Shaqiri - until an atrocious Granit Xhaka penalty, that is. Pretty much a 
clean sweep for Denis, though the Polish win is enough to take Will third, just a point ahead of Denis. Hugh loses his coach/team.
*)

(**
## Wednesday 22nd June
*)

(*** include-value: groupESwedenVsBelgiumHtml ***)

(*** include-value: groupEItalyVsRepublicOfIrelandHtml ***)

(**
Even more late drama as Ireland join Belgium in the knockout phase, with Sweden and Turkey heading home. Steve M retakes the lead; Jem 
returns to the top three; Rob continues his climb towards mid-table obscurity.

So, with 36 games gone (and only 15 to go), Steve M leads Neph by 2 points at the top of the table, with defending champion Jem in third and 
Josh and Will not far behind; Denis (who must be wishing he'd picked the Irish team rather than the Russian one), Hugh, Rob, Susie and Chris 
will be hoping for better things over the coming fortnight; and Rosie leads Steve S by a solitary point in the battle to avoid the wooden 
spoon.

Only Josh and Denis have lost their coach/team so far (Austria and Russia respectively) - though with Switzerland vs Poland, Croatia vs 
Portugal and Italy vs Spain coming up, at least three sweepstakers will be bereft before the quarter-finals. (And if Ireland, Slovakia, 
Hungary and Iceland all win, only three sweepstakers will still have a coach/team; seems a tad unlikely, I'll admit.)

And only Neph, Denis and Rob still have a full complement of players - but again, the picture will doubtless look very different by the time 
the England vs Iceland match has finished next Monday evening.

By the way, if you'd picked Wales (Chris Coleman), Yann Sommer (Switzerland), Wes Hoolahan (Ireland), Gareth McAuley (Northern Ireland), 
Emanuele Giaccherini (Italy), Robbie Brady (Ireland), Axel Witsel (Belgium), Bogdan Stancu (Romania), Balazs Dzsudzsak (Hungary), Joe 
Allen (Wales), Laszlo Kleinheisler (Hungary) and Kari Arnason (Iceland), you'd have amassed 305 points so far ;)

Barring any squad changes, that's all until Saturday...
*)

(*** include-value: groupFHungaryVsPortugalHtml ***)

(*** include-value: groupFIcelandVsAustriaHtml ***)

(**
"He's almost like a hummingbird..."

An eventful conclusion to group F finishes with yet another late goal, which means that England will play Iceland next Monday - and Croatia 
will face Portugal on Saturday evening. Hungary top the group and will play Belgium, Ireland or Sweden; Austria are eliminated (as are 
Albania); Turkey are still waiting to hear their fate.

A bumper haul takes Will up to fourth, just two points behind Josh; Jem also keeps the top three in his sights; not a lot for anyone else.
*)

(**
## Tuesday 21st June
*)

(*** include-value: groupDCroatiaVsSpainHtml ***)

(*** include-value: groupDCzechRepublicVsTurkeyHtml ***)

(**
Well, another late goal has put the cat amongst the pigeons. (It really has, as Glenn Hoddle would say.) Spain's reward for their lassitude 
is a knockout match against Italy (with both teams in the same half of the draw as England, France and Germany); Croatia will find out their 
next opponents as the group stages conclude tomorrow. Turkey could yet qualify for the knockout phase; Northern Ireland have definitely done 
so.

In the sweepstake, Neph tops the table for the first time as his Croatian gamble pays off handsomely; Hugh hauls himself back into contention; 
Chris keeps moving in the right direction; scraps for Rob and Will; and Jem slips back as a result of Sergio Ramos missing a penalty that 
should probably never have been given.
*)

(*** include-value: groupCNorthernIrelandVsGermanyHtml ***)

(*** include-value: groupCUkraineVsPolandHtml ***)

(**
Routine wins (and third consecutive clean sheets) for Germany and Poland see them through to the knockout phase; Northern Ireland may yet 
join them. Steve M retakes the lead; Denis moves up to fourth; points also for Will, Rosie, Susie and Neph.
*)

(**
## Monday 20th June
*)

(*** include-value: groupBSlovakiaVsEnglandHtml ***)

(*** include-value: groupBRussiaVsWalesHtml ***)

(**
Wales top the group after brushing a sorry Russia aside, meaning that Denis is the first sweepstaker to lose his coach/team; England will find 
out on Wednesday evening whether another meeting with Portugal awaits next Monday. (Perhaps Cristiano Ronaldo will get sent off against 
Hungary...) Another goal for Gareth Bale takes Josh back to the top of the table; Neph storms up to fourth; little of note for anyone else.
*)

(**
## Sunday 19th June
*)

(*** include-value: groupASwitzerlandVsFranceHtml ***)

(*** include-value: groupARomaniaVsAlbaniaHtml ***)

(**
Not the most exciting Sunday evening fare as France maintain their record of not conceding in Lille since 1914 and Albania deservedly finish 
third in the group (though that might not be enough to see them through to the knockout phase). Rob moves into the top half of the table; Hugh 
and Jem also pick up some snore-draw points.
*)

(**
## Saturday 18th June
*)

(*** include-value: groupFPortugalVsAustriaHtml ***)

(**
Marvellous. No goals and not a lot of sweepstake points either - but a delicious helping of _schadenfreude_.
*)

(*** include-value: groupFIcelandVsHungaryHtml ***)

(**
Disappointment for Iceland - and widespread disbelief at the man-of-the-match award that takes Steve M back to the top of the table.
*)

(*** include-value: groupEBelgiumVsRepublicOfIrelandHtml ***)

(**
A straightforward victory for Belgium, aided by Ciaran 'Calamity' Clark - and with Toby Alderweireld lucky to stay on the pitch. Mixed feelings 
for Denis, no doubt, as he moves up to fourth; Jem and Steve M are snapping at Josh's heels.
*)

(**
## Friday 17th June
*)

(*** include-value: groupDSpainVsTurkeyHtml ***)

(**
Spain's strikers find their scoring touch as the peerless Andres Iniesta orchestrates a comprehensive victory. Jem moves up to second; Susie 
keeps the pressure on the top three; Chris storms up to fifth; and Rob finds himself back in familiar territory at the foot of the table.

Still, things can change very quickly, as we've seen - and with plenty of games to go (some would say too many), there's hope for everyone...
*)

(*** include-value: groupDCzechRepublicVsCroatiaHtml ***)

(**
Croatia will be wondering how they failed to win that match - but may have bigger things to worry about. Nearly-but-not-quite for Neph; 
defending champion Jem consolidates his place in the top three; Hugh moves ahead of Rosie.
*)

(*** include-value: groupEItalyVsSwedenHtml ***)

(**
Note-to-self: don't bother tuning in until late in the second half during Platini's bloated group stages. Rob gets a much-needed boost; points 
also for Susie, Josh and Chris; Neph needs some Croatian magic post-haste (although the wooden spoon may be the best he can hope for now).
*)

(**
## Thursday 16th June
*)

(*** include-value: groupCGermanyVsPolandHtml ***)

(**
A bore draw brings clean sheet points to the fore, with Denis and Susie joining the chasing pack. Will sneaks up to fourth; Rob and Rosie 
slip into reverse.
*)

(*** include-value: groupCUkraineVsNorthernIrelandHtml ***)

(**
Good game - though, if you'll forgive the parochialism, with no great significance for the sweepstake.
*)

(*** include-value: groupBEnglandVsWalesHtml ***)

(**
Another late, late show leaves England and Wales both odds-on to get knocked out in the round of sixteen. Points for half of the 
sweepstakers, with Josh and Steve M leading the way.
*)

(**
## Wednesday 15th June
*)

(*** include-value: groupAFranceVsAlbaniaHtml ***)

(**
An eventful end to the match sees Steve M and Jem rise to second and third respectively; points also for Rosie, Rob and Chris.
*)

(*** include-value: groupARomaniaVsSwitzerlandHtml ***)

(**
The Granit Xhaka fan club appears to have rigged the man-of-the-match voting. Josh won't be complaining as he extends his lead; Hugh lurches 
unsteadily forwards.
*)

(*** include-value: groupBRussiaVsSlovakiaHtml ***)

(**
I've always liked the name Marek - as, one suspects, does Steve S right now.
*)

(**
## Tuesday 14th June
*)

(*** include-value: groupFPortugalVsIceland ***)

(**
Yep, you read that right: Nani was voted man-of-the-match. Time to end the disastrous democratic experiment... Jem storms up to third; Steve 
S keeps chugging along.
*)

(*** include-value: groupFAustriaVsHungaryHtml ***)

(**
Unfancied Hungary send the dark horses of Austria a step closer to the glue factory. Only Josh scores points - and negative ones at that.
*)

(**
## Monday 13th June
*)

(*** include-value: groupEBelgiumVsItalyHtml ***)

(**
Impressive stuff from Italy, albeit against a somewhat inchoate Belgian side. Josh extends his lead; Susie and Hugh move into the top half of 
the table; Steve M drops points but remains third; and Rob finds himself back where he started.
*)

(*** include-value: groupERepublicOfIrelandVsSwedenHtml ***)

(**
Nothing much to see here - though following a late clarification of the rules (i.e. that assists can be scored for own goals), Hugh scrapes up a 
few more points.
*)

(*** include-value: groupDSpainVsCzechRepublicHtml ***)

(**
The class of Andres Iniesta eventually does the trick for Spain against a resolute Czech defence, with the result that Susie and Chris haul 
themselves towards respectability; Josh retakes the lead; Jem also moves in the right direction.
*)

(**
## Sunday 12th June
*)

(*** include-value: groupCGermanyVsUkraineHtml ***)

(**
Excellent performances from Toni Kroos and Manuel Neuer see Denis climb the table; the German win keeps Steve M in third; Steve S picks up his 
first points since the opening game; and Rosie continues to eke out the assists.
*)

(*** include-value: groupCPolandVsNorthernIrelandHtml ***)

(**
Northern Ireland's brave attempt to win the tournament without conceding or scoring a goal fails at the first hurdle - largely to Will's benefit, 
though points also for Rosie and Denis.
*)

(*** include-value: groupDTurkeyVsCroatiaHtml ***)

(**
Like England, Croatia will be wondering how they only scored a single goal; unlike England, the profligacy doesn't cost them. Will races up to third.
*)

(**
## Saturday 11th June
*)

(*** include-value: groupBEnglandVsRussiaHtml ***)

(**
_Fantais Cymru?_

Josh storms into the lead; scraps from the table for Rosie, Denis and Susie.
*)

(*** include-value: groupBWalesVsSlovakiaHtml ***)

(**
A deserved win for Wales sees Neph off the mark and more points for Josh.

Now to see if Roy Hodgson can shuffle his pack as well as Chris Coleman...
*)

(*** include-value: groupAAlbaniaVsSwitzerlandHtml ***)

(**
Early days, of course - but Josh moves up to second thanks to Granit Xhaka; Hugh and Denis also open their accounts.

### Final picks

Susie has picked Roman Zozulya (Ukraine) as her final player.

## Friday 10th June
*)

(*** include-value: groupAFranceVsRomaniaHtml ***)

(**
A fine performance from Dimitri Payet in a decent-enough opening game sees Steve M take the early lead, with points also scored by Jem, Steve S, Rob and Rosie.

Only fifty more games to go...

### Second draft results

**The second draft has been processed.** See [here](draft.html#Draft 2 picks) for the full details - or just click your name above to see how things worked out for you.

Almost everyone now has a full team, though Susie still needs to pick 1 more outfield player.

Good luck folks ;)

## Wednesday 8th June

### Released players

The following players have been released as surplus to requirements following the first draft:

 - Hugh no longer wants Selcuk Inan (Turkey)
 - Rosie no longer wants Oguzhan Ozyakup (Turkey), Ondrej Duda (Slovakia) or Marcel Sabitzer (Austria)
 - Steve M no longer wants Jerome Boateng (Germany) or Leonardo Bonucci (Italy)
 - Steve S no longer wants Ashley Williams (Wales), Vlad Chiriches (Romania) or Juanfran (Spain)

### Squad changes

**Russia**: Igor Denisov has been replaced by Artur Yusupov.

**Germany**: Antonio Rudiger has been replaced by Jonathan Tah.

## Monday 6th June

### First draft results

**The first draft has been processed.** See [here](draft.html#Most popular draft 1 picks) for the full details - or just click your name above to see how things worked out for you.

#### Payout structure

The following payout structure has been agreed:

 - Sixty quid for first place
 - Thirty quid for second place
 - Twenty quid for third place
 - Ten quid for the "wooden spoon"

## Friday 3rd June

### Squad changes

**France**: Lassana Diarra has been replaced by Morgan Schneiderlin.

## Tuesday 31st May

So, eighteen years after the 1998 World Cup, it's time for another major football tournament in France - and therefore time for another sweepstake ;)

Entry into the sweepstake costs a tenner. The payout structure will be confirmed once the number of entrants is known - and yes, there will hopefully be a "wooden spoon" prize.

### Scoring summary

Each sweepstake team will consist of a team/coach, 1 goalkeeper and 10 outfield players.

The team/coach will score points for winning or drawing matches - but lose points for yellow and red cards received by its players (irrespective of whether those players are part of the 
sweepstake team, e.g. if you have picked France as your team, you will lose points for cards received by _any_ French team players during the tournament).

The outfield players and goalkeeper will score points for scoring goals / penalties, assisting goals, winning penalties, keeping a clean sheet, saving penalties and being named man-of-the-match - 
but lose points for receiving yellow and red cards, missing penalties and scoring own goals.

As always, goals / penalties / assists / &c. only count during normal time and extra time. **Penalty shootouts do not contribute to the scoring.**

Please see the [scoring](scoring.html) page for more details.

#### A brief note on replacements

Once the tournament is underway, if one of your players is withdrawn, I'll try and let you know (or you can let me know).

You can then pick any unpicked player as a replacement (subject to the restriction on having a single goalkeeper) - with the proviso that you will only be credited with points that they score from 
that point onwards. (If there's a sudden spate of withdrawals, replacements will be allocated on a first-come first-served basis.)

Please note that a player who is unavailable for disciplinary reasons cannot be replaced.

#### Source code
If anyone wants to check that the drafting algorithm is above board, please feel free to take a look at 
[all of the code](https://github.com/aornota/sweepstake.2016).
*)

(*** include-value: indexDetailHtml ***)

