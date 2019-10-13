// A simple catalog of f-sharp test projects to learn the language
open Input
open Say
open HighLowGuess

let HighLowGuessGame () = 
    let game = new HiLo.HighLowGame()
    let mutable continueLooping = true
    while continueLooping do
        let userResponse = Input.GetInt("What is your guess? ")
        match game.Guess(userResponse) with
        | (true, message) -> printf "%s" message; continueLooping <- false
        | (false, message) -> printf "%s" message; 
    0

let displayCatalog () = 
    printfn "Please select from one of our options. "
    printfn "1. Hello World!"
    printfn "2. High Low Guess Game!"
    printfn "0. Exit"
    let userChoice = Input.GetInt("Please select your choice by number: ")
    match userChoice with
    | _ when userChoice = 0 -> false
    | _ when userChoice = 1 -> GetString("Enter your name: ") |> hello; true
    | _ when userChoice = 2 -> HighLowGuessGame() |> ignore; true
    | a -> printfn "Please select from the options provided."; true

[<EntryPoint>]
let main argv =
    printf "Welcome to Jerry's F-Sharp Showcase! "
    let mutable continueLooping = true
    while continueLooping do 
        let x = displayCatalog()
        if not x then
            continueLooping <- false
    0 // return an integer exit code
