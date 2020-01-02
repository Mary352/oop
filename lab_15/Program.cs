using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.IO;

namespace lab_15
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //========================================1========================================

            Process currentProcess = Process.GetCurrentProcess();
            Console.WriteLine("ProcessName: " + currentProcess.ProcessName);
            Console.WriteLine("Id: " + currentProcess.Id);
            Console.WriteLine("BasePriority: " + currentProcess.BasePriority);
            Console.WriteLine("StartTime: " + currentProcess.StartTime);
            Console.WriteLine("SessionId: " + currentProcess.SessionId);
            Console.WriteLine("TotalProcessorTime: " + currentProcess.TotalProcessorTime);
            Console.WriteLine();

            //========================================2 - домен=================================

            AppDomain domain = AppDomain.CurrentDomain;
            Console.WriteLine($"Name: {domain.FriendlyName}");
            Console.WriteLine($"Base Directory: {domain.BaseDirectory}");
            Console.WriteLine();

            //Assembly[] assemblies = domain.GetAssemblies();
            //foreach (Assembly asm in assemblies)
            //    Console.WriteLine(asm.GetName().Name);

            //AppDomain newD = AppDomain.CreateDomain("New");
            //newD.Load(assemblies[0].ToString());
            //AppDomain.Unload(newD);

            //=============================3 - вывод простых чисел===============================
            //_3rd_task.DoTask();

            //=============================4 - два потока========================================
             Task_4.DoTaskI();

            //=============================5 - Timer=============================================            
            
            //Timer timer = new Timer(Count, null, 0, 1000);
            //Console.Read();
        }

        public static void Count(object obj)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
