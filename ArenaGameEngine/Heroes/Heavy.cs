using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine.Heroes
{
    public class Heavy : Hero
    {
        public double BaseHealth { get; set; }
        public int bleedTick { get; set; }
        public Heavy(string name,double health, double armor, double strenght, Weapon weapon) 
            : base(name, armor, strenght, weapon)
        {
            Health = health;
            BaseHealth = health;
            bleedTick = 0;
        }

        public override double Attack()
        {
            if (bleedTick < 10)
            {
                bleedTick++;
                Health = Health - Health * 0.05;
                return (Strenght + Weapon.AttackDamage) * 0.8;
            }
            else {
                bleedTick = 0;
                Health = Health + BaseHealth * 0.2;
                return 0;
            }
            
        }
        public override double Defend(double damage)
        {
            if (bleedTick < 10)
            {
                bleedTick++;
                Health = Health - Health * 0.05;
            }
            else
            {
                bleedTick = 0;
                Health = Health + BaseHealth * 0.35; 
            }
            double coef = random.Next(80, 100 + 1);
            double defendStrenght = (Armor + Weapon.BlockPower) * (coef / 100);
            double damageReceived = damage - defendStrenght;
            if (damageReceived < 0)
                damageReceived = 0;
            Health -= damageReceived;
            return damageReceived;
        }


    }
}
