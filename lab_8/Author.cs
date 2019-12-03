using System;
using System.Collections.Generic;
using System.Text;

namespace lab_8
{
    sealed class Author : Person
    {
        private string bookTitle;
        private static int count = 0;

        public Author(string firstName, string lastName, int age, string BookTitle) : base(firstName, lastName, age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            //new
            bookTitle = BookTitle;

            count++;
        }

        public string BookTitle
        {
            get => bookTitle;
            set => bookTitle = value;
        }

        public int Count()
        {
            return count;
        }

        public override string ToString()
        {
            return $"Имя: {FirstName}\nФамилия: {LastName}\nВозраст: {Age}\nНазвание книги: {bookTitle}\n";
        }

    }
}
