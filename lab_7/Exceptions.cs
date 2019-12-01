using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace lab_5
{
    class Exceptions : ArgumentException
    {
        public Exceptions(string message) : base(message) { }

        public class DataEx : Exceptions
        {
            public int Value { get; set; }
            public DataEx(string message) : base(message){}

            public class YearEx : DataEx
            {
                public YearEx(string message, int val) : base(message)
                {
                    Value = val;
                }
            }

            public class MonthEx : YearEx
            {
                public MonthEx(string message, int v) : base(message, v)
                {
                    Value = v;
                }
            }
        }        

        public class AgeEx : Exceptions
        {
            public AgeEx(string message) : base(message) { }
        }
    }
}
