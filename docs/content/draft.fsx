(*** hide ***)
#I "../../src/Sweepstake.2016/bin/Release"

#r "Sweepstake.2016.dll"
open AOrNotA.Sweepstake2016.Content
open AOrNotA.Sweepstake2016.DraftContent

let lastUpdated = getLastUpdated ()
let draft2Html = getDraft2Html ()
let draft1Html = getDraft1Html ()

(**
Draft details
=============
*)

(*** include-value: lastUpdated ***)

(*** include-value: draft2Html ***)

(*** include-value: draft1Html ***)

