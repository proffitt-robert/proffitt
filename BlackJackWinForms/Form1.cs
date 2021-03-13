using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BJWF.Classes;

namespace BJWF
{
    public partial class Form1 : Form
    {
        int WinCounter = 0;
        int LossCounter = 0;
        Deck Deck;
        Player Player;
        Dealer Dealer;
        readonly PictureBox[] pCardPicArray = new PictureBox[11];
        readonly PictureBox[] dCardPicArray = new PictureBox[11];
        public Form1()
        {
            InitializeComponent();
            pCardPicArray[0] = pictureBox1;
            pCardPicArray[1] = pictureBox2;
            pCardPicArray[2] = pictureBox3;
            pCardPicArray[3] = pictureBox4;
            pCardPicArray[4] = pictureBox5;
            pCardPicArray[5] = pictureBox6;
            pCardPicArray[6] = pictureBox7;
            pCardPicArray[7] = pictureBox8;
            pCardPicArray[8] = pictureBox9;
            pCardPicArray[9] = pictureBox10;
            pCardPicArray[10] = pictureBox11;
            dCardPicArray[0] = pictureBox12;
            dCardPicArray[1] = pictureBox13;
            dCardPicArray[2] = pictureBox14;
            dCardPicArray[3] = pictureBox15;
            dCardPicArray[4] = pictureBox16;
            dCardPicArray[5] = pictureBox17;
            dCardPicArray[6] = pictureBox18;
            dCardPicArray[7] = pictureBox19;
            dCardPicArray[8] = pictureBox20;
            dCardPicArray[9] = pictureBox21;
            dCardPicArray[10] = pictureBox22;
            StartNewHand();
        }
        private void StartNewHand()
       {
            ResetScreen();
            Deck = new Deck();
            Deck.Shuffle();

            Player = new Player();
            Dealer = new Dealer();

            Player.GetHand(Deck);
            Dealer.GetHand(Deck);

            MessageBox.Show("Welcome To Blackjack!", "Blackjack");
            
            PlayerHand();
            DealerStartingHand();
        }
        private void ResetScreen()
        {
            btn_hit.Enabled = true;
            btn_stay.Enabled = true;
            label2.Text = "0";
            label4.Text = "0";
            foreach (PictureBox pictureBox in pCardPicArray)
            {
                pictureBox.Visible = false;

            }
            foreach (PictureBox pictureBox in dCardPicArray)
            {
                pictureBox.Visible = false;

            }
            label5.Text = $"W: {WinCounter} L: {LossCounter}";
        }
        private void PlayerHand()
        {
            int count = 0;
            foreach (Card card in Player.NewHand)
            {
                pCardPicArray[count].Visible = true;
                pCardPicArray[count].Image = card.PictureBox.Image;
                count++;
            }
            label2.Text = Player.HandValue.ToString();
        }
        private void DealerHand()
        {
            int count = 0;
            foreach (Card card in Dealer.NewHand)
            {
                dCardPicArray[count].Visible = true;
                dCardPicArray[count].Image = card.PictureBox.Image;
                count++;
            }
            label4.Text = Dealer.HandValue.ToString();
        }
        private void DealerStartingHand()
        {
            dCardPicArray[0].Visible = true;
            dCardPicArray[0].Image = Dealer.NewHand[0].PictureBox.Image;
            dCardPicArray[1].Visible = true;
            dCardPicArray[1].Image = global::BJWF.Properties.Resources.green_back;
            label4.Text = "?";
        }
        private void btn_hit_Click(object sender, EventArgs e)
        {
            bool turnContinue = Player.Turn(Deck);
            PlayerHand();
            if (!turnContinue)
            {
                btnStay();
            }
        }
        private void btnStay()
        {
            btn_hit.Enabled = false;
            btn_stay.Enabled = false;

            bool dealerTurn = true;
            while (dealerTurn == true)
            {
                DealerHand();
                dealerTurn = Dealer.Turn(Deck, Player);
            }
            CheckWinningCase();
            StartNewHand();
        }
        private void btn_stay_Click(object sender, EventArgs e)
        {
            btn_hit.Enabled = false;
            btn_stay.Enabled = false;
          
            bool dealerTurn = true;
            while (dealerTurn == true)
            {
                DealerHand();
                dealerTurn = Dealer.Turn(Deck, Player);
            }
            CheckWinningCase();
            StartNewHand();
        }
        private void CheckWinningCase()
        {
           
            if (Player.HandValue <= Dealer.HandValue && Dealer.HandValue <= 21)
            {
         
                MessageBox.Show("Dealer Wins! You Lose!.", "Blackjack");
                
                LossCounter++;
            }
            else if (Player.HandValue > Dealer.HandValue && Player.HandValue <= 21)
            {
                
                MessageBox.Show("You Beat The Dealer!.", "Blackjack");

                WinCounter++;
            }
            else if (Player.HandValue > 21)
            {
                
                MessageBox.Show("Bust! You Lose!.", "Blackjack");

                LossCounter++;
            }
            else if (Dealer.HandValue > 21)
            {
       
                MessageBox.Show("Dealer Busted! You Win!.", "Blackjack");

                WinCounter++;
            }
            
        }
    }
}
