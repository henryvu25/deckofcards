using System;

namespace deck_proj
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            System.Console.WriteLine(newDeck.Deal());
            // foreach(Card card in newDeck.cards)
            // {
            //     System.Console.WriteLine(card);
            // }
            foreach(Card discarded in newDeck.discardPile)
            {
                System.Console.WriteLine(discarded);
            }
        }
    }
}
