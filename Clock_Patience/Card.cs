namespace Clock_Patience
{
    internal class Card
    {
        //boolean variable for card facing up or down
        public string RankSuit { get; set; }

        public bool isFaceUp { get; set; }


        //default constructor
        public Card() { }

        //constructor with parameters 
        public Card(string _RankSuit)
        {
            RankSuit = _RankSuit;
            isFaceUp = false; //by default card is face down
        }

        //a method to flip the card
        public void Flip()
        {
            isFaceUp = !isFaceUp;
        }

        //a method that can be inherited to return RankSuit 
        public override string ToString()
        {
            if (isFaceUp)
            {
                return $"{RankSuit}";
            }
            else
            {
                return "Card is face down";
            }
        }

    }
}
