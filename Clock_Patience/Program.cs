﻿
using Clock_Patience;

class Program
{
    static void Main(string[] args)
    {
        Card card = new Card();
        Deck deck = new Deck();
        Random random = new Random();
        string sampleInput = "TS QC 8S 8D QH 2D 3H KH 9H 2H TH KS KC\n9D JH 7H JD 2S QS TD 2C 4H 5H AD 4D 5D\n6D 4S 9S 5S 7S JS 8H 3D 8C 3S 4C 6S 9C\nAS 7C AH 6H KD JC 7D AC 5C TC QD 6C 3C\n#";

        List<List<Card>> clockPatienceDeck = deck.CreateClockPatienceDeck(sampleInput);        
        deck.DisplayClockPatienceDeck(clockPatienceDeck);
        deck.RevealCardFromTopOfPile(clockPatienceDeck);

        while (deck.HasFaceDownCards(clockPatienceDeck))
        {
            deck.RevealCardFromTopOfPile(clockPatienceDeck);
        }

    }
}

