using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    public abstract class Character
    {
        static public List<Character> charaters;

        public string name;
        public Power power;
        List<string> weapons;

        public Character()
        {
            if (charaters == null)
            {
                charaters = new List<Character>();
            }
            name = GetType().Name;
            weapons = new List<string>();
            charaters.Add(this);
        }

        public string GetName() { return name; }
        public string Power() { return power.GetPower(); }
        public List<string> GetWeapons() { return weapons; }

        public void AddWeapon(string weapon)
        {
            weapons.Add(weapon);
        }

        public abstract Power CreatePower();
    }
}
