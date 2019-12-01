using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class SchoolBook : Book
    {
        private int clas;

        public int Clas
        {
            get => clas;
            set => clas = value;
        }

        public SchoolBook(string name, string title, double price, int year, int circul, string aFirName, string aLastName, int Clas) : base(name, title, price, year, circul, aFirName, aLastName)
        {
            Title = title;
            Price = price;
            Year = year;
            Circul = circul;
            AFirstName = aFirName;
            ALastName = aLastName;
            //new
            clas = Clas;
        }

        public override string ToString()
        {
            return $"Издательство: {Name}\nНазвание книги: {Title}\nАвтор: {ALastName} {AFirstName}\nГод издания: {Year}\nЦена: {Price}\nТираж: {Circul}\n";
        }
    }
}
