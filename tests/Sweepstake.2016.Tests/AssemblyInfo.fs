namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("Sweepstake.2016.Tests.NUnit")>]
[<assembly: AssemblyProductAttribute("Sweepstake.2016")>]
[<assembly: AssemblyDescriptionAttribute("The world-famous Euro 2016 sweepstake")>]
[<assembly: AssemblyVersionAttribute("0.1.0")>]
[<assembly: AssemblyFileVersionAttribute("0.1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.1.0"
