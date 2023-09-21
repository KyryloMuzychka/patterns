using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    public class Electrophor : Character
    {
       
        public override Power CreatePower() { return new ElectrophorPower(); }

        public Electrophor()
        {            
            power = CreatePower();
            AddWeapon("Electric lightning bolts");
            AddWeapon("Electromagnetic shields");
            AddWeapon("Electric kinetic weapons");
        }
    }
}
