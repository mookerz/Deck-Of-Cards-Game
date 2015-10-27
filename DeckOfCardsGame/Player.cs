using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardsGame
{
    class Player
    {
        public List<Card> Cards;
        public Player()
        {
            Cards = new List<Card>();
        }

        public void addCard(Card newCard)
        {
            if (newCard == null) { throw new Exception("Cannot add an invalid card!"); }
            Cards.Add(newCard);
        }

        public void dropAll()
        {
            Cards = new List<Card>();
        }

        public void removeCard(Card existCard)
        {
            if (existCard == null) { throw new Exception("Cannot remove an invalid card!"); }
            if (getCardCount() <=0) { throw new Exception("No card can be removed!"); }
            Cards.Remove(existCard);
        }


        public int getCardCount()
        {
            return Cards.Count;
        }

        public Card getCard(int pos)
        {
            if (pos < 0 || pos >= getCardCount()) throw new Exception("Invalid position");
            return Cards[pos];
        }


        public void sortBySuit()
        {
            List<Card> newCards = new List<Card>();
            while (Cards.Count > 0)
            {
                Card temp = Cards[0];  
                for (int i = 1; i < Cards.Count; i++)
                {
                    Card c = Cards[i];
                    if (c.getValue() < temp.getValue() || (c.getValue() == temp.getValue() && c.getSuit() < temp.getSuit()))
                    {
                        temp = c;
                    }
                }
                Cards.Remove(temp);
                newCards.Add(temp);
            }
            Cards = newCards;
        }


        public void sortByValue()
        {
            List<Card> newCards = new List<Card>();
            while (Cards.Count > 0)
            {
                Card temp = Cards[0];
                for (int i = 1; i < Cards.Count; i++)
                {
                    Card c = Cards[i];
                    if (c.getSuit() < temp.getSuit() || (c.getSuit() == temp.getSuit() && c.getValue() < temp.getValue()))
                    {
                        temp = c;
                    }
                }
                Cards.Remove(temp);
                newCards.Add(temp);
            }
            Cards = newCards;
        }



    }
}
