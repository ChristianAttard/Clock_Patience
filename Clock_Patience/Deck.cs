namespace Clock_Patience
{
    internal class Deck
    {
        public List<List<Card>> CreateClockPatienceDeck(string sampleInput)
        {
            string[] rows = sampleInput.Split("\n");

            List<List<Card>> clockPatienceDeck = new List<List<Card>>();

            for (int i = 0; i < 13; i++)
            {
                List<Card> pile = new List<Card>();
                clockPatienceDeck.Add(pile);
            }

            foreach (var row in rows)
            {
                if (row.Trim() == "#")
                {
                    // Stop when '#' is encountered
                    break;
                }

                string[] cardStrings = row.Split(' ');

                for (int i = 0; i < cardStrings.Length; i++)
                {
                    Card card = new Card();
                    card.RankSuit = cardStrings[i];
                    clockPatienceDeck.ElementAt(i).Add(card);
                }
            }

            return clockPatienceDeck;
        }

        public void DisplayClockPatienceDeck(List<List<Card>> clockPatienceDeck)
        {
            for (int i = 0; i < 4; i++)

            {
                foreach (var pile in clockPatienceDeck)
                {
                    Console.Write($"{pile.ElementAt(i).RankSuit} ");
                }
                Console.WriteLine();
            }
        }
        
        public void RevealCardFromTopOfPile(List<List<Card>> cardFromTopOfPile)
        {
            Card card = new Card();
            Random random = new Random();
            int randomColumnIndex = random.Next(cardFromTopOfPile.Count);

            List<Card> getListOfCards = cardFromTopOfPile[randomColumnIndex];

            Card topFaceDownCard = getListOfCards.FindLast(Card => !card.isFaceUp);

            if (topFaceDownCard == null)
            {
                Console.WriteLine("No face-down cards in the chosen column.");
                return;
            }

            // Flip the chosen card to face up
            topFaceDownCard.Flip();

            Console.WriteLine($"{randomColumnIndex} , {topFaceDownCard.ToString()}");
        }

        public bool HasFaceDownCards(List<List<Card>> cardPiles)
        {            
            foreach (var column in cardPiles)
            {
                if (column.Exists(card => !card.isFaceUp))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
