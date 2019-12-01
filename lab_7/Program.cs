using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;

namespace lab_5
{
    class Program
    {
        enum Choice
        {
            Book = 1,
            SCHOOLBOOK,
            MAGAZINE
        }

        static void Choose(Choice ch)
        {
            switch (ch)
            {
                case Choice.Book:
                    Console.WriteLine("Вы выбрали книгу");
                    break;
                case Choice.SCHOOLBOOK:
                    Console.WriteLine("Вы выбрали учебник");
                    break;
                case Choice.MAGAZINE:
                    Console.WriteLine("Вы выбрали журнал");
                    break;
            }
        }

        struct LIBRARY
        {
            private Book[] books;
            private SchoolBook[] sbooks;
            private Magazine[] mags;
            private static int count;
            private static double sum;

            public LIBRARY(Book[] books, SchoolBook[] sbooks, Magazine[] mags, int Count = 0, double Sum = 0)
            {
                this.books = books;
                this.sbooks = sbooks;
                this.mags = mags;

                if(Count != 0)                
                    count = 0;                
                else
                    count = Count;

                if (Sum != 0)
                    sum = 0;
                else
                    sum = Sum;


            }

            public void DisplayBooks(int year)
            {
                Console.WriteLine($"Книги вышедшие не ранее {year} года:");

                foreach (Book item in books)
                {
                    if (item.Year >= year)
                    {
                        Console.WriteLine(item);
                    }

                    sum += item.Price;
                }
            }

            public int NumSBooks()
            {
                foreach (SchoolBook item in sbooks)
                {
                    count++;

                    sum += item.Price;
                }

                return count;
            }

            public double SumPrice()
            {
                foreach (Magazine item in mags)
                {
                    sum += item.Price;
                }

                return sum;
            }

            
        }
        
