using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    public class BankCustomer : BankDetails, ICreditCard
    {
        private string creditCard = "";

        private void generateCerditCard()
        {
            creditCard = "";
            int lengtNumber = 18;
            Random random = new Random();
            for (int i = 0; i < lengtNumber; i++)
            {
                int randomNumber = random.Next(0, 10);
                creditCard += randomNumber.ToString();
            }            
        }

        public void giveBankDetails(string BankName, string AccHolderName, long AccNumber)
        {
            setBankName(BankName);
            setAccHolderName(AccHolderName);
            setAccNumber(AccNumber);
            generateCerditCard();
        }

        public string getCreditCard()
        {                        
            string result = getBankName();
            result += " " + getAccHolderName();
            result += " " + getAccNumber();
            result += " " + creditCard;           
            return result;
        } 
    }
}
