using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    public class Cat : Animal
    {
        public override string Speak() { return "Meow"; }
        public override UnmanagedMemoryStream Sound() { return Properties.Resources.meow; }
    }
}
