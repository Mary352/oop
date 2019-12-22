using System;
using System.Collections.Generic;
using System.Linq;

namespace lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------1--------------------------------------------------------------------------------------
            string[] months = { "July", "May", "March", "November", "January", "December", 
                "February", "", "August", "", "June", "April", "October", "September" };

            int n = 8;

            IEnumerable<string> mon1 = months.Where(m => m.Length == n);
            foreach (string mn in mon1)
            {
                Console.Write(mn + " ");
            }
            Console.WriteLine();

            IEnumerable<string> mon2 = months.Where(m => m.StartsWith("J"))
                                             .Concat(months.Where(n => n.StartsWith("Au")));            
            IEnumerable<string> mon3 = months.Where(m => m.StartsWith("D"));

            IEnumerable<string> mon4 = mon2.Union(mon3);
            foreach (string mn in mon4)
            {
                Console.Write(mn + " ");
            }

            IEnumerable<string> monAlph = months.OrderBy(s => s);
            foreach (string mn in monAlph)
            {
                Console.WriteLine(mn);
            }

            int monU = months.Where(s => s.Length > 4)
                             .Where(s => s.Contains("u"))
                             .Count();
            Console.WriteLine("\n" + monU);

            //---------------------------------2+3------------------------------------------------------------------------------------
            List<Airline> al = new List<Airline>();

            TimeSpan depTime1 = new TimeSpan(12, 38, 0);
            TimeSpan depTime2 = new TimeSpan(06, 47, 0);
            TimeSpan depTime3 = new TimeSpan(17, 53, 0);
            TimeSpan depTime4 = new TimeSpan(07, 20, 0);
            TimeSpan depTime5 = new TimeSpan(06, 44, 0);
            TimeSpan depTime6 = new TimeSpan(20, 56, 0);
            TimeSpan depTime7 = new TimeSpan(10, 25, 0);
            TimeSpan depTime8 = new TimeSpan(07, 55, 0);
            TimeSpan depTime9 = new TimeSpan(10, 50, 0);

            al.Add(new Airline("Осло", "AY740", depTime2, "ср"));
            al.Add(new Airline("Хельсинки", "HS457", depTime1, "пн"));
            al.Add(new Airline());
            al.Add(new Airline("Стокгольм", depTime3));
            al.Add(new Airline("Стокгольм", "SC12", depTime4, "ср"));
            al.Add(new Airline("Лондон", "LN15", depTime5, "пн"));
            al.Add(new Airline("Стокгольм", "SC12", depTime7, "пн"));
            al.Add(new Airline("Барселона", "BS412", depTime6, "пт"));
            al.Add(new Airline("Мюнхен", "GM44", depTime8, "пт"));
            al.Add(new Airline("Вена", "VE749", depTime9, "ср"));

            IEnumerable<Airline> a1 = al.Where(s => s.Destination == "Стокгольм");
            Console.WriteLine("\nПункт назначения: Стокгольм");
            Console.WriteLine("Номер рейса\tВремя вылета\tДень недели");
            foreach (var i1 in a1)
            {
                Console.WriteLine(i1.FlightNum + "\t\t" + i1.DepartTime + "\t" + i1.WeekDay);
            }

            int a2 = al.Where(s => s.WeekDay == "пн")
                       .Count();
            Console.WriteLine("\nКоличество рейсов в пн: " + a2);


            TimeSpan earlierMon = al.Where(s => s.WeekDay == "пн")
                                    .Min(s => s.DepartTime);
            Airline a3 = al.Where(s => s.DepartTime == earlierMon).Single();
            Console.WriteLine("Самый ранний рейс в пн: " + a3.Destination + " " + a3.FlightNum + " " 
                                                           + a3.DepartTime);

            TimeSpan laterWedFri = al.Where(s => s.WeekDay == "ср" || s.WeekDay == "пт")
                                    .Max(s => s.DepartTime);
            Airline a4 = al.Where(s => s.DepartTime == laterWedFri).Single();
            Console.WriteLine("Самый поздний рейс в ср или пт: " + a4.Destination + " " + a4.FlightNum 
                                                             + " " + a4.DepartTime + " " + a4.WeekDay);

            IEnumerable<Airline> a5 = al.OrderBy(s => s.DepartTime);
            Console.WriteLine("\nПункт назначения\tНомер рейса\tВремя вылета\t   День недели");
            foreach (var i1 in a5)
            {
                Console.WriteLine(i1.Destination + "\t\t\t" + i1.FlightNum + "\t\t" + i1.DepartTime 
                                  + "\t   " + i1.WeekDay);
            }

            //---------------------------------4--------------------------------------------------------------------------------------
            TimeSpan a10 = al.Skip(1)
                       .Where(s => s.WeekDay == "пн" || s.WeekDay == "пт")
                       .OrderBy(s => s.Destination)
                       .Select(s => s.DepartTime)
                       .Min();
           

            Console.WriteLine("\nСамое раннее время, когда улетает рейс в пн или пт: " + a10);

            //---------------------------------5--------------------------------------------------------------------------------------
            int[] key = { 3, 4, 8 };

            var mon = months.Join(key,
                                  s => s.Length,
                                  p => p,
                                  (s, p) => new { id = p, month = s });
            Console.WriteLine();
            foreach (var item in mon)
            {
                Console.WriteLine(item);
            }
        }
    }
}
