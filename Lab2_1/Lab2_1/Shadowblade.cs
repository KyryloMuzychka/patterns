using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    public class Shadowblade : Character
    {      
        public override Power CreatePower() { return new ShadowbladePower(); }
       
        public Shadowblade()
        {         
            power = CreatePower();
            AddWeapon("Shadow arrows");
            AddWeapon("Shadowy blade");
            AddWeapon("Shadow camouflage");
        }
    }
}
