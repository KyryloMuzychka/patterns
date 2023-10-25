using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    public class Director : Position
    {
        public string Surname { get; set; }
        public string Work()
        {
            return "Leads company";
        }
    }
}
