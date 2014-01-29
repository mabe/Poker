// http://www.codeproject.com/Articles/8199/Poker-logic-in-C
// http://forums.udacity.com/questions/5014007/c-version-of-the-poker-game-pokerpy

open System
open System.Collections.Generic



type Hand = HighCard | OnePair | TwoPair | ThreeOfAKind | Straight | Flush | FullHouse | FourOfAKind | StraightFlush
type Rank = Ace = 1 | Two = 2 | Three = 3 | Four = 4 | Five = 5 | Six = 6 | Seven = 7 | Eight = 8 | Nine = 9 | Ten = 10 | Jack = 11 | Queen = 12 | King = 13
type Suit = Heart = 1 | Spade = 2 | Diamond = 3 | Club = 4

type Card(rank:Rank, suit:Suit) =
    member this.Rank = rank
    member this.Suit = suit
    override this.ToString() =  String.Format("{0} of {1}s", this.Rank, this.Suit)

type Player() =
    let flush = fun(cards:list<Card>) -> 
        let cards = cards |> List.map (fun(x) -> x.Suit)
        cards |> List.map (fun(x) -> if Seq.head cards = x then true else false) |> Seq.exists (fun(x) -> x = false) |> not
    let straight = fun(cards:list<Card>) -> 
        let cards = cards |> List.map (fun(x) -> int(x.Rank)) |> List.sort
        if (cards = [1;10;11;12;13]) then
            true
        else
            cards |> List.mapi(fun i x -> int (Seq.head(cards)) + i = int (x)) |> List.exists (fun(x) -> x = false) |> not
    let kind = fun(cards:list<Card>, n) ->
        cards |> Seq.groupBy (fun(x) -> x.Rank) |> Seq.map (fun (key, group) -> Seq.length group) |> Seq.exists (fun(x) -> x = n)
    member this.Hand(cards:list<Card>) = 
        if flush(cards) && straight(cards) then
            Hand.StraightFlush
        elif kind(cards, 4) then
            Hand.FourOfAKind
        elif flush(cards) then
            Hand.Flush
        elif straight(cards) then
            Hand.Straight
        elif kind(cards, 3) then
            Hand.ThreeOfAKind
        else
            Hand.HighCard 

type Deck() =
    let cards =
        let stack = seq {
                for s in Seq.cast<Suit>(Enum.GetValues(typeof<Suit>)) do
                for r in Seq.cast<Rank>(Enum.GetValues(typeof<Rank>)) do
                yield new Card(r, s) } |> Seq.sortBy (fun(c) -> Guid.NewGuid())

        new Stack<Card>(stack)
    
    member this.Deal() = cards.Pop()



let deck = new Deck()
let cards = [deck.Deal();deck.Deal();deck.Deal();deck.Deal();deck.Deal()] 
let player = new Player()
let hand = player.Hand(cards)

//printfn "############# %A ################" hand

//    
//[<EntryPoint>]
//let main argv =
//    0 // return an integer exit code
