namespace Clock_Patience
{
    internal class Deck
    {
        public List<List<Card>> ClockPatienceDeck = new List<List<Card>>();

        public List<List<Card>> CreateClockPatienceDeck(string sampleInput)
        {
            string[] rows = sampleInput.Split("\n");

            for (int i = 0; i < 13; i++)
            {
                List<Card> pile = new List<Card>();
                ClockPatienceDeck.Add(pile);
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
                    ClockPatienceDeck.ElementAt(i).Insert(0,card);
                }
            }

            return ClockPatienceDeck;
        }

        public void DisplayClockPatienceDeck()
        {
            for (int i = 0; i < 4; i++)

            {
                foreach (var pile in ClockPatienceDeck)
                {
                    Console.Write($"{pile.ElementAt(i).RankSuit} ");
                }
                Console.WriteLine();
            }
        }

        public int RevealAndPlaceOnNextPile(int indexOfPile)
        {            
            List<Card> pileToCheck = ClockPatienceDeck.ElementAt(indexOfPile);
            Card cardToPlace = pileToCheck.ElementAt(pileToCheck.Count - 1);
            pileToCheck.RemoveAt(pileToCheck.Count - 1);
            cardToPlace.Flip();
            int newPileIndex = GetIndexForNextPile(cardToPlace.RankSuit);
            List<Card> pileToAdd = ClockPatienceDeck.ElementAt(newPileIndex);
            pileToAdd.Insert(0,cardToPlace);
            return newPileIndex;
        }

        public int GetIndexForNextPile(string cardValue)
        {            
            string cardRank = cardValue.Substring(0, 1);
            
            switch (cardRank)
            {                
                case "A": return 0;
                case "T": return 9;
                case "J": return 10;
                case "Q": return 11;
                case "K": return 12;                 
            }
            int cardRankInt = int.Parse(cardRank);
            return cardRankInt - 1;
        }        

        public bool HasFaceDownCards(int indexOfPile)
        {
            List<Card> pileToCheck = ClockPatienceDeck.ElementAt(indexOfPile);
            foreach (var item in pileToCheck)
            {
                if (!item.isFaceUp)
                {
                    return true;
                }
            } 
            return false;
        }        
    }
}
