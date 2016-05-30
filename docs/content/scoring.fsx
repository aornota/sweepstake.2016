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
## Monday 30th May

**Please note that the following is all subject to confirmation...**

Each sweepstake team will consist of a **team/coach**, **1 goalkeeper** and **10 outfield** players.

(Although outfield players have been categorized as defenders, midfielders or forwards, you can choose eight defenders and two midfielders - the no-longer-fashionable 8-2-0 formation - if 
you so wish.)

The **team/coach** will score (or lose) points for:

 - **winning** a match: **10** or **8** or **6** (see below)
 - **drawing** a match: **5** or **4** or **3** (see below)
 - a team player receiving a **yellow card**: **-1**
 - a team player receiving a **red card**: **-3**

(If a player receives a second yellow card in a match, this will be scored as a red card instead; however, if a player receives a yellow card followed by a "straight" red card, both will be scored.)

Where multiple possible scores are given above, the score will depend on whether the team and their opponents are in the top 12 seeds:

 - if the team **is** a top 12 seed but their opponents are **not**, the **lowest** score will apply
 - if the team is **not** a top 12 seed but their opponents **are**, the **highest** score will apply
 - if **both** teams are top 12 seeds - or if **neither** team is - the **middle** score will apply

Note that the top 12 seeds are (in order): Germany; Spain; England; Portugal; Belgium; Italy; France; Russia; Switzerland; Austria; Croatia; and Ukraine.

(The remaining teams are: Czech Republic; Sweden; Poland; Romania; Slovakia; Hungary; Turkey; Republic of Ireland; Iceland; Wales; Albania; and Northern Ireland.)

**All players** will score (or lose) points for:

 - being named **man-of-the-match**: **10**
 - _**scoring**_ a **goal**: **8**
 - _**assisting**_ a **goal**: **2**
 - _**scoring**_ a **penalty**: **8**
 - _**winning**_ a **penalty**: **2**
 - _**missing**_ a **penalty**: **-4**
 - _**scoring**_ an **own goal**: **-4**
 - receiving a **yellow card**: **-2**
 - receiving a **red card**: **-6**

(A penalty will be considered as "missed" irrespective of whether the goalkeeper touched the ball. And again, if a player receives a second yellow card in a match, this will be scored as a red card 
instead; however, if a player receives a yellow card followed by a "straight" red card, both will be scored.)

In addition, **goalkeepers** will score points for:

 - keeping a **clean sheet**: **8**
 - _**saving**_ a **penalty**: **8**

(If more than one goalkeeper features for a team in a match, the "clean sheet" points will be awarded to whichever goalkeeper played more minutes; if they played the same amount of regulation time,
the points will be shared. A penalty will only be considered as "saved" if the goalkeeper touched the ball.)

Please note that although we intend to score assists as outlined above, this may have to be dropped if reliable data is not freely available.

As always, points can only be scored for goals / assists / penalties / &c. during normal time and extra time. **Penalty shootouts do not contribute to the scoring** (except to the extent 
that they determine who wins the match) - well, unless a player manages to get booked or sent-off during the shootout...

*)

