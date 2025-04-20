using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BL
{
    class Deck
    {
        private BL.Card[] deck = new BL.Card[52];

        private int count;

        public Deck()
        {
            count = 0;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 13; y++)
                {
                    deck[count] = new BL.Card(y, x);
                    count++;
                }
            }
        }

        public void shuffle()
        {
            System.Random rand = new System.Random();
            BL.Card temp;
            for (int i = 0; i < 52; i++)
            {
                int num = rand.Next(0, 52);
                temp = deck[num];
                deck[num] = deck[i];
                deck[i] = temp;
            }
        }

        public BL.Card dealCard()
        {
            if (count > 0)
            {
                count--;
                return deck[count];
            }
            else
            {
                return null;
            }
        }

        public int cardsLeft()
        {
            return count;
        }
    }
}
