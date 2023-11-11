using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    public class ClsPayment
    {       
        public int numberOfPayment;
        public DateTime date;
        public List<ClsProduct> listOfProducts = new List<ClsProduct>();

        public ClsPayment(int num) 
        {
            numberOfPayment = num;
        }

        public string Payonline() 
        {
            string str = "Payment:\nPayment code: " + numberOfPayment.ToString() + "\nDate: " + date.ToString() + "\nList of products:\n";
            foreach (var el in listOfProducts)
            {
                str += el.name + "\n";
            }
            return str;
        }
    }
}
