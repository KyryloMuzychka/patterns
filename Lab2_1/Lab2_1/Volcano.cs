using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class Volcano : Character
    {
        public override Power CreatePower() { return new VolcanoPower(); }

        public Volcano()
        {  
            power = CreatePower();
            AddWeapon("Fiery bullets");
            AddWeapon("Lava streams");
            AddWeapon("Fiery sword");
        }        
    }
}
