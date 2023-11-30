using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_1
{
    public class Store : IObserver
    {
        private string storeName;
        private double markupPercentage;        
        private Supplier supplier;

        public static Store CreateStore(string storeName, double markupPercentage, Supplier supplier)
        {
            return new Store(storeName, markupPercentage, supplier);
        }

        public Store(string storeName, double markupPercentage, Supplier supplier)
        {
            this.storeName = storeName;
            this.markupPercentage = markupPercentage;
            this.supplier = supplier;
        }

        public string GetName()
        {
            return storeName;
        }

        public void Update(double price)
        {
            double finalPrice = CalculateFinalPrice(price);
            Data.prices.Add(finalPrice);           
        }

        private double GetPrevPrice()
        {
            if (supplier != null)
            {
                return supplier.GetPrevPrice();
            }
            return 0;
        }

        private double CalculateFinalPrice(double price)
        {
            if (price > GetPrevPrice())
            {
                return price + (price * markupPercentage / 100);
            }
            else
            {
                return price - (price * markupPercentage / 100);
            }
        }
    }
}
