using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class Library
    {
        private List<PrintEdit> list = new List<PrintEdit>();        //private PrintEdit a = new PrintEdit();
        

        public List<PrintEdit> LIST
        {
            get => list;
            set => list = value;
        }
        //private static int count = 0;

        //private List<Book> liBooks;
        //private List<Magazine> liMags;
        //private List<SchoolBook> liSBooks;

        //public void AddEdit(Book pe)
        //{
        //    //object a = (Object)pe;
        //    list.Add(pe);
        //}

        public void AddBook(Book b)
        {
            list.Add(b);
        }

        public void AddSBook(SchoolBook sb)
        {
            list.Add(sb);
        }

        public void AddMag(Magazine m)
        {
            list.Add(m);
        }
    }
}
