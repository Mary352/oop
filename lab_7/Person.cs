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
            if (Age < 18)
            {
                throw new Exceptions.AgeEx("Произведения лиц младше 18 лет в издательство не принимаются");
            }
            else
            {
                age = Age;
            }
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
            set
            {
                if (age < 18)
                {
                    throw new Exceptions.AgeEx("Произведения лиц младше 18 лет в издательство не принимаются");
                }
                else
                {
                    age = value;
                }

            }
        }

        public override string ToString()
        {
            return $"Имя: {firstName}\nФамилия: {lastName}\nВозраст: {age}\n";
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
