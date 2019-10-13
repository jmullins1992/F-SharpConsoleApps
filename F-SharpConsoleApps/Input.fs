//Some easy methods to get typed values from the user
module Input

open System

let GetString prompt =
    printf prompt
    Console.ReadLine()

let GetInt prompt =
    let mutable response = -1
    let mutable continueLooping = true
    while continueLooping do
        printf prompt
        let userResponse = Console.ReadLine()
        match (System.Int32.TryParse(userResponse)) with
        | (true, value) -> (response <- value; continueLooping <- false)
        | (false, _) -> printfn "Enter an integer value. "
    response

let GetBool prompt =
    let mutable response = false
    let mutable continueLooping = true
    while continueLooping do
        printfn prompt
        let userResponse = Console.ReadLine()
        match (System.Boolean.TryParse(userResponse)) with
        | (true, value) -> response <- value; continueLooping <- false
        | (false, _) -> printfn "Enter a boolean value. "
    response