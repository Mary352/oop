using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    partial class PrintEdit : PublHouse
    {
        
        private int year;
        private int circul;
        private string title;
        private double price;
        private static int total = 0;

        public PrintEdit(string name, string Title, double Price, int Year, int Circul) : base(name)
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

        public double Price
        {
            get => price;
            set => price = value;
        }        

        
    }
}
