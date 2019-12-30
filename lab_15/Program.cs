using System;
using System.Diagnostics;
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
            Console.WriteLine("UserProcessorTime: " + currentProcess.UserProcessorTime);

            //========================================2========================================
        }
    }
}
