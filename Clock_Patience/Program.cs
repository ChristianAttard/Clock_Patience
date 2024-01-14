
using Clock_Patience;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Card card = new Card();
        Deck deck = new Deck();
        Random random = new Random();
        string sampleInput = "TS QC 8S 8D QH 2D 3H KH 9H 2H TH KS KC\n9D JH 7H JD 2S QS TD 2C 4H 5H AD 4D 5D\n6D 4S 9S 5S 7S JS 8H 3D 8C 3S 4C 6S 9C\nAS 7C AH 6H KD JC 7D AC 5C TC QD 6C 3C\n#";
        int cardsRevealed = 1;

        deck.CreateClockPatienceDeck(sampleInput);        
        deck.DisplayClockPatienceDeck();   
        //begin the game at pile index 12, the King position
        int nextPileIndex = deck.RevealAndPlaceOnNextPile(12);
        bool shouldPlayGame = true;            

        while (shouldPlayGame)
        {            
            nextPileIndex = deck.RevealAndPlaceOnNextPile(nextPileIndex);
            shouldPlayGame = deck.HasFaceDownCards(nextPileIndex);                                      
            cardsRevealed++;
        } 
        
        //retrieves the RankSuit of the last played card, according to the pile and card index
        string lastPlayedCard = deck.ClockPatienceDeck.ElementAt(nextPileIndex).ElementAt(0).RankSuit;
        //converts the value of cardReavealed to a string. The padding ensures that the card revealed is at least 2 characters
        string positionStr = cardsRevealed.ToString().PadLeft(2,'0');
        Console.WriteLine(positionStr + "," + lastPlayedCard);
    }
   

}

