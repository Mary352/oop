using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class LibControl
    {
        private static int count = 0;
        private static int sum = 0;

        public void SeeSomeBooks(int year, Library<PrintEdit> lib)
        {
            foreach (Book b in lib.LIST)
            {
                if (b.Year >= year)
                {
                    Console.WriteLine(b);                    
                }

                sum += b.Circul;
            }
        }

        public int CountSBooks(Library<PrintEdit> lib)
        {
            foreach (SchoolBook sb in lib.LIST)
            {
                count++;
                sum += sb.Circul;
            }

            return count;
        }

        public int TotalSum(Library<PrintEdit> lib)
        {
            foreach (Magazine m in lib.LIST)
            {
                sum += m.Circul;
            }

            return sum;
        }

    }
}
