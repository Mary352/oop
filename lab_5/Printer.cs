using System;
using System.Collections.Generic;
using System.Text;

namespace lab_5
{
    class Printer
    {
        private forPublHouse fPH;

        public Printer(forPublHouse fph)
        {
            fPH = fph;
        }

        public virtual void IAmPrinting(forPublHouse fph)
        {
            Console.WriteLine("Тип объекта: " + fph.GetType().Name);
            Console.WriteLine();
            Console.WriteLine(fph.ToString());
        }
    }
}
