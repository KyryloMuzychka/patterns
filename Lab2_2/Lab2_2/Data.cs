using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    public class Data
    {
        static private string message, name, format;

        static public void SetData(string _message, string _name, string _format)
        {
            message = _message;
            name = _name;
            format = _format;
        }

        static public string GetName() { return name; }
        static public string GetFormat() { return format; }
        static public string GetMessage() { return message; }

        static public void SetName(string _name) { name = _name; }
        static public void SetFormat(string _format) { format = _format; }
        static public void SetMessage(string _message) { message = _message; }
    }
}
