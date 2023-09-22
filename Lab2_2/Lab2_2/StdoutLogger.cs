using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    internal class StdoutLogger : ILogger
    {       
        public void log(string message)
        {
            MessageBox.Show($"File {message} has been opened", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }         
    }
}
