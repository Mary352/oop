using System;
using System.Collections.Generic;
using System.Text;

namespace lab_12
{
    partial class PrintEdit : PublHouse
    {
        public override void Info()
        {
            Console.WriteLine();
            Console.WriteLine($"Наименование печатного издания '{0}'" + title + " Издательство " + Name + "Год издания " + year);
        }

        public override string ToString()
        {
            return $"Издательство: {Name}\nНаименование печатного издания: {title}\nГод издания: {year}\nЦена: {price}\nТираж: {circul}\n";
        }
    }
}
