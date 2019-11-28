using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;


        public Person(string FirstName, string LastName, int Age)
        {
            firstName = FirstName;
            lastName = LastName;
            age = Age;
        }

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

        public int Age
        {
            get => age;
            set => age = value;
        }
    }
}
