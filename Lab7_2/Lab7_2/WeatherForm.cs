using System;
using System.Windows.Forms;

namespace Lab7_2
{
    public partial class WeatherForm : Form
    {
        public WeatherForm()
        {
            InitializeComponent();
            Data.CreateData();            
            Data.weatherData.setMeasurements(30, 70, 760.0f);
            PrintConditions();
        }

        private void SetDataButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(temperatureEdit.Text) &&
                !string.IsNullOrWhiteSpace(humidityEdit.Text) &&
                !string.IsNullOrWhiteSpace(pressureEdit.Text))
            {
                float temp = float.Parse(temperatureEdit.Text);
                float humidity = float.Parse(humidityEdit.Text);
                float pressure = float.Parse(pressureEdit.Text);

                Data.weatherData.setMeasurements(temp, humidity, pressure);
                Data.heatIndexDisplay.update(temp, humidity, pressure);
            }

            PrintConditions();
        }

        void PrintConditions()
        {
            ListBoxResult.Items.Clear();
            ListBoxResult.Items.Add(Data.currentConditions);
            ListBoxResult.Items.Add(Data.temperature);
            ListBoxResult.Items.Add(Data.heatIndex);
            ListBoxResult.Items.Add(Data.displayWeather);
        }
    }
}
