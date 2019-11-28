using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class PrintEdit : PublHouse
    {
        
        private int year;
        private int circul;
        private string title;
        private float price;
        private static int total = 0;

        public PrintEdit(string name, string Title, float Price, int Year, int Circul) : base(name)
        {
            total += Circul;
            Name = name;

            title = Title;
            price = Price;
            year = Year;
            circul = Circul;
        }

        public int Year
        {
            get => year;
            set => year = value;
        }

        public int Circul
        {
            get => circul;
            set => circul = value;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public float Price
        {
            get => price;
            set => price = value;
        }        

        public override void Info()
        {
            Console.WriteLine();
            Console.WriteLine($"Наименование печатного издания '{0}'" + title + " Издательство " + Name + "Год издания " + year);
        }

        public override string ToString()
        {
            Console.WriteLine(base.ToString());
            return $"Издательство: {Name}\nНаименование печатного издания: {title}\nГод издания: {year}\nЦена: {price}\nТираж: {circul}\n";
        }
    }
}
