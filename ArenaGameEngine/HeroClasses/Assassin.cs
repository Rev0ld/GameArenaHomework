using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArenaGameEngine.BaseClasses.Heroes;
using ArenaGameEngine.BaseClasses.Weapons;

namespace ArenaGameEngine.Heroes
{
    public class Assassin : Hero
    {
        public Assassin(string name, double armor, double strenght, Weapon weapon) :
            base(name, armor, strenght, weapon)
        {
        }

        public override double Attack()
        {
            double damage = 0;
            Weapon weaponWield = Weapon;
            ReturnInfo weaponInfo = weaponWield.UseAbility();
            switch (weaponInfo.ActionInfo)
            {
                case "Attack":
                    damage = base.Attack() + weaponInfo.Value;
                    break;
                case "Heal":
                    damage = base.Attack();
                    Health += weaponInfo.Value;
                    break;
                case "Armor":
                    damage = base.Attack();
                    Armor += weaponInfo.Value;
                    break;
                default:
                    damage = base.Attack();
                    break;
            }
            double realDamage = damage;
            return realDamage;
        }
    }
}
