namespace deck_proj
{
    //make the class
    public class Card

    {
        //add the properties
        public int val { get; set; }
        public string suit { get; set; }
        public string name { get; set; }

        //method to make name from value
        public Card(int v, string s)
        {
            val = v;
            suit = s;
            if (v == 1)
            {
                name = "Ace";
            }
            else if (v == 11)
            {
                name = "Jack";
            }
            else if (v == 12)
            {
                name = "Queen";
            }
            else if (v == 13)
            {
                name = "King";
            }
            else
            {
                name = v.ToString();
            }
        }
        //overrides the whole contruction as the class Card so it can be returned as a string.
        public override string ToString()
        {
            return $"{name} of {suit}";
        }
    }
}

