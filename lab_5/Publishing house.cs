using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class PublHouse : forPublHouse
    {
        private string name;
        
        public PublHouse(string Name)
        {
            name = Name;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public override void Info()
        {
            Console.WriteLine("Издательство " + name);
        }
    }
}
