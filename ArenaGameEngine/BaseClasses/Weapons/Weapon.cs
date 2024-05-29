using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine.BaseClasses.Weapons
{

    public delegate ReturnInfo SpecialAbility();
    public abstract class Weapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; }

        public double BlockPower { get; }

        public SpecialAbility SpecialAbility;

        public Weapon(string name, double attackDamage, double blockPower, SpecialAbility specialAbility) { 
            
            Name = name;
            AttackDamage = attackDamage;
            BlockPower = blockPower;
            SpecialAbility = specialAbility;
        }

        public ReturnInfo UseAbility() { 
            ReturnInfo returnInfo = SpecialAbility.Invoke();
            return returnInfo;
        }
    }
}
