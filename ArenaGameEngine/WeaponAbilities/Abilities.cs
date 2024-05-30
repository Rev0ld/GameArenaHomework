using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine.WeaponAbilities
{
    public class Abilities
    {
        public static ReturnInfo SwordAbilityHeal()
        {
            ReturnInfo retunable = new ReturnInfo();
            Random random = new Random();
            double probability = random.NextDouble();
            retunable.Value = 10 * probability;
            retunable.ActionInfo = "Heal";
            return retunable;
        }
        public static ReturnInfo SwordAbilityAttack()
        {
            ReturnInfo retunable = new ReturnInfo();
            Random random = new Random();
            double probability = random.NextDouble();
            retunable.Value = 10 * probability;
            retunable.ActionInfo = "Attack";
            return retunable;
        }
        public static ReturnInfo SwordAbilityArmor()
        {
            ReturnInfo retunable = new ReturnInfo();
            retunable.Value = 5;
            retunable.ActionInfo = "Armor";
            return retunable;
        }
        public static ReturnInfo FistAbilityHeal()
        {
            ReturnInfo retunable = new ReturnInfo();
            retunable.Value = 5;
            retunable.ActionInfo = "Heal";
            return retunable;
        }
        public static ReturnInfo BowAbilityArmor()
        {
            ReturnInfo retunable = new ReturnInfo();
            retunable.Value = 10;
            retunable.ActionInfo = "Armor";
            return retunable;
        }
        public static ReturnInfo AxeAbilityAttack()
        {
            ReturnInfo retunable = new ReturnInfo();
            retunable.Value = 30;
            retunable.ActionInfo = "Attack";
            return retunable;
        }

    }
}
