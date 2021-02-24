using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VendoMatic.Classes
{
    public class RW
    {
        public RW()
        {

        }
        public bool ReadCSV(List<Item> list)
        {
            //Reads in csv file with iitems and distributes information into list
            //string directory = $@"C:\Users\Student\workspace\Capstones\csharp-capstone-module-1-team-7";
            string directory = Directory.GetCurrentDirectory();
            string filename = "vendingmachine.csv";

            // Create the full path
            string fullPath = Path.Combine(directory, filename);
            //Create new list for splitting csv file
            List<string> itemList;
            try
            {
                using (StreamReader sr = new StreamReader(fullPath))
                {


                    while (!sr.EndOfStream)
                    {

                        // Read in the line
                        string line = sr.ReadLine();
                        //split the line into a list of strings 
                        itemList = new List<string>(line.Split('|'));
                        //create a new item to hold the needed info
                        switch (itemList[3])
                        {
                            case "Candy":
                                Candy candy = new Candy(itemList[0], itemList[1], decimal.Parse(itemList[2]), itemList[3]);
                                list.Add(candy);
                                break;
                            case "Chip":
                                Chip chip = new Chip(itemList[0], itemList[1], decimal.Parse(itemList[2]), itemList[3]);
                                list.Add(chip);
                                break;
                            case "Gum":
                                Gum gum = new Gum(itemList[0], itemList[1], decimal.Parse(itemList[2]), itemList[3]);
                                list.Add(gum);
                                break;
                            case "Drink":
                                Drink drink = new Drink(itemList[0], itemList[1], decimal.Parse(itemList[2]), itemList[3]);
                                list.Add(drink);
                                break;
                            default:
                                break;
                        }
                       

                    }
                }
            }
            catch (IOException e) //catch exception for error while reading input file
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
            return true;
        }
        public bool StartLog()
        {
            //Set path for log file
            //string logDirectory = $@"C:\Users\Student\workspace\Capstones\csharp-capstone-module-1-team-7\Capstone\bin\Debug\netcoreapp2.1";
            string logDirectory = Directory.GetCurrentDirectory();
            string fileName = "Log.txt";
            string logFullPath = Path.Combine(logDirectory, fileName);

            try
            {
                // create empty file or replace existing file
                using (StreamWriter sw = new StreamWriter(logFullPath))
                {
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }
        public bool WriteFeedMoney(decimal moneyFed, decimal balance)
        {
            //write to log file
            string directory = Directory.GetCurrentDirectory();
            string fileName = "Log.txt";
            string fullPath = Path.Combine(directory, fileName);

            try
            {
                // create the stream writer to write files
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    // write the current time and date and amount fed and new balance
                    sw.WriteLine($"{DateTime.Now} FEED MONEY: {moneyFed:c2} {balance:c2}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }
        public bool WritePurchase(string itemName, string slot, decimal balanceBeforePurchase, decimal newBalance)
        {
            //write to log file
            string directory = Directory.GetCurrentDirectory();
            string fileName = "Log.txt";
            string fullPath = Path.Combine(directory, fileName);
            try
            {
                // create the stream writer to write files
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    // write the current time and date and item being dispensed
                    sw.WriteLine($"{DateTime.Now} {itemName} {slot} {balanceBeforePurchase:c2} {newBalance:c2}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }
        public bool WriteGetChange(decimal balance)
        {
            //write to log file
            string directory = Directory.GetCurrentDirectory();
            string fileName = "Log.txt";
            string fullPath = Path.Combine(directory, fileName);

            try
            {
                // create the stream writer to write files
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    // write the current time and date and balance before and after giving change
                    sw.WriteLine($"{DateTime.Now} GIVE CHANGE: {balance:c2} {0:c2}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return true;
        }
        public bool UpdateSalesReport(string itemName, decimal itemPrice)
        {
            // Figure the full path of the input file and output file
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            string directory = Directory.GetCurrentDirectory();
            string file = "SalesReport.txt";
            string fullPath = Path.Combine(directory, file);

            try
            {

                using (StreamReader sr = new StreamReader(fullPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.Contains("|"))
                        {
                            string[] lineSplit = line.Split('|');
                            dictionary[lineSplit[0]] = lineSplit[1];
                        }
                        else
                        {
                            dictionary[line] = "";
                        }
                    }
                }
            }

            catch (IOException e) //catch a specific type of Exception
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(fullPath))
                {
                    foreach (KeyValuePair<string, string> kvp in dictionary)
                    {
                        if (kvp.Key != itemName && kvp.Key != "TOTAL SALES" && kvp.Key != "")
                        {
                            sw.WriteLine($"{kvp.Key}|{kvp.Value}");

                        }
                        else if (kvp.Key == itemName)
                        {
                            int newSalesNumber = int.Parse(kvp.Value) + 1;
                            sw.WriteLine($"{kvp.Key}|{newSalesNumber}");
                        }
                        else if (kvp.Key == "TOTAL SALES")
                        {
                            decimal newSalesTotal = decimal.Parse(kvp.Value.Replace("$", ""));
                            newSalesTotal += itemPrice;
                            sw.WriteLine($"{kvp.Key}|{newSalesTotal:c2}");
                        }
                        else
                        {
                            sw.WriteLine();
                        }
                    }

                }
            }
            catch (Exception e) //catch a specific type of Exception
            {
                Console.WriteLine(e.Message);
            }

            return true;
        }
        public bool CreateSalesReport()

        {
            // Figure the full path of the input file and output file
            string readDirectory = Directory.GetCurrentDirectory();
            string readFile = "SalesReport.txt";
            string readFullPath = Path.Combine(readDirectory, readFile);

            string writeDirectory = Directory.GetCurrentDirectory();
            string dateTime = DateTime.Now.ToString();
            dateTime = dateTime.Replace(" ", "-").Replace(":", "-").Replace(@"/", "-");

            string writeFile = $"SalesReport-{dateTime}.txt";
            string writeFullPath = Path.Combine(writeDirectory, writeFile);

            try
            {
                // Open the existing file with the typo using a StreamReader
                using (StreamReader sr = new StreamReader(readFullPath))
                {
                    // Open a StreamWriter where we will output the file
                    using (StreamWriter sw = new StreamWriter(writeFullPath))
                    {
                        // For each line in the input file, read it in                    
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            sw.WriteLine(line);

                        }
                    }
                }
            }
            catch (IOException e) //catch a specific type of Exception
            {
                Console.WriteLine("Error reading the file");
                Console.WriteLine(e.Message);
            }
            catch (Exception e) //catch a specific type of Exception
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Created Sales Report. Press Enter To Continue.");
            Console.ReadLine();
            return true;
        }
    }
}
