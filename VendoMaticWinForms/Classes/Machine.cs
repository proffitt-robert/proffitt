using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VendoMatic.Classes
{
    public class Machine
    {
        //Creates a list of all items
        public List<Item> AllItem{ get; private set; } = new List<Item>();

        public decimal Balance { get; set; } = 0.00M;

        public Machine()
        {
            
        }
        public bool StartUp()
        {
            ////Reads in csv file with iitems and distributes information into list
            RW rw = new RW();
            rw.ReadCSV(AllItem);
            rw.StartLog();
            return true;
        }
      
        public int Dispense(Item item)
        {
            //Loops through each item in machine
            
                //Checks if user input matches current item slot
               
                    //Checks if user has enough money and item is available
                    if (Balance >= item.Price && item.Quantity > 0)
                    {
                        //Dispenses item
                        item.Quantity -= 1;
                        decimal balanceBeforePurchase = Balance;
                        Balance -= item.Price;
                     

                        //writes to log and sales report
                        RW rw = new RW();
                        rw.WritePurchase(item.ItemName, item.Slot, balanceBeforePurchase, Balance);
                        rw.UpdateSalesReport(item.ItemName,item.Price);
             
                        return 0;


                    }
                    //Checks if item is available but user doesn't have enough money
                    else if (Balance < item.Price && item.Quantity > 0)
                    {
                        
                        return 1;
                    }
                    //Checks if item is sold out
                    else
                    {
                       
                        return 2;
                    }
                

            
        }
        public void FeedMoney(decimal money)
        {
            
            RW rw = new RW();
            Balance += money;
            rw.WriteFeedMoney(money, Balance);
           
        }
        public string GetChange()
        {
            ////write to log file
            RW rw = new RW();
            rw.WriteGetChange(Balance);

            int quartersDispensed;
            int dimesDispensed;
            int nicklesDispensed;
            int balanceInChange = (int)(Balance * 100);

            quartersDispensed = balanceInChange / 25;
            balanceInChange -= (quartersDispensed * 25);
            dimesDispensed = balanceInChange / 10;
            balanceInChange -= (dimesDispensed * 10);
            nicklesDispensed = balanceInChange / 5;

            Balance = 0.00M;

            return $"{quartersDispensed} Quarters, {dimesDispensed} Dimes, {nicklesDispensed} Nickles";
        }

    }
}
