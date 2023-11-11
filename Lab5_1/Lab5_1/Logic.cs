using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    public class Logic
    {
        public static void FindElementAndDelete(int index)
        {
            for (int i = 0; i < Facade.GetListOfProducts().Count; i++)
            {
                if (Store.products[index].name == Facade.GetListOfProducts()[i].name)
                {
                    Facade.GetListOfProducts().RemoveAt(i);
                    break;
                }
            }
        }

        public static int CalculateTotal()
        {
            int total = 0;
            for (int i = 0; i < Facade.GetListOfProducts().Count; i++)
            {
                total += Facade.GetListOfProducts()[i].amount * Facade.GetListOfProducts()[i].price;
            }
            Facade.SetTotal(total);
            return total;
        }
    }
}
