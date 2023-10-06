using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_1
{
    public class Factory
    {
        public static UkraineFactory ukraineFactory;
        public static JapanFactory japanFactory;
        public static PlantWorld world;
        
        public static void CreateUkraineFactory()
        {            
            ukraineFactory = new UkraineFactory();
        }

        public static void CreateJapanFactory()
        {
            japanFactory = new JapanFactory();
        }

        public static void CreatePlantWorld(CountryFactory countryFactory)
        {
            world = new PlantWorld(countryFactory);
        }
    }
}
