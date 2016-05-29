(*** hide ***)
#I "../../src/Sweepstake.2016/bin/Release"

#r "Sweepstake.2016.dll"
open AOrNotA.Sweepstake2016.Content

let lastUpdated = getLastUpdated ()

(**
Scoring system
==============
*)

(*** include-value: lastUpdated ***)

(**
## Sunday 29th May

Coming soon...
*)



(**
# Previous content...

Each sweepstake team will consist of a **team/coach**, 8 **forwards** and 7 **backs**.

The **team/coach** will score (or lose) points for:

 - **winning** a match: **10** or **8** or **6** (see below)
 - **drawing** a match: **5** or **4** or **3** (see below)
 - per **bonus point** earned: **3** or **2** or **1** (see below)
 - the team scoring a **penalty try**: **6**
 - a team player receiving a **yellow card**: **-2**
 - a team player receiving a **red card**: **-4**

Where multiple possible scores are given above, the score will depend on whether the team and their opponents are in the top 8 seeds:

 - if the team **is** a top 8 seed but their opponents are **not**, the **lowest** score will apply
 - if the team is **not** a top 8 seed but their opponents **are**, the **highest** score will apply
 - if **both** teams are top 8 seeds - or if **neither** team is - the **middle** score will apply

The team can earn _up to two_ bonus points (weighted as outlined above) for:

 - scoring 4 or more tries in a match
 - losing by 7 points or fewer

The **forwards** and **backs** will score (or lose) points for:

 - being named **man-of-the-match**: **10**
 - scoring a **try**: **9**
 - kicking a **drop goal** or **penalty**: **3**
 - kicking a **conversion**: **2**
 - _**missing**_ a **conversion**: **-1**
 - _**missing**_ a **penalty**: **-2**
 - receiving a **yellow card**: **-3**
 - receiving a **red card**: **-6**

*)

