using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    public class Factory
    {

        static public AnimalFactory environmentFactory;
        public static void CreateAnimalFactory(string typeEnvironment)
        {
            switch(typeEnvironment)
            {
                case "Land":
                    environmentFactory = new LandAnimalFactory();
                    break;
                case "Sea":
                    environmentFactory = new SeaAnimalFactory();
                    break;
            }
        }
        static public Animal animal;
        public static void CreateAnimal(string selectedAnimal)
        {
            switch (selectedAnimal)
            {
                case "Dog":
                    animal = environmentFactory.GetAnimal("Dog");              
                    break;
                case "Cat":
                    animal = environmentFactory.GetAnimal("Cat");                   
                    break;
                case "Lion":
                    animal = environmentFactory.GetAnimal("Lion");                 
                    break;
                case "Octopus":
                    animal = environmentFactory.GetAnimal("Octopus");                   
                    break;
                case "Shark":
                    animal = environmentFactory.GetAnimal("Shark");
                    break;
            }
        }
        static public SoundPlayer soundPlayer;
    }
}
