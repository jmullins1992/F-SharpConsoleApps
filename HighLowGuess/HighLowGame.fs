namespace HighLowGuess

//an object-oriented High Low Guess Game in F#
module HiLo =
    type HighLowGame() =
        let Randall = new System.Random()
        let Value = Randall.Next(0,100)

        member this.Guess x =
            match x with
            | _ when x > Value -> (false, "Too high! ")
            | _ when x < Value -> (false, "Too low! ")
            | _ when x = Value -> (true, "You got it! ")
            | a -> (false, "Error")
        
        


        

