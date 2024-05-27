using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine.Weapons
{
    public class Sword : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockPower { get; private set; }

        public Sword(string name)
        {
            Name = name;
            AttackDamage = 20;
            BlockPower = 10;
        }
    }
}
