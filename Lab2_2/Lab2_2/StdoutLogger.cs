using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    internal class StdoutLogger : Logger
    {       
        public void log(string filePath)
        {
            MessageBox.Show("File has been opened", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }         
    }
}
