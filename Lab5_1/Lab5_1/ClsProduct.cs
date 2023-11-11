using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    public class ClsProduct
    {
        public string name;
        public string manufacturer;
        public int price;
        public int amount;

        public string GetDetails() 
        {
            return name + " " + manufacturer + " " + price;
        }
    }
}
