(*** hide ***)
#I "../../src/Sweepstake.2016/bin/Release"

#r "Sweepstake.2016.dll"
open AOrNotA.Sweepstake2016.Content
open AOrNotA.Sweepstake2016.IndexContent

let lastUpdated = getLastUpdated ()
//let indexStandingsAndLinksHtml = getIndexStandingsAndLinksHtml ()
//let indexHtml = getIndexHtml ()

(**
Latest news
===========
*)

(*** include-value: lastUpdated ***)

(**
## Please note that any data on this page is _**temporary test data**_ only...

## Monday 30th May

So, eighteen years after the 1996 World Cup, it's time for another major football tournament in France - and therefore time for another sweepstake ;)

Please note that the final squads should be known by the end of Tuesday 31st May.

It is anticipated that two or three drafts will be required, as outlined in this **provisional** schedule:

 - First draft picks will need to be submitted by 22:00 BST on Sunday 5th June
 - Second draft picks will need to be submitted by 16:00 BST on Thursday 9th June
 - Third draft picks (if required) will need to be submitted by 19:00 BST on Friday 10th June

**More information to follow...**

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

