using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace DeckOfCardsGame
{
    abstract class Deck
    {
        protected List<Card> DeckCards;

        protected List<Card> UsedCards;

        protected int NumOfDecks;

        public Deck()
        {
            // Code to initialize the Deck class goes here
            DeckCards = new List<Card>();
            UsedCards = new List<Card>();
            NumOfDecks = 0;
        }

        public Card dealCard()
        {
            if (getNumOfCardsInDeck() <= 0)  throw new Exception("No cards are left in the deck.");
            Card CurrentCard = DeckCards[0];
            UsedCards.Add(CurrentCard);
            DeckCards.RemoveAt(0);
            return CurrentCard;
        }

        public void shuffleCard()
        {
            //this.returnCard();
            Random r = new Random();
            for (int i = DeckCards.Count - 1; i > 0; i--)
            {
                int rand = (int)(r.Next(i + 1));
                Card temp = DeckCards[i];
                DeckCards[i] = DeckCards[rand];
                DeckCards[rand] = temp;
            }
        }


        //Return all used cards from UsedCards to DeckCards
        public void returnCard()
        {
            while (UsedCards.Count > 0)
            {
                Card tempCard = UsedCards[0];
                DeckCards.Add(tempCard);
                UsedCards.RemoveAt(0);
            }
        }

        public int getNumOfDecks()
        {
            return NumOfDecks;
        }

        public int getNumOfCardsInDeck()
        {
            return DeckCards.Count;
        }

        public int getNumOfCardsUsed()
        {
            return UsedCards.Count;
        }


    }
}
