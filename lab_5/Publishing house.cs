using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class PublHouse : forPublHouse
    {
        private string name;
        

        public string Name
        {
            get => name;
            set => name = value;
        }

        public class PrintEdit : PublHouse
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

            public class Book : PrintEdit
            {
                public string genre;

                public string Genre
                {
                    get => genre;
                    set => genre = value;
                }

                public class SchoolBook : Book
                {
                    private int clas;

                    public int Clas
                    {
                        get => clas;
                        set => clas = value;
                    }
                }
            }

            public class Magazine : PrintEdit
            {
                private int month;

                public int Month
                {
                    get => month;
                    set => month = value;
                }
            }
        }
    }
}
