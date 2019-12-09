using System;
using System.Collections;

namespace lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a_list = new ArrayList();

            a_list.AddRange(new int[] { 5, 10, 23, 108, 4 });
            a_list.Add("See the difference");

            //Console.WriteLine(a_list.Count);
        }
    }
}
