using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine.Weapons
{
    public class Dagger : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockPower { get; private set; }

        public Dagger(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockPower = 1;
        }
    }
}
