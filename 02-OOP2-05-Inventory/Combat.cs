using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP2_05_Inventory
{
    internal class Combat
    {
        public Character Fighter1 { get; private set; }
        public Character Fighter2 { get; private set; }
        private Dice _coin = new Dice(2);
        private ILogger _logger;

        public Combat(Character fighter1, Character fighter2, ILogger logger)
        {
            Fighter1 = fighter1;
            Fighter2 = fighter2;
            _logger = logger;
        }

        public void Fight()
        {
            _logger.Log($"Combat: {Fighter1.Name} vs {Fighter2.Name}");
            int round = 1;
            //dokud oba stojí 
            while (Fighter1.IsAlive && Fighter2.IsAlive) 
            {
                //kdo začne
                Character attacker, defender;
                if (_coin.Throw() == 1)
                {
                    attacker = Fighter1;
                    defender = Fighter2;
                }
                else
                {
                    defender = Fighter1;
                    attacker = Fighter2;
                }

                _logger.Log($"Round {round} - {attacker.Name} ({attacker.HP}/{attacker.MaxHP}) attacks {defender.Name} ({defender.HP}/{defender.MaxHP})");

                //útočník zaútočí na obránce
                Round(attacker, defender);

                //pokud je obránce naživu, vymění si role
                if (!defender.IsAlive)
                    break;

                (attacker, defender) = (defender, attacker);

                _logger.Log($"Round {round} - {attacker.Name} ({attacker.HP}/{attacker.MaxHP}) strikes back {defender.Name} ({defender.HP}/{defender.MaxHP})"); Round(attacker, defender);

                round++;
            }
            if (Fighter1.IsAlive)
            {
                _logger.Log($"{Fighter1.Name} wins ({Fighter1.HP}/{Fighter1.MaxHP})");
            }
            else
            {
                _logger.Log($"{Fighter2.Name} wins ({Fighter2.HP}/{Fighter2.MaxHP})");
            }
        }

        private void Round(Character attacker, Character defender)
        {
            int attack = attacker.GetAttack();
            int wound = defender.ResolveAttack(attack);
            _logger.Log($"Attack: {attack}, wound: {wound}");
        }
    }
}
