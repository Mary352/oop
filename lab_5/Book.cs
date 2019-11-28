﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class Book : PrintEdit
    {
        private string genre;
        private string aFirstName;
        private string aLastName;

        public Book(string name, string title, float price, int year, int circul, string AFirName, string ALastName, string Genre) : base(name, title, price, year, circul)
        {
            //total += Circul;
            
            Title = title;
            Price = price;
            Year = year;
            Circul = circul;
            //new
            genre = Genre;
            aFirstName = AFirName;
            aLastName = ALastName;
        }
        public string Genre
        {
            get => genre;
            set => genre = value;
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
            Console.WriteLine("Жанр " + genre);
        }
    }
}
