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

        public SchoolBook(string name, string title, float price, int year, int circul, string aFirName, string aLastName, string genre, int Clas) : base(name, title, price, year, circul, aFirName, aLastName, genre)
        {
            //total += Circul;

            Title = title;
            Price = price;
            Year = year;
            Circul = circul;            
            Genre = genre;
            AFirstName = aFirName;
            ALastName = aLastName;
            //new
            clas = Clas;
        }
    }
}
