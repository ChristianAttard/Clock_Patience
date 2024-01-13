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
        public Card(bool faceUp)
        {
            this.isFaceUp = faceUp;            
        }
    }
}
