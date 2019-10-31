using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4__recovery_
{
    class Stack
    {
        private int[] elements;
        private static int count = -1;
        private static int saveCount;

        public Stack()
        {
            elements = new int[5];
        }

        public int Elements
        {
            get => elements[count];
            set => elements[count] = value;
        }
        public int[] Elems
        {
            get => elements;
            set => elements = value;
        }
        public bool IsEmpty()
        {
            return elements[saveCount] == 0;
        }

        public int GetElsNum()
        {
            return count;
        }
        public static int operator +(int data, Stack elems)
        {
            count++;
            saveCount = count;
            elems.elements[count] = data;
            return elems.elements[count];
        }

        public static Stack operator --(Stack elem)
        {
            elem.elements[count] = 0;
            count--;
            saveCount = count;

            return elem;
        }
        public static bool operator true(Stack stack)
        {
            if(stack.IsEmpty())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator false(Stack stack)
        {
            if (!stack.IsEmpty())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static Stack operator >(Stack elem, Stack anothStack)
        {
            Array.Copy(elem.elements, anothStack.elements, 5);  //not saveCount then try elem.elements.Length(was there from the beginning)
            Array.Sort(anothStack.elements);
            
            return anothStack;
        }
        public static Stack operator <(Stack elem, Stack anothStack)
        {
            int[] arrSave = new int[5];

            Array.Copy(elem.elements, arrSave, saveCount);  //not saveCount then try elem.elements.Length(was there from the beginning)

            Array.Sort(arrSave);
            Array.Reverse(arrSave);

            Array.Copy(arrSave, anothStack.elements, saveCount);

            return anothStack;
        }

        public class Owner
        {
            private string name;
            private int id;
            private string organization;

            public Owner(string _name, int _id, string _organization)
            {
                name = _name;
                id = _id;
                organization = _organization;
            }

            public void GetInfo()
            {
                Console.WriteLine($"Имя создателя: {name}  " +
                    $"ID создателя: {id}  Организация создателя: {organization}");
            }

        }

        public class Date
        {
            private int day;
            private int month;
            private int year;

            public Date(int _day, int _month, int _year)
            {
                day = _day;
                month = _month;
                year = _year;
            }

            public void GetDate()
            {
                Console.WriteLine($"{day}.{month}.{year}");
            }
        }
    }
}
