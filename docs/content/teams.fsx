(*** hide ***)
#I "../../src/Sweepstake.2016/bin/Release"

#r "Sweepstake.2016.dll"
open AOrNotA.Sweepstake2016.Content
open AOrNotA.Sweepstake2016.TeamsContent

let lastUpdated = getLastUpdated ()
let teamsLinksHtml = getTeamsLinksHtml ()
let teamsHtml = getTeamsHtml ()

(**
Teams and fixtures/results
==========================
*)

(*** include-value: lastUpdated ***)

(**
## This is _**temporary test data**_ only...
*)

(**
Please note that the final squads should be known by the end of Tuesday 31st May.
*)

(*** include-value: teamsLinksHtml ***)

(*** include-value: teamsHtml ***)

