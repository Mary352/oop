using System;
using System.Collections.Generic;
using System.Text;

namespace lab_9
{
    class Human
    {
        private string nick;

        public Human(string NICK)
        {
            nick = NICK;
        }

        //public string Nick
        //{
        //    get => nick;
        //    set => nick = value;
        //}

        public void OnAttack()
        {
            Console.WriteLine(nick);

            //Console.WriteLine($"Двойной урон {-dmg}");
        }

        public void OnHeal()
        {
            Console.WriteLine(nick);
            //Console.WriteLine($"+{up}");
        }
    }
}
