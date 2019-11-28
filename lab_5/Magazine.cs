using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class Magazine : PrintEdit
    {
        private int month;

        public Magazine(string name, string title, float price, int year, int circul, int Month) : base(name, title, price, year, circul)
        {
            //total += Circul;

            Title = title;
            Price = price;
            Year = year;
            Circul = circul;
            //new
            month = Month;
        }

        public int Month
        {
            get => month;
            set => month = value;
        }
    }
}
