using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendoMatic.Classes
{
    public class Chip:Item
    {
        public Chip(string slot, string itemName, decimal price, string type) : base(slot, itemName, price, type)
        {

        }
    }
}
