using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BL
{
    class Card
    {
        private int value;                    // 1-13 , 1 Ace, 11 Jack, 12 Queen, 13 King 
        private int suit;                     //1 for Club, 2 for Diamond, 3 for Spade, 4 for Heart

        public Card(int value, int suit)
        {
            /* 
            * Creates a card with a specified suit and value. 
            */
            this.value = value;
            this.suit = suit;
        }

        public string getValueAsString()
        {
            if (value == 1)
            {
                return "Ace";
            }
            else if (value == 11)
            {
                return "Jack";
            }
            else if (value == 12)
            {
                return "Queen";
            }
            else if (value == 13)
            {
                return "King";
            }
            else
            {
                return value.ToString();
            }
        }

        public int getValue()
        {
            return value;
        }

        public int getSuit()
        {
            return suit;
        }


        public string getSuitAsString()
        {
            /* 
            * Returns a String representation of the card's value. 
            */
            if (suit == 1)
            {
                return "Clubs";
            }
            else if (suit == 2)
            {
                return "Diamonds";
            }
            else if (suit == 3)
            {
                return "Spades";
            }
            else
            {
                return "Hearts";
            }
        }

        public override string ToString()
        {
            return getValueAsString() + " of " + getSuitAsString();
        }

    }
}
