using System;
using System.Collections.Generic;
using System.Text;

namespace lab_9
{
    class Tank
    {
        private string name;
        public Tank(string Name)
        {
            name = Name;
        }

        public void OnAttack(int dmg)
        {
            Console.WriteLine(name);
            Console.WriteLine($"{-dmg}");
        }

        public void OnHeal(int up)
        {
            Console.WriteLine(name);
            Console.WriteLine("Полностью восстановлено");
        }
    }
}
