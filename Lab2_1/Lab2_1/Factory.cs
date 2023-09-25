using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    public static class Factory
    {
        public static void CreateFactory()
        {
            Character ch1 = new Electrophor();
            Character ch2 = new Shadowblade();
            Character ch3 = new Volcano();
        }        
    }
}
