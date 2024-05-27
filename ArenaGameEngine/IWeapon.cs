using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public interface IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get;}

        public double BlockPower { get;}
    }
}
