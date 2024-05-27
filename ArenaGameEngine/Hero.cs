using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public abstract class Hero : IHero
    {
        protected Random random = new Random();
        public string Name { get; private set; }
        public double Health { get; private set; }
        public double Armor { get; private set; }
        public double Strenght { get; private set; }
        public IWeapon Weapon { get; private set; }

        public bool IsAlive
        {
            get
            {
                return Health > 0;
            }
        }
        public Hero(string name, double armor, double strenght, IWeapon weapon)
        {
            Health = 100;

            Name = name;
            Armor = armor;
            Strenght = strenght;
            Weapon = weapon;
        }

        public virtual double Attack() {

            double totalStrenght = Strenght + Weapon.AttackDamage;
            double coef = random.Next(80, 120 + 1);
            double finalAttack = totalStrenght * (coef / 100);

            return finalAttack;
        }
        public virtual double Defend(double damage) {

            double coef = random.Next(80, 120 + 1);
            double defendStrenght = (Armor + Weapon.BlockPower) * (coef / 100);
            double damageReveived = damage - defendStrenght;
            if (damageReveived < 0)
                damageReveived = 0;
            Health -= damageReveived;
            return damageReveived;
        }
    }
}
