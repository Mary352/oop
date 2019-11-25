using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class Land
    {
        public class Continent : Land
        {
            public class State : Continent
            {

            }
        }

        public class Island : Land
        {

        }
    }
}
