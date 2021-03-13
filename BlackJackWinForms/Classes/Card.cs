using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace BJWF.Classes
{
    public class Card
    {
        public Card(int faceValue, string suitValue)
        {
            FaceValue = faceValue;
            Suit = suitValue;
        }
        public int BlackjackValue
        {
            get
            {
                if (FaceValue == 11 || FaceValue == 12 || FaceValue == 13)
                {
                    return 10;
                }else if (FaceValue == 1)
                {
                    return 11;
                }
                else
                {
                    return FaceValue;
                }
            }
            
        }
        public int FaceValue { get; set; }
        public PictureBox PictureBox
        {
            get
            {
                if (FaceValue == 1 && Suit == "♦")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources.AD;
                    return pictureBox;
                    
                }
                else if (FaceValue == 1 && Suit == "♥")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources.AH;
                    return pictureBox;
                   
                }
                else if (FaceValue == 1 && Suit == "♠")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources.AH;
                    return pictureBox;
                }
                else if (FaceValue == 1 && Suit == "♣")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources.AH;
                    return pictureBox;
                }
                else if (FaceValue == 2 && Suit == "♦")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._2D;
                    return pictureBox;
                }
                else if (FaceValue == 2 && Suit == "♥")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._2H;
                    return pictureBox;
                }
                else if (FaceValue == 2 && Suit == "♠")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._2S;
                    return pictureBox;
                }
                else if (FaceValue == 2 && Suit == "♣")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._2C;
                    return pictureBox;
                }
                else if (FaceValue == 3 && Suit == "♦")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._3D;
                    return pictureBox;
                }
                else if (FaceValue == 3 && Suit == "♥")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._3H;
                    return pictureBox;
                }
                else if (FaceValue == 3 && Suit == "♠")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._3S;
                    return pictureBox;
                }
                else if (FaceValue == 3 && Suit == "♣")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._3C;
                    return pictureBox;
                }
                else if (FaceValue == 4 && Suit == "♦")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._4D;
                    return pictureBox;
                }
                else if (FaceValue == 4 && Suit == "♥")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._4H;
                    return pictureBox;
                }
                else if (FaceValue == 4 && Suit == "♠")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._4S;
                    return pictureBox;
                }
                else if (FaceValue == 4 && Suit == "♣")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._4C;
                    return pictureBox;
                }
                else if (FaceValue == 5 && Suit == "♦")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._5D;
                    return pictureBox;
                }
                else if (FaceValue == 5 && Suit == "♥")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._5H;
                    return pictureBox;
                }
                else if (FaceValue == 5 && Suit == "♠")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._5S;
                    return pictureBox;
                }
                else if (FaceValue == 5 && Suit == "♣")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._5C;
                    return pictureBox;
                }
                else if (FaceValue == 6 && Suit == "♦")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._6D;
                    return pictureBox;
                }
                else if (FaceValue == 6 && Suit == "♥")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._6H;
                    return pictureBox;
                }
                else if (FaceValue == 6 && Suit == "♠")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._6S;
                    return pictureBox;
                }
                else if (FaceValue == 6 && Suit == "♣")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._6C;
                    return pictureBox;
                }
                else if (FaceValue == 7 && Suit == "♦")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._7D;
                    return pictureBox;
                }
                else if (FaceValue == 7 && Suit == "♥")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._7H;
                    return pictureBox;
                }
                else if (FaceValue == 7 && Suit == "♠")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._7S;
                    return pictureBox;
                }
                else if (FaceValue == 7 && Suit == "♣")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._7C;
                    return pictureBox;
                }
                else if (FaceValue == 8 && Suit == "♦")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._8D;
                    return pictureBox;
                }
                else if (FaceValue == 8 && Suit == "♥")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._8H;
                    return pictureBox;
                }
                else if (FaceValue == 8 && Suit == "♠")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._8S;
                    return pictureBox;
                }
                else if (FaceValue == 8 && Suit == "♣")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._8C;
                    return pictureBox;
                }
                else if (FaceValue == 9 && Suit == "♦")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._9D;
                    return pictureBox;
                }
                else if (FaceValue == 9 && Suit == "♥")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._9H;
                    return pictureBox;
                }
                else if (FaceValue == 9 && Suit == "♠")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._9S;
                    return pictureBox;
                }
                else if (FaceValue == 9 && Suit == "♣")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._9C;
                    return pictureBox;
                }
                else if (FaceValue == 10 && Suit == "♦")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._10D;
                    return pictureBox;
                }
                else if (FaceValue == 10 && Suit == "♥")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._10H;
                    return pictureBox;
                }
                else if (FaceValue == 10 && Suit == "♠")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._10S;
                    return pictureBox;
                }
                else if (FaceValue == 10 && Suit == "♣")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources._10C;
                    return pictureBox;
                }
                else if (FaceValue == 11 && Suit == "♦")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources.JD;
                    return pictureBox;
                }
                else if (FaceValue == 11 && Suit == "♥")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources.JH;
                    return pictureBox;
                }
                else if (FaceValue == 11 && Suit == "♠")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources.JS;
                    return pictureBox;
                }
                else if (FaceValue == 11 && Suit == "♣")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources.JC;
                    return pictureBox;
                }
                else if (FaceValue == 12 && Suit == "♦")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources.QD;
                    return pictureBox;
                }
                else if (FaceValue == 12 && Suit == "♥")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources.QH;
                    return pictureBox;
                }
                else if (FaceValue == 12 && Suit == "♠")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources.QS;
                    return pictureBox;
                }
                else if (FaceValue == 12 && Suit == "♣")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources.QC;
                    return pictureBox;
                }
                else if (FaceValue == 13 && Suit == "♦")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources.KD;
                    return pictureBox;
                }
                else if (FaceValue == 13 && Suit == "♥")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources.KH;
                    return pictureBox;
                }
                else if (FaceValue == 13 && Suit == "♠")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources.KS;
                    return pictureBox;
                }
                else if (FaceValue == 13 && Suit == "♣")
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = global::BJWF.Properties.Resources.KC;
                    return pictureBox;
                }
                return null;
            }
        }
        public string Suit { get; }

        public static List<string> SuitNames = new List<string>() { "♦", "♥", "♣", "♠" };
    }
}
