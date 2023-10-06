using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    public class CreateSoundFactory
    {
        static public SoundPlayer CreateSoundOfAnimal() 
        {
           return new SoundPlayer();
        }
    }
}
