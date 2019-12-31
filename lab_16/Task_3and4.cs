using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace lab_16
{
    class Task_3and4
    {
        public static void DoTask()
        {
            Task<int> task1 = new Task<int>(() => f1(5));
            Task<int> task2 = task1.ContinueWith(res => f2(res.Result));
            Task<int> task3 = task2.ContinueWith(r => f3(r.Result, 10, 20));
            task1.Start();
            var my = task3.GetAwaiter();
            my.OnCompleted(() => {
                int resAw = my.GetResult();
                Console.WriteLine("Результат вычислений через getawaiter: " + resAw);
            });
            Console.Read();
        }

        static int f1(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static int f2(int n)
        {
            int result = 1;
            result = (n * n * 3) / (n + 10);
            return result;
        }

        static int f3(int n, int b, int c)
        {
            int result = 1;
            result = n * b * c;
            Console.WriteLine(result);
            return result;
        }

        static int f4(int n, int b, int c)
        {
            int result = 1;
            result = n * 3 + b * 3 + c * 3;
            return result;
        }
    }
}
