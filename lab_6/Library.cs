using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class Library
    {
        private List<PrintEdit> list = new List<PrintEdit>();

        public List<PrintEdit> LIST
        {
            get => list;
            set => list = value;
        }
        
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
