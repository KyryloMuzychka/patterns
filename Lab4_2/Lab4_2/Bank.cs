using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_2
{
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();                  
        }
    
        private void findCustomer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(customerIdEdit.Text))
            {
                long accNumberForFinding;
                if (long.TryParse(customerIdEdit.Text.ToString(), out accNumberForFinding))
                {
                    string words = Logic.findElement(accNumberForFinding, Factory.bankCustomers);                    
                    if (words != "")
                    {                        
                        accountHolderNameLabel.Text = "Bank Name:\n" + Logic.Separate(words)[0];
                        banckNameLabel.Text = "Account Holder Name:\n" + Logic.Separate(words)[1];
                        accountNumberLabel.Text = "Account Number:\n" + Logic.Separate(words)[2];
                        creditCardLabel.Text = "Credit Card:\n" + Logic.Separate(words)[3];

                        mainPanel.Visible = false;
                        customerPanel.Visible = true;
                    }
                    else
                    {
                        errorLabel.Text = "User is not found";
                    }
                }
                else
                {
                    errorLabel.Text = "Invalid input!";
                }               
            }
            else
            {
                errorLabel.Text = "The field is empty!";
            }            
        }

        private void returnToMainButton_Click(object sender, EventArgs e)
        {
            ClearFields();
            addCustomerButton.Enabled = true;
            successfulLabel.Text = "";
            mainPanel.Visible = true;
            addCustomerPanel.Visible = false;
        }

        private void returnToMainFromProfileButton_Click(object sender, EventArgs e)
        {
            ClearFields();
            mainPanel.Visible = Logic.ChangeVisibility(mainPanel.Visible);
            customerPanel.Visible = Logic.ChangeVisibility(customerPanel.Visible);
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            bool flag = true;            
            if (string.IsNullOrWhiteSpace(bankNameEdit.Text))
            {
                errorBankNameLabel.Text = "Empty!";
                flag = false;
            }
            else
            {
                errorBankNameLabel.Text = "";
            }
            if (string.IsNullOrWhiteSpace(accountHolderNameEdit.Text))
            {
                errorAccountHolderNameLabel.Text = "Empty!";
                flag = false;
            }
            else
            {
                errorAccountHolderNameLabel.Text = "";
            }
            if (string.IsNullOrWhiteSpace(accountNumberEdit.Text))
            {
                errorAccountNumberLabel.Text = "Empty!";
                flag = false;
            }
            else if (!long.TryParse(accountNumberEdit.Text, out long accNumber))
            {
                errorAccountNumberLabel.Text = "Invalid input!";
                flag = false;
            }
            else if (Logic.findElement(long.Parse(accountNumberEdit.Text), Factory.bankCustomers) != "")
            {
                errorAccountNumberLabel.Text = "This number already exists!";
                flag = false;
            }
            else
            {
                errorAccountNumberLabel.Text = "";
            }
            if (flag)
            {
                ICreditCard customer = Factory.CreateCustomer();
                customer.giveBankDetails(
                    bankNameEdit.Text,
                    accountHolderNameEdit.Text,
                    long.Parse(accountNumberEdit.Text)
                );
                Factory.bankCustomers.Add(customer);
                addCustomerButton.Enabled = false;                                
                creditCardEdit.Text = Logic.Separate(customer.getCreditCard())[3];
                successfulLabel.Text = "Added successfully!";
            }
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            ClearEditsForInputData();          
            mainPanel.Visible = Logic.ChangeVisibility(mainPanel.Visible);
            addCustomerPanel.Visible = Logic.ChangeVisibility(addCustomerPanel.Visible);            
        }

        private void ClearEditsForInputData()
        {
            bankNameEdit.Clear();
            accountNumberEdit.Clear();
            accountHolderNameEdit.Clear();
            creditCardEdit.Clear();
        }

        private void ClearFields()
        {
            errorLabel.Text = "";
            customerIdEdit.Clear();
        }
    }
}
