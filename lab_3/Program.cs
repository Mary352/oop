using System;

namespace lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Airline fl1 = new Airline();
            
            TimeSpan depTime2 = new TimeSpan(12, 45, 0);
            Airline fl2 = new Airline("Осло", "AY740", depTime2, "ср");

            TimeSpan depTime3 = new TimeSpan(17, 50, 0);
            Airline fl3 = new Airline("Стокгольм", depTime3);

            Airline fl4 = new Airline();
            fl4.FlightNum = "SC12";
            TimeSpan depTime4 = new TimeSpan(07, 20, 0);
            fl4.DepartTime = depTime4;

            string flNum = fl2.FlightNum;
            string destin;
            fl2.ChangeFlNum(ref flNum, out destin);
            //Console.WriteLine(flNum + " " + destin);

            Console.WriteLine(fl4.GetType());

            if(fl3.Equals(fl1))
            {
                Console.WriteLine("fl3 = fl1");
            }
            else
            {
                Console.WriteLine("fl3 != fl1");
            }

            if (fl2.Equals(fl2))
            {
                Console.WriteLine("fl2 = fl2");
            }
            else
            {
                Console.WriteLine("fl2 != fl2");
            }

            Airline[] arrFl = new Airline[] { fl1, fl2, fl3, fl4 };
            
            for(int i = 0; i < 4; i++)
            {
                if(arrFl[i].Destination == "Лондон")
                {
                    arrFl[i].FullInfo();
                }

                if(arrFl[i].WeekDay == "ср")
                {
                    arrFl[i].FullInfo();
                }
            }

            var AnonType = new
            {
                Destination = "Хельсинки",
                FlightNum = "AY660",
                APType = "Airbus 319",
                DepartTime = new TimeSpan(18, 35, 0),
                WeekDay = "пт"
            };
        }
    }
}
