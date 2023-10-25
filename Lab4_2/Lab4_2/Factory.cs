using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    public class Factory
    {
        public static List<ICreditCard> bankCustomers = new List<ICreditCard>();
        
        public static BankCustomer CreateCustomer()
        {
            return new BankCustomer();
        }
    }
}
