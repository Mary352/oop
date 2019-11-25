using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class Person
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public class Author
        {
            private string bookTitle;
            private bool isBought = false;
            private bool isPrinted = false;

            public string BookTitle
            {
                get => bookTitle;
                set => bookTitle = value;
            }
        }
    }
}
