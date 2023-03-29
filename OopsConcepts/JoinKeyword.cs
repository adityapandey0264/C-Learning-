using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OopsConcepts
{
    class JoinKeyword
    {
        //Using Join Keyword -Until all other threads are exited then only main method is allowed to exit.
        //Join is an Overload method


        static void Test1()
        {
            for(int i=0;i<=50;i++)
            {
                Console.WriteLine("Thread 1=" + i);
            }
            Console.WriteLine("Thread 1 Exiting");
        }
        static void Test2()
        {
            for (int i = 0; i <= 60; i++)
            {
                Console.WriteLine("Thread 2=" + i);
            }
            Console.WriteLine("Thread 2 Exiting");
        }
        static void Test3()
        {
            for (int i = 0; i <= 70; i++)
            {
                Console.WriteLine("Thread 3=" + i);
            }
            Console.WriteLine("Thread 3 Exiting");
        }

        static void Main()
        {
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);

            t1.Start();
            t2.Start();
            t3.Start();
            //Using Join
            t1.Join(); //We can also pass a timeout here as it is Overload Method.
            t2.Join(5000);
            t3.Join();

            Console.WriteLine("Main Thread Exiting");
            Console.ReadKey();
        }
    }
}
