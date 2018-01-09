using System;
using System.Collections.Generic;

namespace deck_proj
{
    public class Deck
    {
        //deck properties
        public List<Card> cards { get; set; }
        public List<Card> discardPile { get; set; }

        //constructor function
        public Deck()
        {
            discardPile = new List<Card>();
            Reset();
            Shuffle();
        }

        //resets the deck: like opening a new pack of cards
        public void Reset()
        {
            cards = new List<Card>();
            string[] suits = { "Spades", "Clubs", "Diamonds", "Hearts" };
            //values 1-13
            for (int v = 1; v < 14; v++)
            {
                foreach (string s in suits)
                {
                    cards.Add(new Card(v, s));
                }
            }
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for(int i = 0; i < cards.Count; i++)
            {
                //switches card at index with random card in deck
                int x = rand.Next(0,cards.Count);
                Card temp = cards[x];
                cards[x] = cards[i];
                cards[i] = temp;
            }
        }

        public Card Deal()
        {
            if(cards.Count == 0)
            {
                Reset();
                Shuffle();
            }
            //removes card from deck and returns it to user
            Card dealt = cards[0];
            cards.RemoveAt(0);
            return dealt;
        }


    }
}