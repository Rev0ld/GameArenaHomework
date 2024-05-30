using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArenaGameEngine.BaseClasses.Heroes;
using ArenaGameEngine.BaseClasses.Weapons;

namespace ArenaGameEngine.Heroes
{
    public class Protector : Hero
    {

        public int hitCount { get; private set; }
        public double ArmorValue { get; set; }
        public Protector(string name, double armor, double strenght, Weapon weapon) 
            : base(name, armor, strenght, weapon)
        {
            hitCount = 0;
            ArmorValue = armor;
        }

        public override double Attack() {
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

        public override double Defend(double damage) {
            hitCount = 1;
            double weaponDefendPower = Weapon.BlockPower * 0.2;
            double damageReceived = damage - (Armor + weaponDefendPower);
            Armor = Armor - Armor * 0.1 * hitCount;
            if (hitCount < 8)
            {
                hitCount++;
            }
            else {
                Armor = ArmorValue;
                hitCount = 0;
            }
            if (damageReceived < 0)
                damageReceived = 0;
            Health -= damageReceived;
            return damageReceived;
        }
    }
}
