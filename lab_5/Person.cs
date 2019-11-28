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

        public override string ToString()
        {
            Console.WriteLine(base.ToString());
            return $"Имя: {firstName}\nФамилия: {lastName}\nВозраст: {age}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Person a = (Person)obj;

            return (this.FirstName == a.FirstName && this.LastName == a.LastName && this.Age == a.Age);

        }

        public override int GetHashCode()
        {
            int hash = 211;

            hash = string.IsNullOrEmpty(firstName) ? 0 : firstName.GetHashCode();
            hash = (hash * 47) + age.GetHashCode();
            return hash;
        }
    }
}
