using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    public abstract class CountryFactory
    {
        public abstract Tree CreateTree();
        public abstract Bush CreateBush();
        public abstract Flower CreateFlower();
    }
}
