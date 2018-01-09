using System.Collections.Generic;

namespace deck_proj
{
    public class Player
    {
        //properties of the player
        public string name { get;set; }
        public List<Card> hand { get;set; }

        //contstructer function
        public Player(string username)
        {
            name = username;
            hand = new List<Card>();
        }

        //draw method, with parameter requiring which deck player draws from
        public Player Draw(Deck d)
        {
            //player adds drawn card to hand from the deck's Deal method
            Card drawnCard = d.Deal();
            hand.Add(drawnCard);
            //player is returned with updated hand
            return this;
        }

        public void ShowHand()
        {
            System.Console.WriteLine($"{name} has: ");
            //iterates through the hand list
            for(int i = 0; i < hand.Count; i++ )
            {
                System.Console.WriteLine(hand[i]);
            }
        }
        //removes chosen card from hand based on its index
        public void Discard(int i)
        {
            hand.RemoveAt(i);
        }
    }
}