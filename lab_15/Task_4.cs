using System;
using System.Threading;
using System.IO;

namespace lab_15
{
    class Task_4
    {
        private static SemaphoreSlim sema = new SemaphoreSlim(2);
        private static int saveUserNum;

        public static void DoTaskI()
        {
            lock ("null")
            {
                Console.WriteLine("Enter number: ");
                int n = Convert.ToInt32(Console.ReadLine());
                saveUserNum = n;
                Thread myThread1 = new Thread(new ParameterizedThreadStart(Func1));

                Thread myThread2 = new Thread(new ParameterizedThreadStart(Func2));
                myThread2.Start(n);
                //myThread2.Priority = ThreadPriority.BelowNormal;
                myThread2.Priority = ThreadPriority.Normal;
                myThread1.Start(n);
            }
        }

        public static void Func1(object num)
        {
            string path = @"task_4.txt";
            FileInfo LOG = new FileInfo(path);

            if (!LOG.Exists)
            {
                File.Create(path).Close();
            }
            
                lock ("null")
                {
                    using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                    {
                        for (int i = 1; i <= Convert.ToInt32(num); i++)
                        {
                            if (i % 2 != 0)
                            {
                                sw.WriteLine("First Thread: " + i);
                                Console.WriteLine("First Thread: " + i);
                                Thread.Sleep(100);

                            }
                        }
                    }
                }

                //for (int i = 1; i <= Convert.ToInt32(num); i++)
                //{
                //    lock ("null")
                //    {
                //        if (i % 2 != 0)
                //        {
                //            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                //            {
                //                sw.WriteLine("First Thread: " + i);
                //                Console.WriteLine("First Thread: " + i);
                //            }
                //            Thread.Sleep(100);
                            
                //        }
                //    }

                //}
            

        }

        public static void Func2(object num)
        {
            string path = @"task_4.txt";
            FileInfo LOG = new FileInfo(path);

            if (!LOG.Exists)
            {
                File.Create(path).Close();
            }

            
                lock ("null")
                {
                    using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                    {
                        for (int i = 1; i <= Convert.ToInt32(num); i++)
                        {
                            if (i % 2 == 0)
                            {
                                sw.WriteLine("Second Thread: " + i);
                                Console.WriteLine("Second Thread: " + i);
                                Thread.Sleep(100);
                            }
                        }
                    }
                }

                //for (int i = 1; i <= Convert.ToInt32(num); i++)
                //{

                //    lock ("null")
                //    {
                //        if (i % 2 == 0)
                //        {
                //            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
                //            {
                //                sw.WriteLine("Second Thread: " + i);
                //                Console.WriteLine("Second Thread: " + i);
                //            }
                //            Thread.Sleep(100);
                //        }
                //    }

                //}
            

        }

        //public static void DoTaskII()
        //{
        //    for (var i = 1; i <= saveUserNum; i++)
        //        new Thread(Enter).Start(i);
        //}

        //private static void Enter(object id)
        //{
        //    Thread myThread1 = new Thread(new ParameterizedThreadStart(Func1));
        //    Thread myThread2 = new Thread(new ParameterizedThreadStart(Func2));


        //    Console.WriteLine(id + " enter");
        //    sema.Wait();
        //    myThread2.Start(saveUserNum);
        //    Console.WriteLine(id + " is sweeming");
        //    Thread.Sleep(1000 * (int)id);
        //    myThread1.Start(saveUserNum);
        //    Console.WriteLine(id + " is leaving");
        //    sema.Release();
        //}
    }
}
