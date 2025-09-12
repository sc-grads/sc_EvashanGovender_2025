using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadJoiningE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread started");
            Thread thread1 = new Thread(Thread1Function);
            Thread thread2 = new Thread(Thread2Function);
            thread1.Start();
            thread2.Start();
            thread1.Join();
            Console.WriteLine("Thread 1 has completed");
            thread2.Join();
            Console.WriteLine("Thread 2 has completed");
            Console.WriteLine("Main Thread ended");

            Console.ReadKey();
        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread 1: Starting");
            Thread.Sleep(2000);
        }

        public static void Thread2Function()
        {
            Console.WriteLine("Thread 2: Starting");
        }
    }
}
