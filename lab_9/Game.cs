using System;
using System.Collections.Generic;
using System.Text;

namespace lab_9
{
    //public delegate void ATTACK();
    //public delegate void HEAL();

    public delegate void Do();

    class Game
    {
        //public event ATTACK Attack;
        //public void attack()
        //{
        //    Console.WriteLine($"Урон:");
        //    if(Attack != null)
        //    {
        //        Attack();
        //    }
        //}

        //public event HEAL Heal;
        //public void heal()
        //{
        //    Console.WriteLine($"\nВосстановление: ");
        //    Heal?.Invoke();
        //}

        public event Do Attack;
        public void attack()
        {
            Console.WriteLine($"Урон:");
            if (Attack != null)
            {
                Attack();
            }
        }

        public event Do Heal;
        public void heal()
        {
            Console.WriteLine($"\nВосстановление: ");
            Heal?.Invoke();
        }

    }
}
