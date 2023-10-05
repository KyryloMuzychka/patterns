using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    public class JapanFactory : CountryFactory
    {
        public override Tree CreateTree()
        {
            return new Sakura();
        }
        public override Bush CreateBush()
        {
            return new Kerria();
        }
        public override Flower CreateFlower()
        {
            return new Chrysanthemum();
        }
    }
}
