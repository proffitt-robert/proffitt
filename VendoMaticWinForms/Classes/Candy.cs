using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendoMatic.Classes
{
    public class Candy : Item
    {
        public Candy(string slot, string itemName, decimal price, string type):base(slot,itemName,price,type)
        {

        }

    }
}
