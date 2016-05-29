namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Sweepstake.2016.Console")>]
[<assembly: AssemblyProductAttribute("Sweepstake.2016")>]
[<assembly: AssemblyDescriptionAttribute("The world-famous Euro 2016 sweepstake")>]
[<assembly: AssemblyVersionAttribute("0.0.1")>]
[<assembly: AssemblyFileVersionAttribute("0.0.1")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.1"
    let [<Literal>] InformationalVersion = "0.0.1"
