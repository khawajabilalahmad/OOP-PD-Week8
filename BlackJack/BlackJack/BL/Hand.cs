using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BL
{
    class Hand
    {
        private List<BL.Card> hand = new List<BL.Card>();


        public Hand()
        {

        }

        public void clear()
        {
            hand.Clear();
        }

        public void addCard(Card c)
        {
            hand.Add(c);
        }
        public void removeCard(Card c)
        {
            hand.Remove(c);
        }

        public void removeCard(int position)
        {

            hand.RemoveAt(position);
        }

        /*public BL.Card getCard(int position)
        {
            for (int i=0; i < hand.Count; i++)
            {
                if (i == position)
                {
                    return hand[i];
                }
            }
        }*/

        public void sortBySuit()
        {
            
            hand.Sort((card1, card2) =>
            {
                if (card1.getSuit() == card2.getSuit())
                {
                    return card1.getValue().CompareTo(card2.getValue()); // Sort by value if suits are the same
                }
                else
                {
                    return card1.getSuit().CompareTo(card2.getSuit());   // Otherwise, sort by suit
                }
            });
        }

        public void sortByValue()
        {
            hand.Sort((card1, card2) =>
            {
                if (card1.getValue() == card2.getValue())
                {
                    return card1.getSuit().CompareTo(card2.getSuit()); // Sort by value if suits are the same
                }
                else
                {
                    return card1.getValue().CompareTo(card2.getValue());   // Otherwise, sort by suit
                }
            });
        }

        public void ShowHand()
        {
            foreach (BL.Card c in GetHand())
            {
                Console.WriteLine(c);
            }
                
        }

        public List<BL.Card> GetHand()
        {
            return hand;
        }


    }
}
