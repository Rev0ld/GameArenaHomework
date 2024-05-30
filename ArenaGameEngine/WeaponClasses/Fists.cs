using ArenaGameEngine.BaseClasses.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine.WeaponClasses
{
    public class Fists : Weapon
    {
        public Fists(string name, double attackDamage, double blockPower, SpecialAbility specialAbility)
            : base(name, attackDamage, blockPower, specialAbility)
        {
        }
    }
}
