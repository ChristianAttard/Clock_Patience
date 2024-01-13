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
    }
}
