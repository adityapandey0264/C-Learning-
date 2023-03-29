using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace OopsConcepts
{
    class ThreadPriorities
    {
        ///Why?THREAD PRIORITY==When First Thread has more important work to do as compared to the second Thread then we use the Thread Priority.
        static long count1, count2;
        public static void IncrementCount1()
        {
            while(true)
            {
                count1 += 1;
            }
        }
        public static void IncrementCount2()
        {
            while(true)
            {
                count2 += 1;
            }
        }

         static void Main()
        {
            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);
            t1.Start();
            t2.Start();

            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;
            
            Console.WriteLine("Main Thread going to Sleep");
            Thread.Sleep(10000);
            Console.WriteLine("Main Thread Woke Up");


            t1.Abort();
            t2.Abort();

            t1.Join();
            t2.Join();

            Console.WriteLine("Count 1=" + count1);
            Console.WriteLine("Count 2=" + count2);
            Console.ReadKey();
        }
    }
}
