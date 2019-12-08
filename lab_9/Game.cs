using System;
using System.Collections.Generic;
using System.Text;

namespace lab_9
{
    //public delegate void ATTACK(int damage);
    //public delegate void HEAL(int up);
    public delegate void Do(int pts);

    class Game
    {
        //public event ATTACK Attack;
        //public void attack(int d)
        //{
        //    Console.WriteLine($"Урон - {d}");
        //}
        //public event HEAL Heal;
        //public void 
        
        public event Do Attack;
        public void attack()
        {
            Console.Write($"Урон - ");
        }

        public event Do Heal;
        public void heal()
        {
            Console.Write($"Восстановление - ");
        }

    }
}
