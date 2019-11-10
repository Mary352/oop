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
        private static int countDel = 0;


        public Stack()
        {
            elements = new int[5];
        }

        public int ElementsUpSort
        {
            get => elements[count + countDel];
            set => elements[count + countDel] = value;
        }

        public int Elements
        {
            get => elements[count];
            set => elements[count] = value;
        }
        //public int[] Elems
        //{
        //    get => elements;
        //    set => elements = value;
        //}
        public bool IsEmpty()
        {
            return elements[saveCount] == 0;
        }

        public int GetElsNum()
        {
            return count;
        }

        public int GetElsNumUpSort()
        {
            return count + countDel;
        }

        //public void CheckStack()
        //{
        //    if (Elements)
        //    {
        //        Console.WriteLine("Стек пуст");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"В стеке есть элементы {sta.GetElsNum() + 1}");
        //    }
        //}
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
            if(count > -1)
            {
                saveCount = count;
            }            
            countDel++;         //учесть кол-во удалённых эл-в
            if(count == -1)
            {
                Console.WriteLine("\nПосле выполнения операции стек пуст");
                count++;
            }

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
            //foreach(int x in elem.elements)
            //{
            //    Console.Write(x + "\t");
            //}
            //Console.WriteLine("");

            Array.Copy(elem.elements, anothStack.elements, 5);  //not saveCount then try elem.elements.Length(was there from the beginning)
            Array.Sort(anothStack.elements);

            //foreach (int o in anothStack.elements)
            //{
            //    Console.Write(o + "\t");
            //}
            //Console.WriteLine("");

            return anothStack;
        }
        public static Stack operator <(Stack elem, Stack anothStack)
        {
            Array.Copy(elem.elements, anothStack.elements, 5);  //not saveCount then try elem.elements.Length(was there from the beginning)
            Array.Sort(anothStack.elements);
            Array.Reverse(anothStack.elements);

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
