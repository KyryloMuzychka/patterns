using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    public class FileLogger : ILogger
    {
        private string filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }
        
        public void log(string message)
        {                      
            MessageBox.Show($"File {message} has been saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
