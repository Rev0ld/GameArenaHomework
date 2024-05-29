using ArenaGameEngine;
using ArenaGameEngine.Heroes;
using ArenaGameEngine.Weapons;


namespace ArenaGameConsoleApp
{
    internal class Program
    {
        static ReturnInfo SwordAbility() { 
            ReturnInfo retunable = new ReturnInfo();
            retunable.Value = 100;
            retunable.ActionInfo = "Heal";
            return retunable;
        }

        static void ConsoleNotification(GameEngineRunner.NotificationArgs args){
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} " +
                $"with {Math.Round(args.Attack,2)} " +
                $"and caused {Math.Round(args.Damage, 2)} damage.");
        }
        static void Main(string[] args)
        {
            GameEngineRunner game = new GameEngineRunner()
            {
                HeroA = new Knight("Knight-1 ", 10, 20, new Sword("Sword", 1, 1,SwordAbility)),
                HeroB = new Knight("Knight-2 ", 10, 20, new Sword("Sword", 1, 1,SwordAbility)),
                NotificationsCallBack = ConsoleNotification
            };

            game.Fight();

            Console.WriteLine("AND THE WINNER IIIIIIIIS... *druproll*");
            Console.WriteLine($"{game.Winner}");
        }
    }
}
