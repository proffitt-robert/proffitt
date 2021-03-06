﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendoMatic.Classes;

namespace VendoMatic
{
    public partial class Form1 : Form
    {
        Machine VM { get; set; }
        public Form1()
        {
            InitializeComponent();
            VM = new Machine();
            VM.StartUp();
            DisplayAllItems();
        }

        public void DisplayAllItems()
        {
            this.lbl_itemName.Text = "";
            this.lbl_itemPrice.Text = "";
            this.lbl_itemQuantity.Text = "";

            for (int i = 0; i < VM.AllItem.Count; i++)
            {
                this.lbl_itemName.Text += VM.AllItem[i].Slot + "| " + VM.AllItem[i].ItemName + "\n";
                this.lbl_itemPrice.Text += $"{VM.AllItem[i].Price:c2}\n";
                this.lbl_itemQuantity.Text += "Quantity: " + VM.AllItem[i].Quantity + "\n";
            }

            DisplayBalance();

        }
        public void DisplayBalance()
        {
            this.lbl_Balance.Text = $"Balance: {VM.Balance:c2}";
        }

        private void DispenseMessage(int x, Item item)
        {
            switch (x)
            {
                case 0:
                    string goodMessage = $"Item Name: {item.ItemName}, Item Price: {item.Price:c2}, Remaining Balance: {VM.Balance:c2}. {item.SoundMessage}";
                    string title = "Purchased Item";
                    MessageBox.Show(goodMessage,title);
                    DisplayAllItems();
                    break;
                case 1:
                    string brokeMessage = "You don't have enough money for this item!";
                    title = "Error";
                    MessageBox.Show(brokeMessage, title);
                    break;
                case 2:
                    string soldOutMessage = "This item is sold out!";
                    title = "Error";
                    MessageBox.Show(soldOutMessage, title);
                    break;
                default:
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int message = VM.Dispense(VM.AllItem[3]);
            DispenseMessage(message, VM.AllItem[3]);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int message = VM.Dispense(VM.AllItem[0]);
            DispenseMessage(message, VM.AllItem[0]);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int message = VM.Dispense(VM.AllItem[1]);
            DispenseMessage(message, VM.AllItem[1]);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int message = VM.Dispense(VM.AllItem[2]);
            DispenseMessage(message, VM.AllItem[2]);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int message = VM.Dispense(VM.AllItem[4]);
            DispenseMessage(message, VM.AllItem[4]);
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int message = VM.Dispense(VM.AllItem[5]);
            DispenseMessage(message, VM.AllItem[5]);
          
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int message = VM.Dispense(VM.AllItem[6]);
            DispenseMessage(message, VM.AllItem[6]);
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int message = VM.Dispense(VM.AllItem[7]);
            DispenseMessage(message, VM.AllItem[7]);
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int message = VM.Dispense(VM.AllItem[8]);
            DispenseMessage(message, VM.AllItem[8]);
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int message = VM.Dispense(VM.AllItem[9]);
            DispenseMessage(message, VM.AllItem[9]);
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int message = VM.Dispense(VM.AllItem[10]);
            DispenseMessage(message, VM.AllItem[10]);
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int message = VM.Dispense(VM.AllItem[11]);
            DispenseMessage(message, VM.AllItem[11]);
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int message = VM.Dispense(VM.AllItem[12]);
            DispenseMessage(message, VM.AllItem[12]);
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int message = VM.Dispense(VM.AllItem[13]);
            DispenseMessage(message, VM.AllItem[13]);
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int message = VM.Dispense(VM.AllItem[14]);
            DispenseMessage(message, VM.AllItem[14]);
            

        }

        private void button16_Click(object sender, EventArgs e)
        {
            int message = VM.Dispense(VM.AllItem[15]);
            DispenseMessage(message, VM.AllItem[15]);
            
        }

        private void btn_1Dollar_Click(object sender, EventArgs e)
        {
            VM.FeedMoney(1.00M);
            DisplayBalance();
        }

        private void btn_2dollar_Click(object sender, EventArgs e)
        {
            VM.FeedMoney(2.00M);
            DisplayBalance();
        }

        private void btn_5dollar_Click(object sender, EventArgs e)
        {
            VM.FeedMoney(5.00M);
            DisplayBalance();
        }

        private void btn_10dollar_Click(object sender, EventArgs e)
        {
            VM.FeedMoney(10.00M);
            DisplayBalance();
        }

        private void btn_getChange_Click(object sender, EventArgs e)
        {
            string message = VM.GetChange();
            string title = "Change Dispensed";
            MessageBox.Show(message,title);
            DisplayBalance();
        }

        private void btn_createSalesReport_Click(object sender, EventArgs e)
        {
            RW rw = new RW();
            rw.CreateSalesReport();
        }
    }
}
