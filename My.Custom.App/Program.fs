// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp
open My.Custom.Lib
open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    
    let x = PetsProvided.GetSamples()

    0 // return an integer exit code