using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace lab_12
{
    class Book : PrintEdit, IPH_Person
    {
        public string aFirstName;
        public string aLastName;
        private static int total = 0;

        public Book(string name, string title, double price, int year, int circul, string AFirName, string ALastName) : base(name, title, price, year, circul)
        {            
            Title = title;
            Price = price;
            Year = year;
            Circul = circul;
            //new
            aFirstName = AFirName;
            aLastName = ALastName;

            total += Circul;
        }

        public Book()
        { }

        public string AFirstName
        {
            get => aFirstName;
            set => aFirstName = value;
        }

        public string ALastName
        {
            get => aLastName;
            set => aLastName = value;
        }

        public override void Info()
        {
            char init = aFirstName[0];
            Console.WriteLine($"Книга '{Title}'\nАвтор: {init}.{aLastName}\n");
        }

        public override int Count()
        {
            Debug.Assert(total < 0, "Общий тираж книг не может иметь отрицательное значение");
            return total;
        }

        public override string ToString()
        {
            return $"Издательство: {Name}\nНазвание книги: {Title}\nАвтор: {aLastName} {aFirstName}\nГод издания: {Year}\nЦена: {Price}\nТираж: {Circul}\n";
        }
    }
}
