using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_2
{
    public partial class PizzaForm : Form
    {
        public PizzaForm()
        {
            InitializeComponent();
            InitializeComboBox();       
        }

        private void OrderPizzaButton_Click(object sender, EventArgs e)
        {
            string selectedPizza;
            if (ChoosePizzaComboBox.SelectedItem != null && !string.IsNullOrEmpty(ChoosePizzaComboBox.SelectedItem.ToString()))
            {
                selectedPizza = ChoosePizzaComboBox.SelectedItem.ToString();
                IPizzaStrategy pizzaStrategy = null;
                switch (selectedPizza)
                {
                    case "Margherita Pizza":
                        pizzaStrategy = MargheritaPizza.CreateMargheritaPizza();
                        break;
                    case "Pepperoni Pizza":
                        pizzaStrategy = PepperoniPizza.CreatePepperoniPizza();
                        break;
                }

                if (pizzaStrategy != null)
                {
                    Data.order = PizzaOrder.CreatePizzaOrder(pizzaStrategy);
                    Data.order.ProcessOrder();
                    UpdateListBox();
                    Data.total += Data.order.total;
                    TotalLabel.Text = "Total: " + Data.total.ToString();
                }
            }            
        }
     
        private void InitializeComboBox()
        {
            ChoosePizzaComboBox.Items.Add("Margherita Pizza");
            ChoosePizzaComboBox.Items.Add("Pepperoni Pizza");
        }
        
        private void UpdateListBox()
        {            
            OrderListBox.Items.Add(Data.ingredients);
            OrderListBox.Items.Add(Data.cost);            
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            Data.total = 0;
            OrderListBox.Items.Clear();
            TotalLabel.Text = "Total: 0";
        }
    }


    public class PizzaOrder
    {
        private IPizzaStrategy pizzaStrategy;
        public double total = 0;

        private PizzaOrder(IPizzaStrategy strategy)
        {
            pizzaStrategy = strategy;
        }

        public static PizzaOrder CreatePizzaOrder(IPizzaStrategy strategy)
        {
            return new PizzaOrder(strategy);
        }

        public void ProcessOrder()
        {
            pizzaStrategy.PrepareIngredients();
            total += pizzaStrategy.GetCost();
            Data.cost = ($"Cost: {pizzaStrategy.GetCost()} UAH");
        }
    }

    public class Data
    {
        public static PizzaOrder order;
        public static double total = 0;
        public static string ingredients;
        public static string cost;
    }

    public interface IPizzaStrategy
    {
        void PrepareIngredients();
        double GetCost();
    }

    class MargheritaPizza : IPizzaStrategy
    {
        private List<string> ingredients = new List<string> { "Tomato sauce", "Mozzarella", "Basil" };
        private double cost = 100.00;

        public static MargheritaPizza CreateMargheritaPizza()
        {
            return new MargheritaPizza();
        }

        public void PrepareIngredients()
        {
            Data.ingredients = ("Pizza ingredients: " + string.Join(", ", ingredients));
        }

        public double GetCost()
        {
            return cost;
        }
    }

    class PepperoniPizza : IPizzaStrategy
    {
        private List<string> ingredients = new List<string> { "Tomato sauce", "Mozzarella", "Pepperoni" };
        private double cost = 120.00;

        public void PrepareIngredients()
        {
            Data.ingredients = ("Preparing Pepperoni Pizza ingredients: " + string.Join(", ", ingredients));
        }

        public static PepperoniPizza CreatePepperoniPizza()
        {
            return new PepperoniPizza();
        }

        public double GetCost()
        {
            return cost;
        }
    }
}
