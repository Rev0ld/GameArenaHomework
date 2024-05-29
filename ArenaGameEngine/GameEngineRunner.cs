using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class GameEngineRunner
    {
        public class NotificationArgs {

            public Hero Attacker { get; set; }

            public Hero Defender { get; set; }

            public double Attack { get; set; }

            public double Damage { get; set; }
        }

        public delegate void GameNotificationHandler(NotificationArgs args);

        private Random random = new Random();

        public Hero HeroA { get; set; }

        public Hero HeroB { get; set; }

        public Hero Winner { get; set; }

        public GameNotificationHandler? NotificationsCallBack { get; set; }

        public void Fight() {

            Hero attacker;
            Hero defender;

            double probability = random.NextDouble();
            if (probability < 0.5)
            {
                attacker = HeroA;
                defender = HeroB;
            }
            else
            {
                attacker = HeroB;
                defender = HeroA;
            }

            while (attacker.IsAlive) { 
                double attack = attacker.Attack();
                double actualDamage = defender.Defend(attack);

                if (NotificationsCallBack != null) {
                    NotificationsCallBack(new NotificationArgs() { 
                    
                        Attacker = attacker,
                        Defender = defender,
                        Attack = attack,
                        Damage = actualDamage
                    });
                }
                Hero tempHero = attacker;
                attacker = defender;
                defender = tempHero;
            }
            Winner = defender;

        }
    }
}
