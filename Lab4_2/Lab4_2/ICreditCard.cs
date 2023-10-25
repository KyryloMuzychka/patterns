using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    public interface ICreditCard
    {
        void giveBankDetails(string BankName, string AccHolderName, long AccNumber);
        string getCreditCard();
    }
}
