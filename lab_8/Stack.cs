using System;
using System.Collections.Generic;
using System.Text;

namespace lab_8
{
    public class CollectionType<U>
    {
        public class Stack<T> : IStack<T> where T : struct
        {           
            private List<T> elements;
            private static int count;          

            public Stack()
            {
                elements = new List<T>();
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
                }

                elements.RemoveRange(0, elements.Count-1);
                Console.WriteLine("\nстек пуст");
            }            
        }
    }
}
