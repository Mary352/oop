using System;
using System.Collections.Generic;
using System.Text;

namespace lab_12
{
    class Magazine : PrintEdit, IPH_Person
    {
        private int month;
        private static int total = 0;

        public Magazine()
        { }
        public Magazine(string name, string title, double price, int year, int circul, int Month) : base(name, title, price, year, circul)
        {
            Title = title;
            Price = price;
            Year = year;
            Circul = circul;
            //new
            if (Month < 1 || Month > 12)
            {
                throw new Exceptions.DataEx.MonthEx("Введите значение месяца от 1 до 12", Month);
            }
            else
            {
                month = Month;
            }

            total += Circul;
        }

        public int Month
        {
            get => month;
            set 
            {
                if (month < 1 || month > 12)
                {
                    throw new Exceptions.DataEx.MonthEx("Введите значение месяца от 1 до 12", month);
                }
                else
                {
                    month = value;
                }
            }
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
