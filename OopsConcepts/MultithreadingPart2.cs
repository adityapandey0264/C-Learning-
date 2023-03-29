using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OopsConcepts
{
    class MultithreadingPart2
    {
        static void Test1()
        {
            for(int i=0;i<50;i++)
            {
                Console.WriteLine("Test 1=" + i);
            }
            Console.WriteLine("Test 1 is exiting\n");
        }
        static void Test2()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Test 2=" + i);
                if(i==25)
                {
                    Console.WriteLine("Thread going to sleep for 5 Sec\n");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread woke up");
                }
            }
            Console.WriteLine("Test 2 is exiting\n");
        }
        static void Test3()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Test 3=" + i);
            }
            Console.WriteLine("Test 3 is exiting\n");
        }

        static void Main()
        {
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start(); t2.Start(); t3.Start();
            Console.WriteLine("Main Thread is Exiting\n");
            Console.ReadKey();
        }
    }
}
