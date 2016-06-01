(*** hide ***)
#I "../../src/Sweepstake.2016/bin/Release"

#r "Sweepstake.2016.dll"
open AOrNotA.Sweepstake2016.Content
open AOrNotA.Sweepstake2016.IndexContent

let lastUpdated = getLastUpdated ()
let indexStandingsAndLinksHtml = getIndexStandingsAndLinksHtml ()
let indexHtml = getIndexHtml ()

(**
Latest news
===========
*)

(*** include-value: lastUpdated ***)

(**
## Wednesday 1st June

Complete squad lists now available [here](teams.html).

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

### Draft process summary

Sweepstake teams will be picked by a series of drafts.

For each draft, sweepstakers will submit an **ordered** list of their choices (which can be any combination of teams/coaches, goalkeepers and outfield players) by e-mail - and a drafting algorithm 
will figure out who gets what.

(The algorithm is best explained by example, so please see this [test example](draft.html).)

Depending on the number of entrants (and the extent to which everyone tries to pick the same players &c.), it is anticipated that two or three drafts will be required, as per the following 
**provisional** schedule:

 - First draft picks will need to be submitted by 22:00 BST on Sunday 5th June
 - Second draft picks will need to be submitted by 16:00 BST on Thursday 9th June
 - Third draft picks (if required) will need to be submitted by 19:00 BST on Friday 10th June

This schedule - and a suggestion of how many choices to submit for each draft - will be confirmed in due course. (For now, assume that for the first draft, you should be aiming to submit a list of 
25 to 30 choices - or even more if you wish.)

#### A brief note on replacements

Once the tournament is underway, if one of your players is withdrawn, I'll try and let you know (or you can let me know).

You can then pick any unpicked player as a replacement (subject to the restriction on having a single goalkeeper) - with the proviso that you will only be credited with points that they score from 
that point onwards. (If there's a sudden spate of withdrawals, replacements will be allocated on a first-come first-served basis.)

Please note that a player who is unavailable for disciplinary reasons cannot be replaced.

#### Payout structure

**To be confirmed...**

#### Source code
If anyone wants to check that the drafting algorithm is above board, please feel free to take a look at 
[all of the code](https://github.com/aornota/sweepstake.2016).
*)

(**
## This is _**temporary test data**_ only...
*)

(*** include-value: indexStandingsAndLinksHtml ***)

(*** include-value: indexHtml ***)

