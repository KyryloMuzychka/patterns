using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    public class ClsInvoice
    {        
        public int numberOfInvoice;
        public DateTime date;
        public string fullName;
        public int total;

        public ClsInvoice(int num)
        {
            numberOfInvoice = num;
            date = DateTime.Now;
        }

        public string PrintInvoice()
        {
            return "Invoice:\nInvoice code: " + numberOfInvoice.ToString() + "\nDate: " + date.ToString() + "\nName: " + fullName + "\nTotal: " + total + "$";
        }        
    }
}