        static void Main(string[] args)
        {   try
            {

                Book b1 = new Book("АСТ", "Виновато море", 14.29, 2019, 3000, "Люси", "Кларк");
                Book b2 = new Book("АСТ", "Код да Винчи", 11.77, 2017, 5400, "Дэн", "Браун");
                Book b3 = new Book("Свет", "Веселье только начинается...", 12.68, 2013, 6785, "Лилиан", "Уайд");
                Book b4 = new Book("Барс", "Зимний ветер", 15.36, 2014, 8425, "Алиса", "Чудная");

                SchoolBook sb1 = new SchoolBook("Ветер", "Математика", 6.88, 2015, 250000, "Анастасия", "Гриненко", 5);
                SchoolBook sb2 = new SchoolBook("Белый ветер", "Геометрия", 5.98, 2013, 150000, "Анастасия", "Гриненко", 8);

                Magazine m1 = new Magazine("Альфа-книга", "Вокруг света", 2.57, 2019, 9585, 5);
                Magazine m2 = new Magazine("Дождь", "Один дома", 2.46, 2018, 9655, 12);
                Magazine m3 = new Magazine("Факел", "Банзай. Японский кроссворд", 1.99, 2010, 9655, 8);

               
               
                //Book[] books = new Book[] { b1, b2, b3, b4 };
                //SchoolBook[] sbooks = new SchoolBook[] { sb2, sb1 };
                //Magazine[] mags = new Magazine[] { m1, m2, m3 };

                //LIBRARY lib = new LIBRARY(books, sbooks, mags);

                //lib.DisplayBooks(2014);
                //Console.WriteLine($"Количество учебников в библиотеке: {lib.NumSBooks()}");
                //Console.WriteLine($"Суммарная стоимость изданий в библиотеке: {lib.SumPrice()}\n");

                //--------------Exception-----------------------------------------------------------------------------------------
                /*Exceptions.AgeEx*/
                //Author a1 = new Author("Анастасия", "Гриненко", 17, "Математика");

                /*Exceptions.DataEx.YearEx*/
                //Book b5 = new Book("Свет", "Веселье только начинается...", 12.68, 1813, 6785, "Лилиан", "Уайд");
                //SchoolBook sb3 = new SchoolBook("Белый ветер", "Геометрия", 5.98, 4125, 150000, "Анастасия", "Гриненко", 8);

                /*Exceptions.DataEx.MonthEx*/
                //Magazine m4 = new Magazine("Факел", "Банзай. Японский кроссворд", 1.99, 2010, 9655, 15);

                //Book b6 = new Book("Свет", "Веселье только начинается...", 12.68, 2010, 6785, "Светлана", "Оскар");
                //Debug.Assert(b6.AFirstName != "Светлана", "Введите другое имя");

                /*OverflowException*/
                SchoolBook sb4 = new SchoolBook("Белый ветер", "Геометрия", -5.98, 2013, 150000, "Анастасия", "Гриненко", 8);
                //------------------------------------------------------------------------------------------------------------------

                Choose(Choice.Book);
                Choose(Choice.MAGAZINE);

                
                Library libra = new Library();

                libra.AddBook(b1);
                libra.AddSBook(sb2);
                libra.AddMag(m1);
                libra.AddBook(b2);
                libra.AddBook(b3);
                libra.AddMag(m2);
                libra.AddBook(b4);
                libra.AddMag(m3);
                libra.AddSBook(sb1);

                LibControl lc = new LibControl();
                lc.SeeSomeBooks(2014, libra);
                Console.WriteLine($"Количество учебников в библиотеке: {lc.CountSBooks(libra)}");
                Console.WriteLine($"Суммарная стоимость изданий в библиотеке: {lc.TotalSum(libra)}\n");

                libra.SeeAll();
                libra.TakeBook(b3);
                libra.SeeAll();
            }
            catch (Exceptions.DataEx.MonthEx ex)
            {
                var LineNumber = new StackTrace(ex, true).GetFrame(0).GetFileLineNumber();
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.WriteLine("Некорректное значение: " + ex.Value);
                Console.WriteLine("Строка: " + LineNumber);
            }
            catch (Exceptions.DataEx.YearEx ex)
            {
                var LineNumber = new StackTrace(ex, true).GetFrame(0).GetFileLineNumber();
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.WriteLine("Некорректное значение: " + ex.Value);
                Console.WriteLine("Строка: " + LineNumber);
            }
            
            catch (Exceptions.AgeEx ex)
            {

                var LineNumber = new StackTrace(ex, true).GetFrame(0).GetFileLineNumber();
                Console.WriteLine("Ошибка: " + ex.Message);
                //Console.WriteLine(ExceptionDispatchInfo.Capture(ex).SourceException);
                Console.WriteLine("Строка: " + LineNumber);
            }
            catch(OverflowException ex)
            {
                var LineNumber = new StackTrace(ex, true).GetFrame(0).GetFileLineNumber();
                Console.WriteLine("Ошибка: " + ex.Message);
                Console.WriteLine("Строка: " + LineNumber);
            }
            catch
            {
                Console.WriteLine("Найдена ошибка");
            }

            finally
            {
                Book b1 = new Book("АСТ", "Виновато море", 14.29, 2019, 3000, "Люси", "Кларк");
                Book b2 = new Book("АСТ", "Код да Винчи", 11.77, 2017, 5400, "Дэн", "Браун");
                Book b3 = new Book("Свет", "Веселье только начинается...", 12.68, 2013, 6785, "Лилиан", "Уайд");
                Book b4 = new Book("Барс", "Зимний ветер", 15.36, 2014, 8425, "Алиса", "Чудная");

                SchoolBook sb1 = new SchoolBook("Ветер", "Математика", 6.88, 2015, 250000, "Анастасия", "Гриненко", 5);
                SchoolBook sb2 = new SchoolBook("Белый ветер", "Геометрия", 5.98, 2013, 150000, "Анастасия", "Гриненко", 8);

                Magazine m1 = new Magazine("Альфа-книга", "Вокруг света", 2.57, 2019, 9585, 5);
                Magazine m2 = new Magazine("Дождь", "Один дома", 2.46, 2018, 9655, 12);
                Magazine m3 = new Magazine("Факел", "Банзай. Японский кроссворд", 1.99, 2010, 9655, 8);

                Library libra = new Library();

                libra.AddBook(b1);
                libra.AddSBook(sb2);
                libra.AddMag(m1);
                libra.AddBook(b2);
                libra.AddBook(b3);
                libra.AddMag(m2);
                libra.AddBook(b4);
                libra.AddMag(m3);
                libra.AddSBook(sb1);

                LibControl lc = new LibControl();
                lc.SeeSomeBooks(2014, libra);
                Console.WriteLine($"Количество учебников в библиотеке: {lc.CountSBooks(libra)}");
                Console.WriteLine($"Суммарная стоимость изданий в библиотеке: {lc.TotalSum(libra)}\n");

                libra.TakeBook(b3);
                libra.SeeAll();
            }


        }
    }
}
