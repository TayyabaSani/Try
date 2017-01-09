using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread
{
    class Program
    {
        public static int CallToChildThread1(int N)
        {
            Console.WriteLine("Child thread starts");

            // the thread is paused for 5000 milliseconds
            int sleepfor = 5000;

            Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");
            for (int i = 0; i < N; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("ODD" + i);
                }

            }
            return 0;
        }
        public static void CallToChildThread2(int N)
        {
            Console.WriteLine("Child thread starts");

            // the thread is paused for 5000 milliseconds
            int sleepfor = 5000;

            Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("Child thread resumes");

            for(int i =0; i<N; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even"+i);
                }

            }

        }
        static void Main(string[] args)
        {
            int n = 9;
            ThreadStart childref1 = new ThreadStart(CallToChildThread1(n));
           // ThreadStart childref2 = new ThreadStart(CallToChildThread2);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread1 = new Thread(childref1);
            childThread1.Start();
          //  Thread childThread2 = new Thread(childref2);
           // childThread2.Start();
            Console.ReadKey();
        }
    }
}
