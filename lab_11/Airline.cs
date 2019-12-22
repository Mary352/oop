using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3
{
    public partial class Airline    //объявление
    {
        private static int count;

        private readonly string destination;
        private string flightNum;
        private const string apType = "Airbus A321";
        private TimeSpan departTime;
        private string weekDay;

        //private int g;

    }

    public partial class Airline    //конструкторы
    {
        static Airline()
        {
            //Airline Zero = new Airline(0, 1);
            //Airline One = new Airline(1, 1);

            count = 0;
            Console.WriteLine("Static constructor first");

            //Console.WriteLine(Zero.g);
            //Console.WriteLine(One.g);
        }

        public Airline()
        {
            count++;
            destination = "Лондон";
            flightNum = "AY1332";
            departTime = new TimeSpan(15, 30, 0);
            weekDay = "пн";
        }

        public Airline(string dest, string Fnum, TimeSpan depTime, string wDay)
        {
            count++;
            destination = dest;
            flightNum = Fnum;
            departTime = depTime;
            weekDay = wDay;
        }

        public Airline(string dest, TimeSpan depTime, string Fnum = "AY660", string wDay = "пн")
        {
            count++;
            destination = dest;
            flightNum = Fnum;
            departTime = depTime;
            weekDay = wDay;
        }

        //private Airline(int n, int c)   //закрытый конструктор
        //{
        //    g = n + c;
        //}
    }

    public partial class Airline    //свойства
    {
        public string Destination
        {
            get => destination;
        }

        public string FlightNum
        {
            get => flightNum;
            set => flightNum = value;
        }

        public string APType
        {
            get => apType;
        }
        public TimeSpan DepartTime
        {
            get
            {
                return departTime;
            }
            set
            {
                departTime = value;
            }
        }

        public string WeekDay
        {
            get => weekDay;
            set => weekDay = value;
        }
    }

    public partial class Airline    //методы
    {
        public static void NumberOfFlights()
        {
            if (count % 10 == 1 || count == 1)
            {
                Console.WriteLine($"Был создан {0} рейс", count);
            }
            else if ((count % 10 > 4 || count % 10 == 0 || (count > 4 && count < 10)) && count != 0)
            {
                Console.WriteLine($"Было создано {0} рейсов", count);
            }
            else if ((count % 10 > 1 && count % 10 < 5) || (count > 1 && count < 5))
            {
                Console.WriteLine("$Было создано {0} рейса", count);
            }
            else if (count == 0)
            {
                Console.WriteLine("Ни одного рейса не было создано");
            }
            else
            {
                Console.WriteLine("Произошла ошибка. Проверьте значение count или условия проверки");
            }
        }

        public void ChangeFlNum(ref string flNum, out string destin)
        {
            flNum = flNum + "7";

            destin = destination;
            destin = destin + " (OSL)";
        }  
        
        public void FullInfo()
        {
            string depurTime = departTime.ToString();
            Console.WriteLine($"Рейс {flightNum} до {destination} вылетает в {weekDay} в {depurTime}. Тип самолёта: {apType}");
        }
    }

    public partial class Airline    //переопределение
    {
        public override string ToString()
        {
            return "For flights: " + base.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            //if (obj.GetType() != this.GetType()) return false;
            Airline fl = (Airline)obj;

            return (this.destination == fl.destination && this.flightNum == fl.flightNum && this.departTime == fl.departTime && this.weekDay == fl.weekDay);
        }

        public override int GetHashCode()
        {
            int hash = 211;

            hash = string.IsNullOrEmpty(destination) ? 0 : destination.GetHashCode();
            int test = string.IsNullOrEmpty(flightNum) ? 0 : flightNum.GetHashCode();
            hash = (hash * 47) + flightNum.GetHashCode();
            return hash;
        }
    }
}
