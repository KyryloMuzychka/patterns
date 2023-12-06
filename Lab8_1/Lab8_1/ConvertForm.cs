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

namespace Lab8_1
{
    public partial class ConvertForm : Form
    {
        public ConvertForm()
        {
            InitializeComponent();
            InitializeProgressBar();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(QualityEdit.Text, out int quality))
            {
                FileConvertor converter = FileConvertor.CreateFileConverter();
                converter.ConvertFile(quality, UpdateProgressBar);
                InfoLabel.Text = Data.GetInfo();
            }
            else
            {
                MessageBox.Show("Invalid quality value. Please enter a valid integer.");
            }
        }

        private void InitializeProgressBar()
        {           
            progressBar.Dock = DockStyle.Bottom;
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Visible = false;            
            Controls.Add(progressBar);
        }

        private void UpdateProgressBar(int progress)
        {
            int clampedProgress = Math.Max(progressBar.Minimum, Math.Min(progressBar.Maximum, progress));

            progressBar.Value = clampedProgress;
            
            if (!progressBar.Visible)
            {
                progressBar.Visible = true;
            }
            
            if (progress == progressBar.Maximum)
            {
                progressBar.Visible = false;
            }            
        }

    }

    public interface IStrategy
    {
        void Convert(Action<int> onProgressUpdated);
    }
    
    public class FileConvertor
    {
        IStrategy strategy;       

        public static FileConvertor CreateFileConverter()
        {
            return new FileConvertor();
        }

        public void ConvertFile(int quality_value, Action<int> onProgressUpdated)
        {
            if (quality_value < 100)
            {
                strategy = new LowQualityConversion();              
            }
            else if (quality_value < 200)
            {
                strategy = new AverageQualityConversion();                
            }
            else
            {
                strategy = new HighQualityConversion();
            }           
            
            strategy.Convert(onProgressUpdated);
        }
    }
    
    public class LowQualityConversion : IStrategy
    {
        public void Convert(Action<int> onProgressUpdated)
        {
            for (int i = 0; i <= 100; i += 20)
            {
                onProgressUpdated(i);
                System.Threading.Thread.Sleep(500);
            }            
            Data.SetInfo("Converted the file in LOW quality");
        }
    }

    public class AverageQualityConversion : IStrategy
    {
        public void Convert(Action<int> onProgressUpdated)
        {            
            for (int i = 0; i <= 100; i += 10)
            {
                onProgressUpdated(i);
                System.Threading.Thread.Sleep(500);
            }
            Data.SetInfo("Converted the file in MEDIUM quality");
        }
    }

    public class HighQualityConversion : IStrategy
    {
        public void Convert(Action<int> onProgressUpdated)
        {
            for (int i = 0; i <= 100; i += 5)
            {
                onProgressUpdated(i);
                System.Threading.Thread.Sleep(500);
            }            
            Data.SetInfo("Converted the file in HIGH quality");
        }
    }

    public class Data
    {
        private static string info;

        public static void SetInfo(string str)
        {
            info = str;
        }

        public static string GetInfo()
        {
            return info;
        }
    }
}
