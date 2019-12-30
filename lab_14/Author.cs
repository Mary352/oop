using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace lab_14
{
    [Serializable]
    [DataContract]
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

        [DataMember]
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
