using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    public class SeaAnimalFactory : AnimalFactory
    {
        public override Animal GetAnimal(string AnimalType)
        {
            switch (AnimalType)
            {
                case "Octopus":
                    return new Octopus();
                case "Shark":
                    return new Shark();
                default:
                    return null;
            }
        }
    }
}
