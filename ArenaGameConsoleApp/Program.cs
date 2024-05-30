using ArenaGameEngine;
using ArenaGameEngine.Heroes;
using ArenaGameEngine.Weapons;
using ArenaGameEngine.WeaponAbilities;
using System;
using ArenaGameEngine.BaseClasses.Heroes;
using ArenaGameEngine.BaseClasses.Weapons;
using ArenaGameEngine.WeaponClasses;


namespace ArenaGameConsoleApp
{
    internal class Program
    {

        static void ConsoleNotification(GameEngineRunner.NotificationArgs args){
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} " +
                $"with {Math.Round(args.Attack,2)} " +
                $"and caused {Math.Round(args.Damage, 2)} damage.");
        }
        static void Main(string[] args)
        {
            Weapon swordHeal = new Sword("Sword-Heal", 10, 10, Abilities.SwordAbilityHeal);
            Weapon swordAttack = new Sword("Sword-Attack", 10, 10, Abilities.SwordAbilityAttack);
            Weapon swordArmor = new Sword("Sword-Armor", 10, 10, Abilities.SwordAbilityArmor);

            Weapon dagger = new Dagger("Dagger", 20, 5, Abilities.SwordAbilityAttack);

            Weapon axe = new Axe("Axe", 30, 10, Abilities.AxeAbilityAttack);

            Weapon bow = new Bow("Bow", 20, 0, Abilities.BowAbilityArmor);

            Weapon fists = new Fists("Fists", 10, 5, Abilities.FistAbilityHeal);

            Hero assasinRed = new Assassin("AssasinRed", 10, 20, dagger);
            Hero heavyRed = new Heavy("HeavyRed", 200, 20, 10, axe);
            Hero knightRed = new Knight("KnightRed", 10, 20, swordArmor);
            Hero protectorRed = new Protector("ProtectorRed", 10, 20, bow);
            Hero assasinBlue = new Assassin("AssasinBlue", 10, 20, dagger);
            Hero heavyBlue = new Heavy("HeavyBlue", 200, 20, 10, axe);
            Hero knightBlue = new Knight("KnightBlue", 10, 20, swordArmor);
            Hero protectorBlue = new Protector("AssasinBlue", 10, 20, bow);


            GameEngineRunner game = new GameEngineRunner()
            {
                HeroA = protectorRed,
                HeroB = heavyBlue,
                NotificationsCallBack = ConsoleNotification
            };

            game.Fight();

            Console.WriteLine("AND THE WINNER IIIIIIIIS... *druproll*");
            Console.WriteLine($"{game.Winner}");
        }
    }
}
