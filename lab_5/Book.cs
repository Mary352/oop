using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class Book : PrintEdit
    {
        private string genre;

        public string Genre
        {
            get => genre;
            set => genre = value;
        }
    }
}
