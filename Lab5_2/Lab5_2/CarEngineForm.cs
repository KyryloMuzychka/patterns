using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_2
{
    public partial class CarEngineForm : Form
    {
        public CarEngineForm()
        {
            InitializeComponent();
        }

        private void startEngineButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(airBox.Text) && !string.IsNullOrWhiteSpace(temperatureBox.Text)) {
                if (int.TryParse(airBox.Text, out int air) && int.TryParse(temperatureBox.Text, out int temperature))
                {
                    stopEngineButton.Enabled = true;
                     startEngineButton.Enabled = false;

                    CreateFacade.CreateSystemFacade();
                    CreateFacade.facade.InitializeAirFlow(air);
                    CreateFacade.facade.InitializeTemperature(temperature);

                    MessageBox.Show(CreateFacade.facade.StartCar(), "System Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void stopEngineButton_Click(object sender, EventArgs e)
        {            
            stopEngineButton.Enabled = false;
            startEngineButton.Enabled = true;  
            
            MessageBox.Show(CreateFacade.facade.StopCar(), "System Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }                              
    }
}
