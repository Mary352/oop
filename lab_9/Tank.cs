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

        public void OnAttack()
        {
            Console.WriteLine(name);
            //Console.WriteLine($"{-dmg}");
        }

        public void OnHeal()
        {
            //Console.WriteLine(name);
            Console.WriteLine($"{name} - полностью восстановлено");
        }
    }
}
