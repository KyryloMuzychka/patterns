using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{  
    public class Facade
    {
        private static Random ran = new Random();

        private static ClsInvoice invoice = new ClsInvoice(ran.Next());
        private static ClsPayment payment = new ClsPayment(ran.Next());

        public static void ProcessPayment(string fullName, int total, DateTime paymentDate)
        {
            invoice.fullName = fullName;
            invoice.total = total;
            invoice.date = DateTime.Now;
            payment.date = paymentDate;                        
        }

        public static string PrintCheck()
        {
            string string_invoice = invoice.PrintInvoice();
            string string_payment = payment.Payonline();
            return string_invoice + "\n" + string_payment;
        }

        public static void AddProduct(ClsProduct product)
        {
            payment.listOfProducts.Add(product);
        }

        public static List<ClsProduct> GetListOfProducts()
        {
            return payment.listOfProducts;
        }

        public static void SetAmountForLastProduct(int number)
        {           
            payment.listOfProducts[payment.listOfProducts.Count - 1].amount = number;
        }      

        public static void SetData(string name, string surname)
        {
            payment.date = DateTime.Now;
            invoice.fullName = name + " " + surname;
        }

        public static void SetTotal(int number)
        {
            invoice.total = number;
        }   
    }
}
