using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class Book : PrintEdit, IPH_Person
    {
        private string aFirstName;
        private string aLastName;
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
            Console.WriteLine($"Книга '{Title}'\nАвтор: {aFirstName}. {aLastName}");
        }

        public override int Count()
        {
            return total;
        }

        public override string ToString()
        {
            return $"Издательство: {Name}\nНазвание книги: {Title}\nАвтор: {aLastName} {aFirstName}\nГод издания: {Year}\nЦена: {Price}\nТираж: {Circul}\n";
        }
    }
}
