using System;
using System.Collections.Generic;
using System.Text;

namespace lab_12
{
    class Human
    {
        private string nick;

        public Human(string NICK)
        {
            nick = NICK;
        }

        public void OnAttack(int dmg)
        {
            dmg = (dmg / 2) + 21;

            Console.WriteLine($"{nick}: двойной урон {-dmg}");
        }

        public void OnHeal(int up)
        {
            Console.WriteLine($"{nick}: +{up}");
        }
    }
}
