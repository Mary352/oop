using System;
using System.Collections.Generic;
using System.Text;

namespace lab_12
{
    class LibControl
    {
        private static int count = 0;
        private static double sum = 0;

        private void SeeSomeBooks(int year, Library lib)
        {
            Console.WriteLine($"\nКниги вышедшие не ранее {year} года:");

            foreach (PrintEdit pe in lib.LIST)
            {
                if (pe is Book && !(pe is SchoolBook))
                {
                    if (pe.Year >= year)
                    {
                        Console.WriteLine(pe);
                    }
                }

                sum += pe.Price;
            }
        }

        public int CountSBooks(Library lib)
        {
            foreach (PrintEdit pe in lib.LIST)
            {
                if (pe is SchoolBook)
                {
                    count++;
                }
            }

            return count;
        }

        public double TotalSum(Library lib)
        {
            return sum;
        }

    }
}
