// http://www.codeproject.com/Articles/8199/Poker-logic-in-C

open System
open System.Collections.Generic

type Rank = Ace = 1 | Two = 2 | Three = 3 | Four = 4 | Five = 5 | Six = 6 | Seven = 7 | Eight = 8 | Nine = 9 | Ten = 10 | Jack = 11 | Queen = 12 | King = 13
type Suit = Heart = 1 | Spade = 2 | Diamond = 3 | Club = 4

type Card(rank:Rank, suit:Suit) =
    member this.Rank = rank
    member this.Suit = suit
    override this.ToString() =  String.Format("{0} of {1}s", this.Rank, this.Suit)

type Deck() =
    let cards = 
        let suits : seq<Suit> = Seq.cast(Enum.GetValues(typeof<Suit>))
        let ranks : seq<Rank> = Seq.cast(Enum.GetValues(typeof<Rank>))
        let stack = new Stack<Card>()

        suits |> Seq.collect (fun(s) -> ranks |> Seq.map(fun(r) -> new Card(r, s))) |> Seq.sortBy (fun(c) -> Guid.NewGuid()) |> Seq.iter (fun x -> stack.Push(x))

        stack
    
    member this.Deal() = cards.Pop()



let deck = new Deck()
let card = deck.Deal().ToString()

printfn "############# %A ################" card

    
[<EntryPoint>]
let main argv =
    0 // return an integer exit code
