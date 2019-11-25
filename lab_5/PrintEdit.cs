using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class PrintEdit : PublHouse
    {
        private string isbn;
        private int year;
        private int circul;
        private string title;
        private float price;
        private string aFirstName;
        private string aLastName;
        private bool isBought = false;
        private bool isPrinted = false;

        public string ISBN
        {
            get => isbn;
            set => isbn = value;
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

        public float Price
        {
            get => price;
            set => price = value;
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
    }
}
