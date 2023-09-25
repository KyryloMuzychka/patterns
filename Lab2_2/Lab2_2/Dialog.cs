using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_2
{
    public class Dialog
    {                   
        static protected string GetNameAndDeleteExtension(string name)
        {
            string fileName = "";
            foreach (char c in name)
            {
                if (c == '.')
                {
                    break;
                }
                fileName += c;
            }
            return fileName;
        }
    }
}
