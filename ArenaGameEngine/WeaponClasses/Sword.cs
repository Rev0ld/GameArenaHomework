using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArenaGameEngine.BaseClasses.Weapons;

namespace ArenaGameEngine.Weapons
{
    public class Sword : Weapon
    {

        public Sword(string name, double attackDamage, double blockPower, SpecialAbility specialAbility) 
            : base(name, attackDamage, blockPower, specialAbility)
        {

        }



    }
}
