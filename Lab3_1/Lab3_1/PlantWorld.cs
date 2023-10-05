using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    public class PlantWorld
    {
        public Tree tree;
        public Flower flower;
        public Bush bush;

        public PlantWorld(CountryFactory countryFactory)
        {
            tree = countryFactory.CreateTree();
            flower = countryFactory.CreateFlower();
            bush = countryFactory.CreateBush();
        }
    }
}
