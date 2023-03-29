using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OopsConcepts
{
    class ThreadLocking
    {
        //Why LOCKING- To Overcome the problem of Multiple Threads accessing the same Resource and not getting any Unexpected Results.
        public void Display()
        {
            lock(this)   //Since the code is now locked only one Thread is allowed to enter the code at once.
            {
                Console.Write("[C # is an ");
                Thread.Sleep(5000);
                Console.WriteLine("Object Oriented Language]");
            }
            
        }
        //RULE--Members of NON STATIC function can never be accessed by a static block ie MAIN.
        static void Main()
        {
            ThreadLocking obj = new ThreadLocking();
            Thread T1 = new Thread(obj.Display);
            T1.Start();
            Thread T2 = new Thread(obj.Display);
            T2.Start();
            Thread T3 = new Thread(obj.Display);
            T3.Start();
            Console.ReadKey();
        }
    }
}
