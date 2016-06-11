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
## Tuesday 31st May

Each sweepstake team will consist of a **team/coach**, **1 goalkeeper** and **10 outfield players**.

(Although outfield players have been categorized as defenders, midfielders or forwards, you can choose any combination you like, e.g. if you want to go for eight defenders and two midfielders - the 
no-longer-fashionable [except in Northern Ireland] 8-2-0 formation - please do.)

The **team/coach** will score (or lose) points for:

 - **winning** a match: **20** or **16** or **12** (see below)
 - **drawing** a match: **8** or **6** or **4** (see below)
 - a team player receiving a **yellow card**: **-1**
 - a team player receiving a **red card**: **-3**

(If a player receives a second yellow card in a match, the two yellow cards will be scored as a red card instead; however, if a player receives a yellow card followed by a "straight" red card, both 
cards will be scored.)

Where multiple possible scores are given above, the score will depend on whether the team and their opponents are in the top 12 seeds:

 - if the team **is** a top 12 seed but their opponents are **not**, the **lowest** score will apply
 - if the team is **not** a top 12 seed but their opponents **are**, the **highest** score will apply
 - if **both** teams are top 12 seeds - or if **neither** team is - the **middle** score will apply

Note that the top 12 seeds are (in order): Germany; Spain; England; Portugal; Belgium; Italy; France; Russia; Switzerland; Austria; Croatia; and Ukraine.

(The remaining teams are: Czech Republic; Sweden; Poland; Romania; Slovakia; Hungary; Turkey; Republic of Ireland; Iceland; Wales; Albania; and Northern Ireland.)

**All players** will score (or lose) points for:

 - being named **man-of-the-match**: **15**
 - _**scoring**_ a **goal** or a **penalty**: **12**
 - _**assisting**_ a **goal**: **3** (note that a goal cannot be assisted by the same player who scored the goal - unless they win a free kick and then score directly from it)
 - _**winning**_ a **penalty**: **3** (note that a penalty can be won by the same player who took the penalty)
 - _**missing**_ a **penalty**: **-6**
 - _**scoring**_ an **own goal**: **-6**
 - receiving a **yellow card**: **-2**
 - receiving a **red card**: **-6**

(A penalty will be considered as "missed" irrespective of whether the goalkeeper touched the ball. And again, if a player receives a second yellow card in a match, the two yellow cards will be 
scored as a red card instead; however, if a player receives a yellow card followed by a "straight" red card, both cards will be scored.)

In addition, **goalkeepers** will score points for:

 - keeping a **clean sheet**: **12**
 - _**saving**_ a **penalty**: **12**

Note that outfield players can also score "goalkeeper" points if they end up playing in goal. (It probably won't happen - but you never know...)

(If more than one goalkeeper features for a team in a match, the "clean sheet" points will be awarded to whichever goalkeeper played more "regulation" minutes; if they played the same amount of 
minutes, the points will be shared. A penalty will only be considered as "saved" if the goalkeeper touched the ball.)

Please note that although we intend to score assists as outlined above, this may have to be dropped if reliable data is not freely available. (However, we should be able to cobble the required 
information together from watching games / highlights and reading match reports.)

As always, points can only be scored for goals / penalties / assists / &c. during normal time and extra time. **Penalty shootouts do not contribute to the scoring** [except to the extent 
that they determine who wins the match] - well, unless a player manages to get booked or sent-off during the shootout. Stranger things have happened...
*)

