using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab5_1
{
    public partial class ShopForm : Form
    {
        public ShopForm()
        {
            InitializeComponent();
            InitializeListView();
            InitializePositionsComboBox();
        }

        void InitializePositionsComboBox()
        {
            Store.CreateList();
            foreach (var product in Store.products)
            {
                productComboBox.Items.Add(product.name);
            }
        }

        void InitializeListView()
        {
            productsListView.Columns.Add("Name", 250, HorizontalAlignment.Left);
            productsListView.Columns.Add("Amount", 100, HorizontalAlignment.Left);
            productsListView.Columns.Add("Price per one", 100, HorizontalAlignment.Left);
            productsListView.Columns.Add("Manufacturer", 150, HorizontalAlignment.Left);
        }

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
            priceAmountLabel.Text = (amountNumericUpDown.Value * Store.products[productComboBox.SelectedIndex].price).ToString();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Logic.FindElementAndDelete(productComboBox.SelectedIndex);
            if (((int)amountNumericUpDown.Value >= 1) && (productComboBox.SelectedIndex != -1)) 
            {
                Facade.AddProduct(Store.products[productComboBox.SelectedIndex]);
                Facade.SetAmountForLastProduct((int)amountNumericUpDown.Value);
                totalPriceAmountLabel.Text = Logic.CalculateTotal().ToString();
                UpdatePositionsListView();
            }
        }

        private void amountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            priceAmountLabel.Text = (amountNumericUpDown.Value * Store.products[productComboBox.SelectedIndex].price).ToString();
        }

        private void UpdatePositionsListView()
        {
            productsListView.Items.Clear();
            foreach (var product in Facade.GetListOfProducts())
            {
                ListViewItem item = new ListViewItem(product.name);
                item.SubItems.Add(product.amount.ToString());
                item.SubItems.Add(product.price.ToString());
                item.SubItems.Add(product.manufacturer);
                productsListView.Items.Add(item);
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            Facade.SetData(nameTextBox.Text, surnameTextBox.Text);
            MessageBox.Show(Facade.PrintCheck(), "Pay", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
