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

(*** include-value: teamsLinksHtml ***)

(*** include-value: teamsHtml ***)

