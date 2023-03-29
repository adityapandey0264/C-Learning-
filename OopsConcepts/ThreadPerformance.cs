using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace OopsConcepts
{
    class ThreadPerformance
    {
        static void IncrementCounter1()
        {
            long count = 0;
            for(long i=0;i<=1000000000;i++)
            {
                count++;
               
            }
            Console.WriteLine("Count1=" + count);
        }
        static void IncrementCounter2()
        {
            long count2 = 0;
            for(long i = 0; i <= 1000000000; i++)
            {
                count2++;
                
            }
            Console.WriteLine("Count2=" + count2);
        }

        static void Main()
        {
            Thread t1 = new Thread(IncrementCounter1);
            Thread t2 = new Thread(IncrementCounter2);
            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();
            s1.Start();
            IncrementCounter1();
            IncrementCounter2();
            s1.Stop();
            s2.Start();
            t1.Start();
            t2.Start();
            s2.Stop();
            t1.Join();
            t2.Join();
            Console.WriteLine("Time taken to complete the work in Single Threaded Model="+ s1.ElapsedMilliseconds);
            Console.WriteLine("Time taken to complete work in MultiThreaded Model="+ s2.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
