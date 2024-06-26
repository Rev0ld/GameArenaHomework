﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArenaGameEngine.BaseClasses.Weapons;

namespace ArenaGameEngine.BaseClasses.Heroes
{
    public abstract class Hero : IHero
    {
        protected Random random = new Random();
        public string Name { get; private set; }
        public double Health { get; set; }
        public double Armor { get; set; }
        public double Strenght { get; set; }
        public Weapon Weapon { get; private set; }

        public bool IsAlive
        {
            get
            {
                return Health > 0;
            }
        }
        public Hero(string name, double armor, double strenght, Weapon weapon)
        {
            Health = 100;

            Name = name;
            Armor = armor;
            Strenght = strenght;
            Weapon = weapon;
        }

        public virtual double Attack()
        {

            double totalStrenght = Strenght + Weapon.AttackDamage;
            double coef = random.Next(80, 120 + 1);
            double finalAttack = totalStrenght * (coef / 100);

            return finalAttack;
        }
        public virtual double Defend(double damage)
        {

            double coef = random.Next(80, 120 + 1);
            double defendStrenght = (Armor + Weapon.BlockPower) * (coef / 100);
            double damageReceived = damage - defendStrenght;
            if (damageReceived < 0)
                damageReceived = 0;
            Health -= damageReceived;
            return damageReceived;
        }

        public override string ToString() {

            return $"{Name} with health {Math.Round(Health, 2)}";
        }
            
        
    }
}
