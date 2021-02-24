using System;
using System.Collections.Generic;
using System.Text;

namespace VendoMatic.Classes
{
    public class Item
    {
        public string Slot { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public int Quantity { get; set; } = 5;
        public string SoundMessage
        {
            get
            {
                switch(Type)
                {
                    case "Chip":
                        return "Crunch Crunch, Yum!";
                    case "Candy":
                        return "Munch Munch, Yum!";
                    case "Drink":
                        return "Glug Glug, Yum!";
                    case "Gum":
                        return "Chew Chew, Yum!";
                    default:
                        return "How did you even get here?";
                }
                
            }
        }
        
        public Item(string slot, string itemName, decimal price, string type)
        {
            Slot = slot;
            ItemName = itemName;
            Price = price;
            Type = type;
        }

    }
}
