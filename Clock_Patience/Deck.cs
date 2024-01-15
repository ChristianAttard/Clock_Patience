namespace Clock_Patience
{
    internal class Deck
    {
        //declare a 2D list
        public List<List<Card>> ClockPatienceDeck = new List<List<Card>>();

        //a method to create the deck
        public List<List<Card>> CreateClockPatienceDeck(string sampleInput)
        {
            //split the input string in an array 
            string[] rows = sampleInput.Split("\n");

            //initialise a list of 13 piles to create a deck of cards. Each card is stored in List pile.
            for (int i = 0; i < 13; i++)
            {
                List<Card> pile = new List<Card>();
                ClockPatienceDeck.Add(pile);
            }

            //iterate through the input until # is encountered
            foreach (var row in rows)
            {
                if (row.Trim() == "#")
                {
                    // Stop when '#' is encountered
                    break;
                }

                //again split the row into an array of card strings using space as a delimeter
                string[] cardStrings = row.Split(' ');

                //iterate through each card in the row
                for (int i = 0; i < cardStrings.Length; i++)
                {
                    //create a new card with the RankSuit property to the card string
                    Card card = new Card();
                    card.RankSuit = cardStrings[i];
                    //insert the card at the top of the i pile, in this case index 0
                    ClockPatienceDeck.ElementAt(i).Insert(0, card);
                }
            }
            //return the ClockPatienceDeck, which is a list of 13 piles with 4 cards each
            return ClockPatienceDeck;
        }

        //a method to display the 2D list 
        public void DisplayClockPatienceDeck()
        {
            //iterate through each 4 piles
            for (int i = 3; i >= 0; i--)

            {
                //iterate through each pile in the list ClockPatienceDeck
                foreach (var pile in ClockPatienceDeck)
                {
                    //Print the RankSuit of the i card in the current pile
                    Console.Write($"{pile.ElementAt(i).RankSuit} ");
                }
                //move to the next line after displaying each pile
                Console.WriteLine();
            }
        }

        //method to reveal a card and place it in a pile
        public int RevealAndPlaceOnNextPile(int indexOfPile)
        {
            //get the pile at the specified index from ClockPatienceDeck
            List<Card> pileToCheck = ClockPatienceDeck.ElementAt(indexOfPile);
            //Get the card to place from the top of the pile
            Card cardToPlace = pileToCheck.ElementAt(pileToCheck.Count - 1);
            //remove the card from the current pile
            pileToCheck.RemoveAt(pileToCheck.Count - 1);
            //flip the card to face up
            cardToPlace.Flip();
            //determine the index for the next pile based on the card's rank
            int newPileIndex = GetIndexForNextPile(cardToPlace.RankSuit);
            //get the next pile from ClockPatienceDeck
            List<Card> pileToAdd = ClockPatienceDeck.ElementAt(newPileIndex);
            //insert the revealed card at the bottom of the next pile
            pileToAdd.Insert(0, cardToPlace);
            //return the index of the next pile
            return newPileIndex;
        }

        //method to return the card value
        public int GetIndexForNextPile(string cardValue)
        {
            //extract the first character, card rank, from the card value
            string cardRank = cardValue.Substring(0, 1);

            //switch statement to determine the index for the next pile based on card rank
            switch (cardRank)
            {
                case "A": return 0;
                case "T": return 9;
                case "J": return 10;
                case "Q": return 11;
                case "K": return 12;
            }
            //if the card value is a number, it is converted to an integer and return the index (2-9)
            int cardRankInt = int.Parse(cardRank);
            return cardRankInt - 1;
        }

        public bool HasFaceDownCards(int indexOfPile)
        {
            //get the pile from a specific index from ClockPatienceDeck
            List<Card> pileToCheck = ClockPatienceDeck.ElementAt(indexOfPile);
            //iterate through each card in the pile
            foreach (var item in pileToCheck)
            {
                //check if the current card is face down
                if (!item.isFaceUp)
                {
                    //if at least one card is face down, the game will continue
                    return true;
                }
            }
            //if no cards are found with face down, the game is complete
            return false;
        }
    }
}
