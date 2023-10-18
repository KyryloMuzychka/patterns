using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    public class Factory
    {
        public static CountryFactory countryFactory;
        public static PlantWorld world;
        
        public static void CreateCountryFactory(string typeFactory)
        {
            switch(typeFactory) {
                case "Ukraine":
                    countryFactory = new UkraineFactory();
                    break;
                case "Japan":
                    countryFactory = new JapanFactory();
                    break;
            }           
        }
        public static void CreatePlantWorld()
        {
            world = new PlantWorld(countryFactory);
        }
    }
}
