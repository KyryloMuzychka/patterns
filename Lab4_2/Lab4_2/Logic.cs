using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    public class Logic
    {
        public static string findElement(long accNumberForFinding, List<ICreditCard> customers)
        {
            for (int i = 0; i < customers.Count(); i++)
            {
                if (long.Parse(Separate(customers[i].getCreditCard())[2]) == accNumberForFinding)
                {
                    return customers[i].getCreditCard();
                }
            }
            return "";
        }

        public static string[] Separate(string input)
        {
            char[] delimiters = new char[] { ' ' };
            string[] words = null;
            words = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        public static bool ChangeVisibility(bool b)
        {
            return b == true ? false : true;
        }
    }
}
