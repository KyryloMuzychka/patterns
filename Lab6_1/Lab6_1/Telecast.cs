using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    public class Telecast
    {
        public string Name { get; set; }

        public Telecast(string name)
        {
            Name = name;
        }
        
        public static Telecast CreateTelecast(string name)
        {
            return new Telecast(name);
        }
    }
}