using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArenaGameEngine.BaseClasses.Heroes;
using ArenaGameEngine.BaseClasses.Weapons;

namespace ArenaGameEngine.Heroes
{
    public class Knight : Hero
    {
        private double hitCount;
        private double damageCoef;
        public Knight(string name, double armor, double strenght, Weapon weapon) : base(name, armor, strenght, weapon)
        {
            hitCount = 0;
            damageCoef = 0.6;
        }

        public override double Attack()
        {
            double damage = 0;
            Weapon weaponTest = Weapon;
            ReturnInfo weaponInfo = weaponTest.UseAbility();
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
            double realDamage = damage * damageCoef;
            if (damageCoef < 1) damageCoef += 0.1;
            return realDamage;
        }

        public override double Defend(double damage)
        {
            hitCount++;
            if (hitCount == 3)
            {
                hitCount = 0;
                return 0;
            }
            return base.Defend(damage);
        }
    }
}