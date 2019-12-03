﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4__recovery_
{
    public class CollectionType<T>
    {
        public class Stack<T> where T : struct
        {
            private T[] elements2;
            private List<T> elements;
            private static int count;
            private static int count2 = -1;
            private static int saveCount;
            private static int countDel = 0;

            //*
            public Stack()
            {
                elements = new List<T>();
                //elements = null;
            }

            public void AddEl(T data)
            {
                elements.Add(data);
                count = elements.Count - 1;
            }

            public void DelEl()
            {
                elements.RemoveAt(elements.Count-1);
                count = elements.Count - 1;
            }

            public void SeeAll()
            {
                elements.Reverse();

                foreach (T el in elements)
                {
                    Console.WriteLine($"Element {count--}: " + el);
                    //elements.RemoveAt(elements.Count - 1);
                }

                elements.RemoveRange(0, elements.Count-1);
                Console.WriteLine("\nстек пуст");
            }

            //public Stack()
            //{
            //    elements2 = new T[5];
            //}

            public T ElementsUpSort
            {
                get => elements2[count2 + countDel];
                set => elements2[count2 + countDel] = value;
            }

            public T Elements
            {
                get => elements2[count2];
                set => elements2[count2] = value;
            }

            public T[] Elems
            {
                get => elements2;
                set => elements2 = value;
            }

            public bool IsEmpty()
            {
                return count2 == -1;
            }

            public int GetElsNum()
            {
                return count2;
            }

            public void AddEl2(T data)
            {
                count2++;
                saveCount = count2;
                elements2[count2] = data;
            }

            public void DelEl2()
            {
                elements2[count2] = default(T);

                count2--;

                if (count2 > -1)
                {
                    saveCount = count2;
                }

                countDel++;         //учесть кол-во удалённых эл-в

                if (count2 == -1)
                {
                    Console.WriteLine("\nПосле выполнения операции стек пуст");
                    count2++;
                }
            }

            public void SeeAll2()
            {
                for (int i = 0; i < count2; i++)
                {

                }

                Console.WriteLine("\nстек пуст");
            }

            //public static T operator +(T data, CollectionType<T>.Stack<T> elems)
            //{
            //    count++;
            //    saveCount = count;
            //    elems.elements[count] = data;
            //    return elems.elements[count];
            //}

            //public static CollectionType<T>.Stack<T> operator --(CollectionType<T>.Stack<T> elem)
            //{
            //    elem.elements[count] = default(T);
            //    count--;
            //    if (count > -1)
            //    {
            //        saveCount = count;
            //    }
            //    countDel++;         //учесть кол-во удалённых эл-в
            //    if (count == -1)
            //    {
            //        Console.WriteLine("\nПосле выполнения операции стек пуст");
            //        count++;
            //    }

            //    return elem;
            //}
            //public static bool operator true(CollectionType<T>.Stack<T> stack)
            //{
            //    if (stack.IsEmpty())
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}
            //public static bool operator false(CollectionType<T>.Stack<T> stack)
            //{
            //    if (!stack.IsEmpty())
            //    {
            //        return false;
            //    }
            //    else
            //    {
            //        return true;
            //    }
            //}
            //public static CollectionType<T>.Stack<T> operator >(CollectionType<T>.Stack<T> elem, CollectionType<T>.Stack<T> anothStack)
            //{
            //    //foreach(int x in elem.elements)
            //    //{
            //    //    Console.Write(x + "\t");
            //    //}
            //    //Console.WriteLine("");

            //    Array.Copy(elem.elements, anothStack.elements, 5);  //not saveCount then try elem.elements.Length(was there from the beginning)
            //    Array.Sort(anothStack.elements);

            //    //foreach (int o in anothStack.elements)
            //    //{
            //    //    Console.Write(o + "\t");
            //    //}
            //    //Console.WriteLine("");

            //    return anothStack;
            //}

            //public static CollectionType<T>.Stack<T> operator <(CollectionType<T>.Stack<T> elem, CollectionType<T>.Stack<T> anothStack)
            //{
            //    Array.Copy(elem.elements, anothStack.elements, 5);  //not saveCount then try elem.elements.Length(was there from the beginning)
            //    Array.Sort(anothStack.elements);
            //    Array.Reverse(anothStack.elements);

            //    return anothStack;
            //}

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
}
