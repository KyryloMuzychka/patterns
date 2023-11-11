using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    public class Store
    {
        public static List<ClsProduct> products;

        public static void CreateList()
        {
            products = new List<ClsProduct>();

            ClsProduct productPhone = new ClsProduct();
            productPhone.price = 200;
            productPhone.manufacturer = "China";
            productPhone.name = "Xiaomi Redmi Note 12 Pro 8/256Gb Graphite Gray";

            products.Add(productPhone);

            ClsProduct productTablet = new ClsProduct();
            productTablet.price = 400;
            productTablet.manufacturer = "Korea";
            productTablet.name = "Tablet Samsung Galaxy Tab S6 Lite";

            products.Add(productTablet);

            ClsProduct productLaptop = new ClsProduct();
            productLaptop.price = 600;
            productLaptop.manufacturer = "USA";
            productLaptop.name = "Apple MacBook Pro 14 M1 Pro 512GB Space Gray 2021";                       
            
            products.Add(productLaptop);
        }        
    }
}
