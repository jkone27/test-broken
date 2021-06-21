// cannot see the lib namespace, even though is built
open My.Custom.Lib
open System

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    
    //crashes on this line
    //let x = BigOpenApi.

    0 // return an integer exit code