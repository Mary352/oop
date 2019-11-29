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
            IPH_Person a1 = new Author("Лилиан", "Уайд", 29, "Веселье только начинается...");
            IPH_Person a2 = new Author("Александр", "Сколов", 37, "Философия. Курс лекций");


            Console.WriteLine("Всего книг напечатано " + b2.Count());
            b1.Buy();
            b1.Info();

            Console.WriteLine("Количество авторов: " + a1.Count());
            Console.WriteLine();

            Console.WriteLine(p1.ToString());

            Printer printer = new Printer();
            printer.IAmPrinting(pe);
            
            if (b1 is forPublHouse && pe is forPublHouse && m1 is forPublHouse)
            {
                forPublHouse[] items = { b1, pe, m1 };
                foreach (forPublHouse x in items)
                {
                    printer.IAmPrinting(x);
                }
            }
            else
            {
                Console.WriteLine("Выберите другие объекты для массива");
            }
                      
        }
    }
}
