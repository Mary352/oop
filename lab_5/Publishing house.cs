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

            public class Book : PrintEdit
            {
                private string aFirstName;
                private string aLastName;

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


                public class SchoolBook : Book
                {

                }
            }

            public class Magazine : PrintEdit
            {
                private int month;
                private string edFirstName;
                private string edLastName;

                public int Month
                {
                    get => month;
                    set => month = value;
                }
            }
        }
    }
}
