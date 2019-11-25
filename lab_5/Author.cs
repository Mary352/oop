using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class Author : Person
    {
        private string bookTitle;
        private bool isBought = false;
        private bool isPrinted = false;

        public string BookTitle
        {
            get => bookTitle;
            set => bookTitle = value;
        }
    }
}
