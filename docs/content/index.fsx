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

(*** include-value: indexStandingsAndLinksHtml ***)

(**
## Monday 6th June

**The first draft has been processed.** See [here](draft.html) for the full details - or just click your name above to see how things worked out for you.

(As expected, the folks who submitted the longest lists - and/or included less popular choices - have generally ended up with a full team.)

_**Please note that if you want to change your mind**_ and release some of your picks before the second draft - e.g. because you've ended up with too many defenders and would prefer to ditch some of 
these and take your chances in the second draft instead - you can do so: just e-mail djnarration@gmail.com by 22:00 BST on Tuesday 7th June.

### Second draft

For those that need them - i.e. everyone except Denis, Josh, Neph and Steve M (unless they decide to release some of their first draft picks, as mentioned above) - **second draft picks should be 
submitted by 16:00 BST on Thursday 9th June**.

More specifically:

 - Chris needs to pick a goalkeeper and 4 outfield players
 - Hugh needs to pick a team/coach
 - Jem needs to pick a goalkeeper and 2 outfield players
 - Rob needs to pick 6 outfield players
 - Rosie needs to pick a goalkeeper
 - Steve S needs to pick 2 outfield players
 - Susie needs to pick a goalkeeper and 5 outfield players
 - Will needs to pick 4 outfield players

As a rough guide, please submit a list at least twice as long as the number of players you need. (We will have time for a third draft on Friday if needs be - but hopefully this won't be required: we 
should be through the worst of the everyone-trying-to-pick-the-same-players phase.)

You can see which players are still available on the [teams page](teams.html). (And it looks like Russia's Igor Denisov is injured, so don't pick him; his replacement will be confirmed in due 
course...)

#### Payout structure

The following payout structure has been agreed:

 - Sixty quid for first place
 - Thirty quid for second place
 - Twenty quid for third place
 - Ten quid for the "wooden spoon"

## Friday 3rd June

Okay, we're still looking at a deadline of 22:00 BST on Sunday 5th June for your first draft picks. Please e-mail these to **djnarration@gmail.com**. (Don't worry: I won't look at them until I've 
made my own choices.)

As previously mentioned, we'd suggest submitting an **ordered** list of 25 to 30 choices for the first draft.

Please note that these choices can include more than one team/coach and more than one goalkeeper: if an earlier pick is successful, the later picks will just be ignored.

(And if you want to pick Eder, bear in mind that there are players with this name in both the Italian and Portuguese squads.) 

So, for example, something like this:

1. Germany (Joachim Low)
2. Antoine Griezmann (France)
3. Gareth Bale (Wales)
4. Gianluigi Buffon (Italy; goalkeeper)
5. Robert Lewandowski (Poland)
6. Norbert Gyomber (Slovakia)
7. Igor Akinfeev (Russia; goalkeeper)
8. Hungary (Bernd Storck)
9. David Alaba (Austria)
10. 'Broadway' Danny Rose (England)
11. Toby Alderweireld (Belgium)
12. Gylfi Sigurdsson (Iceland)
13. (and so on...)

### Squad changes

France: Lassana Diarra has been replaced by Morgan Schneiderlin.

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

#### Source code
If anyone wants to check that the drafting algorithm is above board, please feel free to take a look at 
[all of the code](https://github.com/aornota/sweepstake.2016).
*)

(*** include-value: indexHtml ***)

