using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BJWF.Classes
{
    public class Dealer : Player
    {
        public Dealer()
        {

        }
        public override int HandValue
        {
            get
            {
                int total = 0;

                foreach (Card card in NewHand)
                {
                    total += card.BlackjackValue;
                }

                foreach (Card card in NewHand)
                {
                    bool toCheck = true;
                   
                    if (total > 21)
                    {
                        if (card.BlackjackValue == 11)
                        {
                            total -= 10;
                            toCheck = false;
                        }
                    }
                    else if (toCheck == true && total == 17)
                    {
                        if (card.BlackjackValue == 11)
                        {
                            total -= 10;
                            break;
                        }
                    }
                    else if (total < 22 && total != 17)
                    {
                        break;
                    }
                }
                return total;
            }
            set
            {

            }
        }
        public bool Turn(Deck deck, Player player)
        {
            if (HandValue < 17 && player.HandValue < 21 || HandValue < 17 && player.HandValue == 21 && player.NewHand.Count > 2)
            {
                MessageBox.Show("Dealer Getting Card...", "BlackJack");
                HitMe(deck);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
