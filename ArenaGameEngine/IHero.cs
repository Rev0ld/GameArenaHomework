﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public interface IHero
    {
        double Attack();

        double Defend(double damage);
    }
}
