﻿using System;
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
            double damage = base.Attack();

            double probability = random.NextDouble();
            if (probability < 0.10)
            {
                damage *= 3;
            }
            return damage;
        }
    }
}
