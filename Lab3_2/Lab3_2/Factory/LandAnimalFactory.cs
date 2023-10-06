using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    public class LandAnimalFactory : AnimalFactory
    {
        public override Animal GetAnimal(string AnimalType)
        {
            switch (AnimalType)
            {
                case "Lion":
                    return new Lion();
                case "Dog":
                    return new Dog();
                case "Cat":
                    return new Cat();
                default:
                    return null;
            }
        }
    }
}
