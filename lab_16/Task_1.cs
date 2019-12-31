using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace lab_16
{
    class Task_1
    {
        public static void DoTask()
        {
            Task task = new Task(SearchPrNum);
            Stopwatch stopWatch = new Stopwatch();
            task.Start();
            stopWatch.Start();
            Thread.Sleep(1);
            
            Thread.Sleep(1000);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("Общее затраченное время: " + ts);
            Console.WriteLine("Status: " + task.Status);

            Console.WriteLine("IsCompleted: " + task.IsCompleted);
            Console.ReadLine();
        }

        public static void SearchPrNum()
        {
            const int SIZE = 1000;
            for (int i = 1; i <= SIZE; i++)
            {
                if (primeNum(i) == 2)
                {
                    Console.WriteLine("Простое число: " + i);
                }
                if (i == SIZE / 2)
                {
                    Console.WriteLine();
                    Thread.Sleep(2000);

                }
            }
            Console.WriteLine("CurrentId: " + Task.CurrentId);
        }

        public static int primeNum(int num)
        {
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
