(*** hide ***)
#I "../../src/Sweepstake.2016/bin/Release"

#r "Sweepstake.2016.dll"
open AOrNotA.Sweepstake2016.Content
open AOrNotA.Sweepstake2016.``Data 2016``
open AOrNotA.Sweepstake2016.IndexContent

let lastUpdated = getLastUpdated ()
let indexSummaryAndLinksHtml = getIndexSummaryAndLinksHtml ()
let upcomingFixturesHtml = getUpcomingFixturesHtml 3

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
