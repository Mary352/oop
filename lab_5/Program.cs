using System;

namespace lab_5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Person a1 = new Person("Olga", "Sergeeva", 26);
            Console.WriteLine(a1.ToString());

            PrintEdit pe = new PrintEdit("Ветер", "Математика", 7.88, 2019, 250000);
            PublHouse ph = new PublHouse("Аверсев");
            Printer printer = new Printer(ph);
            printer.IAmPrinting(pe);
            pe = pe as PrintEdit;
            //Console.WriteLine(pe is PublHouse);
            //Console.WriteLine(pe is PrintEdit);
            //Console.WriteLine(pe is Book);
            //Console.WriteLine(pe is Magazine);
            //Console.WriteLine(pe is SchoolBook);


            //Console.WriteLine(pe.ToString()); ;
        }
    }
}
