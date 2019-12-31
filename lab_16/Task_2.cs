using System;
using System.Threading;
using System.Threading.Tasks;

namespace lab_16
{
    class Task_2
    {
        public static void DoTask()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;

            Task task1 = new Task(() => SearchPrNum(token));
            task1.Start();

            Console.WriteLine("Введите C для отмены операции:");

            string s = Console.ReadLine();
            if (s == "C")
                cancelTokenSource.Cancel();
            Console.Read();
        }

        public static void SearchPrNum(CancellationToken token)
        {
            const int SIZE = 100;
            for (int i = 1; i <= SIZE; i++)
            {
                if (primeNum(i) == 2)
                {
                    Console.WriteLine("Простое число: " + i);
                }
                if (i == SIZE / 2)
                {
                    Console.WriteLine();
                }
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Операция прервана");
                    return;
                }
                Thread.Sleep(1000);
            }
            //Console.WriteLine("CurrentId: " + Task.CurrentId);
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
