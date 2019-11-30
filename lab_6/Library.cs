using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class Library<PrintEdit>
    {
        private List<Book> liBooks;
        private List<Magazine> liMags;
        private List<SchoolBook> liSBooks;
        private static int count = 0;

        public void AddBook(Book b)
        {
            liBooks.Add(b);
        }

        public void AddSBook(SchoolBook sb)
        {
            liSBooks.Add(sb);
            count++;
        }

        public void AddMag(Magazine m)
        {
            liMags.Add(m);
        }

        public void SeeSomeBooks(int year)
        {            
            foreach (Book b in liBooks)
            {                
                if (b.Year >= year)
                {
                    Console.WriteLine(b);
                }                
            }
        }

        public int CountSBooks()
        {
            return count;
        }
    }
}
