using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class Magazine : PrintEdit
    {
        private int month;
        private static int total = 0;

        public Magazine(string name, string title, double price, int year, int circul, int Month) : base(name, title, price, year, circul)
        {
            Title = title;
            Price = price;
            Year = year;
            Circul = circul;
            //new
            month = Month;
        
            total += Circul;
        }

        public int Month
        {
            get => month;
            set => month = value;
        }

        public override int Count()
        {
            return total;
        }

        public override string ToString()
        {
            return $"Издательство: {Name}\nНазвание журнала: {Title}\nДата издания: {month}/{Year}\nЦена: {Price}\nТираж: {Circul}\n";
        }
    }
}
