namespace Clock_Patience
{
    internal class Deck
    {
        public List<List<Card>> CreateClockPatienceDeck(string sampleInput)
        {
            string[] rows = sampleInput.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            List<List<Card>> clockPatienceDeck = new List<List<Card>>();

            foreach (var row in rows)
            {
                if (row.Trim() == "#")
                {
                    // Stop when '#' is encountered
                    break;
                }

                string[] cardStrings = row.Split(' ');

                List<Card> column = new List<Card>();
                foreach (var cardString in cardStrings)
                {
                    column.Add(new Card { RankSuit = cardString.Trim() });
                }

                clockPatienceDeck.Add(column);
            }

            return clockPatienceDeck;
        }

        public void DisplayClockPatienceDeck(List<List<Card>> clockPatienceDeck)
        {
            for (int i = 0; i < clockPatienceDeck.Count; i++)
            {
                Console.Write($"Column {i + 1}: ");
                foreach (var card in clockPatienceDeck[i])
                {
                    Console.Write($"{card.RankSuit} ");
                }
                Console.WriteLine();
            }
        }
    }
}
