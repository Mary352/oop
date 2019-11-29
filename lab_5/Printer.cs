using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class Printer
    {
        public virtual void IAmPrinting(forPublHouse fph)
        {
            Console.WriteLine("Тип объекта: " + fph.GetType().Name);
            Console.WriteLine(fph.ToString());
        }
    }
}
