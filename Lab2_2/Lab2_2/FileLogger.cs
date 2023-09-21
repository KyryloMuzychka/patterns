using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    public class FileLogger : Logger
    {
        private string filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }
        
        public void log(string message)
        {                      
            MessageBox.Show("File has been saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write message into the file
                writer.WriteLine(message);
            }
        }
    }
}
