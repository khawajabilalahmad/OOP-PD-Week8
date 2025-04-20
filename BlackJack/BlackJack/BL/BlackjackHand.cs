using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.BL
{
    class BlackjackHand : Hand
    {
        public int getBlackJackValue()
        {
            int sum = 0;
            Boolean ace = false;
            foreach (BL.Card c in GetHand())
            {
                string card = c.getValueAsString();
                if (card == "Jack" || card == "King" || card == "Queen")
                {
                    sum += 10;
                }
                else if (card == "Ace")
                {
                    ace = true;
                    if (sum + 11 != 21)
                    {
                        sum += 11;
                    }
                    else
                    {
                        sum += 1;
                    }
                }
                else
                {
                    sum += c.getValue();
                }
            }
            return sum;
        }

        public bool IsBusted()
        {
            return getBlackJackValue() > 21;
        }

        public bool IsBlackjack()
        {
            return getBlackJackValue() == 21 ;
        }

    }
}
