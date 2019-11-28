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
        //private bool isBought = false;
        //private bool isPrinted = false;

        public PrintEdit(string name, string Title, float Price, int Year, int Circul) : base(name)
        {
            total += Circul;

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
            Console.WriteLine($"Книга '{0}'" + Title + " Издательство " + Name);
        }
    }
}
