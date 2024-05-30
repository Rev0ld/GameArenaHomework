using ArenaGameEngine.BaseClasses.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine.WeaponClasses
{
    public class Axe : Weapon
    {
        public Axe(string name, double attackDamage, double blockPower, SpecialAbility specialAbility) 
            : base(name, attackDamage, blockPower, specialAbility)
        {
        }
    }
}
