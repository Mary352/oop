using System;

namespace lab_5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Magazine m1 = new Magazine("Альфа-книга", "Вокруг света", 2.57, 2019, 9585, 5);
            Person p1 = new Person("Анна", "Сергеева", 26);
            PrintEdit pe = new PrintEdit("Ветер", "Математика", 7.88, 2019, 250000);
            PublHouse ph = new PublHouse("Аверсев");
            Book b1 = new Book("АСТ", "Виновато море", 14.29, 2019, 3000, "Люси", "Кларк");
            Book b2 = new Book("АСТ", "Код да Винчи", 11.77, 2019, 5400, "Дэн", "Браун");

            Console.WriteLine("Всего книг напечатано " + b2.Count());
            b1.Buy();
            b1.Info();

            Console.WriteLine(p1.ToString());

            Printer printer = new Printer();
            printer.IAmPrinting(pe);
            pe = pe as PrintEdit;

            //forPublHouse[] items = {}


            //Console.WriteLine(pe.ToString()); ;
        }
    }
}
