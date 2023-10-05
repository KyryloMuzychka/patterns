using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    public class UkraineFactory : CountryFactory
    {
        public override Tree CreateTree()
        {
            return new Oak();
        }
        public override Flower CreateFlower()
        {
            return new Sunflower();
        }
        public override Bush CreateBush()
        {
            return new GuelderRose();
        }
    }

}
