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
        static protected string message, name, format;

        // Get data
        static public string GetMessage()
        {
            return message;
        }

        static public string GetName()
        {
            return name;
        }

        static public string GetFormat()
        {
            return format;
        }

        static public void GetData(Form1 form)
        {
            // Set data
            message = form.GetInputText().Text;
            name = form.GetNameText().Text;
            format = form.GetFormatsComboBox().SelectedItem.ToString();
        }

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
