using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BJWF.Classes
{
    public class Player
    {
        public List<Card> NewHand { get; set; } = new List<Card>();
        public virtual int HandValue
        {
            get
            {
                int total = 0;
                
                foreach (Card cards in NewHand)
                {
                    total += cards.BlackjackValue;
                }

                foreach (Card card in NewHand)
                {
                    if (total > 21)
                    {
                        if (card.BlackjackValue == 11)
                        {
                            total -= 10;     
                        }
                    }
                    else
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
        public Player()
        {

        }
        public bool GetHand(Deck deck)
        {
            NewHand.Add(deck.DealOne());
            NewHand.Add(deck.DealOne());
            return true;
        }
        public bool HitMe(Deck deck)
        {
            NewHand.Add(deck.DealOne());
            if (HandValue >= 21)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool Turn(Deck deck)
        {
                bool toContinue = HitMe(deck);
                if (toContinue)
                {
                    return true;
                }else
                {
                    return false;
                }
            
        }
    }
}
    
