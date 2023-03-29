using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OopsConcepts
{
    class ThreadSample3
    {
        
        static void Test()
        {
            for(int i=0;i<20;i++)
            {
                Console.WriteLine("Value of I=" + i);
            }
        }
        

        static void Test2(object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("Value of I=" + i);
            }
        }
        static void Main()
        {
            //Using Thread Start Delegate

            /*
            ThreadStart threadStart = new ThreadStart(Test); 
            Thread t = new Thread(threadStart);
            t.Start();
            Console.ReadKey();
            */
            Test();

            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test2);
            Thread t = new Thread(obj);
            t.Start(50);//Start is an Overload Method
            Console.ReadKey();
            

            //Using Anonymous Methods =>Lambda Operator

            /*
            ThreadStart obj = () => Test();
            Thread t = new Thread(obj);
            t.Start();
            */
            

            //Using Instantiation


        }
    }
}
