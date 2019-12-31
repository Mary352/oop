using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace lab_16
{
    class Task_5and6
    {
        public static void DoTask()
        {
            Parallel.For(1, 4, FuncFor);
            Console.WriteLine("---------");
            ParallelLoopResult result = Parallel.ForEach<int>(new List<int>() { 1, 3, 5, 8 },
               FuncFor);

            Parallel.Invoke(Display,
       () => {
           Console.WriteLine();
           Console.WriteLine($"Выполняется {Task.CurrentId}");
           Thread.Sleep(3000);
       },
       () => Factorial(5));

            Console.ReadLine();
        }

        public static void FuncFor(int x)
        {
            for (int j = 0; j < x; j++)
            {
                int[] arr = new int[10000];
                Random rand = new Random();
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(1, 100);
                }
                Console.WriteLine($"Выполняется задача {Task.CurrentId}");
                Thread.Sleep(100);
            }
        }
        static void Display()
        {
            Console.WriteLine($"Выполняется задача {Task.CurrentId}");
            Thread.Sleep(3000);
        }

        static void Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine($"Выполняется задача {Task.CurrentId}");
            Thread.Sleep(3000);
            Console.WriteLine($"Результат {result}");
        }
    }
}
