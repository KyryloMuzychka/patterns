using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    public class Factory
    {     
        public static Position worker;
        public static void AddWorker(string type, string name)
        {
            switch (type)
            {
                case "Director":
                    worker = new Director { Surname = name };
                    break;
                case "Accountant":
                    worker = new Accountant { Surname = name };
                    break;
                case "Consultant":
                    worker = new ConsultantAdapter { Surname = name };
                    break;                                   
            }
            Store.employees.Add(worker);
        }
    }
}
