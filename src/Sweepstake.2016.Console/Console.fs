namespace AOrNotA.Sweepstake2016

open System

//open AOrNotA.Sweepstake2016.``Data 2011``
open AOrNotA.Sweepstake2016.``Data 2016``
open AOrNotA.Sweepstake2016.Domain
open AOrNotA.Sweepstake2016.DraftContent
open AOrNotA.Sweepstake2016.IndexContent
open AOrNotA.Sweepstake2016.Sweepstake
open AOrNotA.Sweepstake2016.``Sweepstake 2016``
open AOrNotA.Sweepstake2016.TeamsContent

module Console =

    [<EntryPoint>]
    let main argv = 
        
        Console.WriteLine "Work in progress..."

        (* let quarterFinal1PolandVsPortugalHtml = getMatchDetailsHtml quarterFinal1PolandVsPortugal
        Console.WriteLine quarterFinal1PolandVsPortugalHtml *)

        (* let sweepstakers, processHtml = processDraft 1 draft1Seed sweepstakers draft1
        let postDraftHtml = sweepstakersPostDraftHtml 1 sweepstakers

        processHtml |> List.iter (fun line -> Console.WriteLine line)
        postDraftHtml |> List.iter (fun line -> Console.WriteLine line) *)

        (* let playerScores = getTotalScorePerPlayer (players |> List.map (fun player -> player, None)) matches
        let forwards = playerScores |> List.filter (fun (player, _) -> match player.Type with | Back -> false | Forward -> true)
                                    |> List.filter (fun (_, score) -> score <> 0<score>)
                                    (* |> Seq.ofList |> Seq.take 15 |> List.ofSeq *)
        let backs = playerScores |> List.filter (fun (player, _) -> match player.Type with | Back -> true | Forward -> false)
                                 |> List.filter (fun (_, score) -> score <> 0<score>)
                                 (* |> Seq.ofList |> Seq.take 15 |> List.ofSeq *)
        Console.WriteLine "\nScoring forwards:"
        forwards
        |> List.iter (fun (player, score) -> Console.WriteLine (sprintf "\t%s [%s]: %d" player.Name player.Team.Name score))
        Console.WriteLine "\nScoring backs:"
        backs
        |> List.iter (fun (player, score) -> Console.WriteLine (sprintf "\t%s [%s]: %d" player.Name player.Team.Name score))

        let teamScores = getTotalScorePerTeam teams matches
        Console.WriteLine "\nScoring teams:"
        teamScores
        |> List.filter (fun (_, score) -> score <> 0<score>)
        |> List.iter (fun (team, score) -> Console.WriteLine (sprintf "\t%s [%s]: %d" team.Name team.Coach score)) *)

        Console.Write "\nPress any key to exit..."
        Console.ReadKey () |> ignore
        0
