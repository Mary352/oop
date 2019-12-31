using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace lab_16
{
    class Task_7
    {
        public static void DoTask()
        {
            Task Prod1 = new Task(Prod);
            Task Prod2 = new Task(Prod);
            Task Prod3 = new Task(Prod);
            Task Prod4 = new Task(Prod);
            Task Prod5 = new Task(Prod);
            Task cust = new Task(Cust);
            Task cust1 = new Task(Cust);
            Task cust2 = new Task(Cust);
            Task cust3 = new Task(Cust);
            Task cust5 = new Task(Cust);
            Task cust6 = new Task(Cust);
            Task cust7 = new Task(Cust);
            Task cust8 = new Task(Cust);
            Task cust9 = new Task(Cust);

            Prod1.Start();
            Prod2.Start();
            Prod3.Start();
            Prod4.Start();
            Prod5.Start();
            cust.Start();
            cust1.Start();
            cust2.Start();
            cust3.Start();
            cust5.Start();
            cust6.Start();
            cust7.Start();
            cust8.Start();
            cust9.Start();
        }
        static BlockingCollection<int> bc = new BlockingCollection<int>(5);
        static int mod = 1;
        static void Prod()
        {
            mod++;
            for (int i = (mod - 1); i < mod; i++)
            {
                bc.Add(i);
                Thread.Sleep(500);
                Console.WriteLine("Добавлено: " + i);
                foreach (var j in bc)
                {
                    Console.WriteLine("Количество продуктов: " + j);
                    Thread.Sleep(500);
                }
                Thread.Sleep(500);
            }
        }

        static void Cust()
        {
            mod++;
            int i;
            while (!bc.IsCompleted)
            {
                Thread.Sleep(500);
                if (bc.TryTake(out i))
                {
                    Console.WriteLine("Продано: " + i);
                    Thread.Sleep(500);
                }
                else
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Склад пуст");
                    }
                }
                Thread.Sleep(500);
            }
        }
    }
}
