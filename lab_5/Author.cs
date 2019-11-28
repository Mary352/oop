using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class Author : Person
    {
        private string bookTitle;
        //private bool isBought = false;
        //private bool isPrinted = false;

        public Author(string firstName, string lastName, int age, string BookTitle) : base(firstName, lastName, age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            //new
            bookTitle = BookTitle;
        }

        public string BookTitle
        {
            get => bookTitle;
            set => bookTitle = value;
        }
    }
}
