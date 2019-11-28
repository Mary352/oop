using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class PublHouse : forPublHouse
    {
        private string name;
        private static int count = 0;
        
        public PublHouse(string Name)
        {
            name = Name;

            count++;
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

        public override void Buy()
        {
            Console.WriteLine("Куплена книга издательства " + name);
        }

        public override int Count()
        {
            return count;
        }

        public override string ToString()
        {
            Console.WriteLine(base.ToString());
            return $"Издательство: {name}\n";
        }
    }
}
