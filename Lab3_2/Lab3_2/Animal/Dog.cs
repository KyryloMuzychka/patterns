using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    public class Dog : Animal
    {
        public override string Speak() { return "Bar"; }
        public override UnmanagedMemoryStream Sound() { return Properties.Resources.barking; }
    }
}
