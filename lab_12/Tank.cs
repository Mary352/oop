using System;
using System.Collections.Generic;
using System.Text;

namespace lab_12
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
            Console.WriteLine($"{name}: {-dmg}");
        }

        public void OnHeal(int up)
        {
            Console.WriteLine($"{name} - полностью восстановлено");
        }
    }
}
