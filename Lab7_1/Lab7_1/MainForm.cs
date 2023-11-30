using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Lab7_1
{
    public partial class MainForm : Form
    {
      
        public MainForm()
        {
            InitializeComponent();
            InitializeSupplierAndStores();
        }

        private void InitializeSupplierAndStores()
        {
            Data.supplier = Supplier.CreateSupplier("ProductA", 300);

            Data.stores = new List<Store> {
                Store.CreateStore("Store 1", 10.0, Data.supplier),
                Store.CreateStore("Store 2", 15.0, Data.supplier),
                Store.CreateStore("Store 3", 0.0, Data.supplier)            
            };

            foreach (var store in Data.stores)
            {
                Data.supplier.AddObserver(store);
            }            
        }

        private void UpdatePricesButton_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();
            if (double.TryParse(NewPriceTextBox.Text, out double newPrice))
            {
                Data.supplier.SetPrice(newPrice);
                priceOfProduct.Text = Data.supplier.GetPrice().ToString();
            }

            for (int i = 0; i < Data.prices.Count; i++)
                listBoxResults.Items.Add($"Store: {Data.stores[i].GetName()}, Product Price: {Data.prices[i]}$");
        }        
    }   
}
