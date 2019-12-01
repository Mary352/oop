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

        public PrintEdit()
        { }

        public PrintEdit(string name, string Title, double Price, int Year, int Circul) : base(name)
        {
            total += Circul;
            Name = name;

            title = Title;
            if (Price < 1)
            {
                throw new OverflowException("Цена не должна быть меньше 1 руб.");
            }
            else
            {
                price = Price;
            }

            if (Year < 1900 || Year > DateTime.Now.Year)
            {
                throw new Exceptions.DataEx.YearEx($"Неверно введён год. Допусимый диапазон: 1900-{DateTime.Now.Year} гг.", year);
            }
            else
            {
                year = Year;
            }
            circul = Circul;
        }

        public int Year
        {
            get => year;
            set 
            {
                if (year < 1900 || year > DateTime.Now.Year)
                {
                    throw new Exceptions.DataEx.YearEx($"Неверно введён год. Допусимый диапазон: 1900-{DateTime.Now.Year} гг.", year);
                }
                else
                {
                    year = value;
                }
            }
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
            set 
            {
                if (price < 1)
                {
                    throw new OverflowException("Цена не должна быть меньше 1 руб.");
                }
                else
                {
                    price = value;
                }
            }
        }        

        
    }
}
