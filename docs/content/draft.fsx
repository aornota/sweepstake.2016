(*** hide ***)
#I "../../src/Sweepstake.2016/bin/Release"

#r "Sweepstake.2016.dll"
open AOrNotA.Sweepstake2016.Content
open AOrNotA.Sweepstake2016.DraftContent

let lastUpdated = getLastUpdated ()
// TODO (if needed): let draft2Html = getDraft2Html ()
let draft1Html = getDraft1Html ()

(**
Draft details
=============
*)

(*** include-value: lastUpdated ***)

(**
## Please note that any data on this page is _**temporary test data**_ only...

## Monday 30th May

Coming soon...
*)

(*** include-value: draft1Html ***)

