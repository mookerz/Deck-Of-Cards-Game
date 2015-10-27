using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class is used as a collection of cards.
//In this case, used as table where all the cards are.

namespace DeckOfCardsGame
{
    class Decks : Deck   //Extends Deck Class
    {
        public Decks()
        {
            
        }

        public void AddADeckOfCards(bool containJocker)
        {
            for (int suitI = 0; suitI <= 3; suitI++)
            {
                for (int valueJ = 1; valueJ <= 13; valueJ++)
                {
                    DeckCards.Add(new Card(valueJ, suitI));
                }
            }
            if (containJocker)
            {
                DeckCards.Add(new Card(1, Card.JOKER));
                DeckCards.Add(new Card(2, Card.JOKER));
            }

            NumOfDecks++;
        }

        // Add a deck of cards with no Jocker as default method
        public void AddADeckOfCards()
        {
            AddADeckOfCards(false);
        }


        public void CleanTable()
        {
            DeckCards = new List<Card>();
            UsedCards = new List<Card>();
            NumOfDecks = 0;
            GC.Collect();
        }

    }
}
