using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------1--------------------------------------------------------------------------------------
            string[] months = { "July", "May", "March", "November", "January", "December", 
                "February", "", "August", "", "June", "April", "October", "September" };

            int n = 8;

            IEnumerable<string> mon1 = months.Where(m => m.Length == n);
            foreach (string mn in mon1)
            {
                Console.Write(mn + " ");
            }
            Console.WriteLine();

            IEnumerable<string> mon2 = months.Where(m => m.StartsWith("J"))
                                             .Concat(months.Where(n => n.StartsWith("Au")));            
            IEnumerable<string> mon3 = months.Where(m => m.StartsWith("D"));

            IEnumerable<string> mon4 = mon2.Union(mon3);
            foreach (string mn in mon4)
            {
                Console.Write(mn + " ");
            }

            IEnumerable<string> monAlph = months.OrderBy(s => s);
            foreach (string mn in monAlph)
            {
                Console.WriteLine(mn);
            }

            int monU = months.Where(s => s.Length > 4)
                .Where(s => s.Contains("u"))
                .Count();
            Console.WriteLine("\n" + monU);

            //---------------------------------2--------------------------------------------------------------------------------------
        }
    }
}
