﻿using System;
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

        public void TakeBook(Book tb)
        {
            if (list.Remove(tb))
            {
                Console.WriteLine("Вы взяли книгу");
            }
        }

        public void TakeSBook(Book tsb)
        {
            if (list.Remove(tsb))
            {
                Console.WriteLine("Вы взяли учебник");
            }
        }

        public void TakeMag(Book tm)
        {
            if (list.Remove(tm))
            {
                Console.WriteLine("Вы взяли журнал");
            }
        }

        public void SeeAll()
        {
            foreach(PrintEdit pe in list)
            {
                Console.WriteLine(pe);
            }
        }
    }
}
