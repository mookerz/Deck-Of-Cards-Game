using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardsGame
{
    class Card
    {
        public readonly static int SPADES = 0;   // Static codes for the 4 suits and Jocker
        public readonly static int HEARTS = 1;
        public readonly static int DIAMONDS = 2;
        public readonly static int CLUBS = 3;
        public readonly static int JOKER = 4;

        public readonly static int ACE = 1;    //  Static Codes for the non-numeric cards
        public readonly static int JACK = 11;    
        public readonly static int QUEEN = 12;   
        public readonly static int KING = 13;

        /**
        * This card's suit, one of the constants SPADES, HEARTS, DIAMONDS CLUBS, or JOKER.
        */
        private readonly int suit;

        /**
         * For a normal card, this is one of the values 1 through 13.  For a JOKER, the value can be anything
         */
        private readonly int value;


        //Card Constructor Begin
        public Card()
        {
            suit = JOKER;
            value = 1;
        }

        public Card(int inputValue, int inputSuit)
        {
            if (inputSuit != SPADES && inputSuit != HEARTS && inputSuit != DIAMONDS && inputSuit != CLUBS && inputSuit != JOKER)
                throw new SystemException("Invalid Card Suit Input!");
            if (inputSuit != JOKER && (inputValue < 1 || inputValue > 13) || (inputSuit == JOKER && (inputValue < 1 || inputValue > 2)))
                throw new SystemException("Invalid Card Value Input!");
            this.value = inputValue;
            this.suit = inputSuit;
        }

        //Card Constructor Finish


        public int getSuit()
        {
            return suit;
        }


        public int getValue()
        {
            return value;
        }


        public string getSuitAsString()
        {
            if(suit == SPADES) return "Spades";
            else if(suit == HEARTS) return "Hearts";
            else if(suit == DIAMONDS) return "Diamonds";
            else if(suit == CLUBS) return "Clubs";
            else return "Joker";
        }

        public string getValueAsString()
        {
            if (suit == JOKER)
                return value.ToString();   // You might have Jocker 1 and Jocker 2
            else
            {
                switch (value)
                {
                    case 1: return "Ace";
                    case 2: return "2";
                    case 3: return "3";
                    case 4: return "4";
                    case 5: return "5";
                    case 6: return "6";
                    case 7: return "7";
                    case 8: return "8";
                    case 9: return "9";
                    case 10: return "10";
                    case 11: return "Jack";
                    case 12: return "Queen";
                    default: return "King";
                }
            }
        }

        //Method Override the Object.ToString
        public override String ToString()
        {
            if (suit == JOKER)
            {
                return "Joker " + value;
            }
            else
                return getValueAsString() + " of " + getSuitAsString();
        }


    }
}
