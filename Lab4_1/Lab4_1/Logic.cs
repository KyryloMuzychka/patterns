using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab4_1
{
    public class Logic
    {
        public static string DefinePosition(Position employee)
        {
            switch (employee.GetType().ToString())
            {
                case "Lab4_1.Director":
                    return "Director";
                case "Lab4_1.Accountant":
                    return "Accountant";
                case "Lab4_1.ConsultantAdapter":
                    return "Consultant";
                default:
                    return "None";
            }
        }
        public static void DeleteItem(string name)
        {
            foreach (var employee in Store.employees)
            {
                if (employee.Surname == name)
                {
                    Store.employees.Remove(employee);
                    return;
                }
            }
        }
        public static void AddWorker(string name, string appointment)
        {        
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(appointment))
            {
                foreach (var employee in Store.employees)
                {
                    if (employee.Surname == name)
                    {                        
                        return;
                    }
                }
                Factory.AddWorker(appointment, name);
            }
        }
    }    
}
