﻿using System;

namespace lab_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            Human h1 = new Human("Assasin");
            Human h2 = new Human("Svetlaya");
            Human h3 = new Human("Natali");
            Human h4 = new Human("Butterfly");
            Human h5 = new Human("NightHunter");

            Tank t1 = new Tank("Т-54");
            Tank t2 = new Tank("СУ-122");
            Tank t3 = new Tank("С-51");
            Tank t4 = new Tank("СУ-152");
            Tank t5 = new Tank("Т-127");

            game.Attack += new Do(h1.OnAttack);
            game.Heal += new Do(t1.OnHeal);
            game.Attack += new Do(t3.OnAttack);
            game.Attack += new Do(h5.OnAttack);
            game.Heal += new Do(h3.OnHeal);
            game.Attack += new Do(t5.OnAttack);

            game.attack(1000);
            game.heal(237);

            game.Heal -= h3.OnHeal;
            game.heal(254);
        }
    }
}
