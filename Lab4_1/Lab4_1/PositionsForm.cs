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

namespace Lab4_1
{
    public partial class PositionsMainForm : Form
    {
        public PositionsMainForm()
        {
            InitializeComponent();
            InitializePositionsComboBox();          
        }

        void InitializePositionsComboBox()
        {
            foreach (var position in Store.positions)
            {
                positionComboBox.Items.Add(position);
            }
        }

        private void addWorkerButton_Click(object sender, EventArgs e)
        {
            string name = surnameEdit.Text;
            string appointment = positionComboBox.SelectedItem.ToString();
            Logic.AddWorker(name, appointment);
            UpdatePositionsListView();
        }

        private void removeWorkerButton_Click(object sender, EventArgs e)
        {
            if (positionsListView.SelectedItems.Count > 0)
                if (!string.IsNullOrEmpty(positionsListView.SelectedItems[0].SubItems[0].Text))
                { 
                    string name = positionsListView.SelectedItems[0].SubItems[0].Text; 
                    Logic.DeleteItem(name);
                    UpdatePositionsListView();
                }
           
        }

        private void UpdatePositionsListView()
        {
            positionsListView.Items.Clear();            
            foreach (var employee in Store.employees)
            {
                ListViewItem item = new ListViewItem(employee.Surname);
                item.SubItems.Add(Logic.DefinePosition(employee)); 
                item.SubItems.Add(employee.Work()); 
                positionsListView.Items.Add(item);                
            }
        }       
    }
}
