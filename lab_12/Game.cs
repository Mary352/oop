﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab_12
{
    public delegate void Do(int pts);

    class Game
    {
        public event Do Attack;
        public void attack(int dmg)
        {
            Console.WriteLine($"\tУРОН");

            //если есть обработчик события, то вызвать событие
            if (Attack != null)  
            {
                Attack(dmg);
            }
        }

        public event Do Heal;
        public void heal(int up)
        {
            Console.WriteLine($"\n   ВОССТАНОВЛЕНИЕ");
            Heal?.Invoke(up);
        }

        public void moveTo(int dmg)
        {
            Console.WriteLine("Вы перешли в квадрат " + dmg);
        }

    }
}
