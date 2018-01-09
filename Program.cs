using System;

namespace deck_proj
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //instatiate a new deck
            Deck newDeck = new Deck();
            //deal a card out and print it
            System.Console.WriteLine(newDeck.Deal());
            //instatiate a player
            Player henry = new Player("Henry");
            //have player draw two cards
            henry.Draw(newDeck).Draw(newDeck);
            //print all the cards not drawn yet
            foreach(Card card in newDeck.cards)
            {
                System.Console.WriteLine(card);
            }
            //print all the cards in player's hand (the two cards drawn above)
            foreach(Card card in henry.hand)
            {
                System.Console.WriteLine(card);
            }
            //using built in method to show the hand
            henry.ShowHand();
            //discards from hand at the index provided
            henry.Discard(0);
            //shows hand again to show difference
            henry.ShowHand();
            

        }
    }
}
