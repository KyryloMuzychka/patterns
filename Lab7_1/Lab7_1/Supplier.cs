using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    public class Supplier : IObservable
    {
        private List<IObserver> observers = new List<IObserver>();
        private double prevPrice;
        private double price;
        private string productName;

        public static Supplier CreateSupplier(string productName, double initialPrice)
        {
            return new Supplier(productName, initialPrice);
        }

        public Supplier(string productName, double initialPrice)
        {
            this.productName = productName;
            this.price = initialPrice;
            this.prevPrice = initialPrice;
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(price);
            }
        }

        public void SetPrice(double newPrice)
        {
            prevPrice = price;
            price = newPrice;
            NotifyObservers();
        }

        public double GetPrevPrice()
        {
            return prevPrice;
        }

        public double GetPrice()
        {
            return price;
        }

        public string GetProductName()
        {
            return productName;
        }
    }
}
