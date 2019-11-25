using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class Magazine : PrintEdit
    {
        private int month;

        public int Month
        {
            get => month;
            set => month = value;
        }
    }
}
