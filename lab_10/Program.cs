using System;
using System.Collections;

namespace lab_10
{
    class Program
    {
        public void Show()

        static void Main(string[] args)
        {
            ArrayList a_list = new ArrayList();

            a_list.AddRange(new int[] { 5, 10, 23, 108, 4 });
            a_list.Add("See the difference");
            a_list.Add(new Student());

            a_list.RemoveAt(a_list.Count-1);

            Console.WriteLine("Number of elements: " + a_list.Count);
            Console.WriteLine("Elements in a_list:");
            foreach (var item in a_list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Index of 23: " + a_list.IndexOf(23));

        }
    }
}
