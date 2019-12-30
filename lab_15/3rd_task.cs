using System;
using System.Threading;
using System.IO;

namespace lab_15
{
    class _3rd_task
    {
        public static void Action()
        {
            Thread myThread = new Thread(new ThreadStart(Counter));
            myThread.Start();       // запускаем поток
            Thread.Sleep(1000);     // приостанавливаем поток на 1 с (1000 мс)
            //myThread.Suspend();
            //myThread.Resume();
        }

        public static void Counter()
        {
            Console.WriteLine("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Thread t = Thread.CurrentThread;

            string path = @"task_3.txt";
            FileInfo LOG = new FileInfo(path);
            if (!LOG.Exists)
            {
                File.Create(path).Close();
            }

            Console.WriteLine("Name:" + t.Name);
            Console.WriteLine("Priority:" + t.Priority);
            Console.WriteLine("String:" + t.ToString());
            Console.WriteLine("ManagedThreadId:" + t.ManagedThreadId);
            Console.WriteLine("ThreadState:" + t.ThreadState);

            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                for (int i = 1; i < n; i++)
                {
                    if (primeNum(i) == 2)
                    {
                        sw.WriteLine(i);
                        Console.WriteLine(i);
                    }
                }                
            } 
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
