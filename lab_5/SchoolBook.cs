using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class SchoolBook : Book
    {
        private int clas;

        public int Clas
        {
            get => clas;
            set => clas = value;
        }
    }
}
