using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    class Dictionaries
    {
        public static void Main()
        {
            Dictionary<string, int> EmployeeList = new Dictionary<string, int>();
            //Adding Elements
            EmployeeList.Add("aditya", 25);
            EmployeeList.Add("Vikas", 24);
            EmployeeList.Add("Rajat", 23);
            EmployeeList.Add("Tolu", 20);


            //Retrieving Elements
            foreach(KeyValuePair<string,int>lists in EmployeeList)
            {
                Console.WriteLine("Key{0},Value={1}", lists.Key, lists.Value);
            }

            //Counting Elements
            Console.WriteLine("Total Elements in EmployeeList are={0}", EmployeeList.Count);

            //Set and Get a Dictionary Item
            EmployeeList["Vikas"] = 20;
            int age = Convert.ToInt32(EmployeeList["Vikas"]);

            //Gets a Collection of Keys
            Dictionary<string, int>.KeyCollection keys = EmployeeList.Keys;
            foreach(string key in keys)
            {
                Console.WriteLine("Key={0}", key);
            }

            //Gets a Collection of values
            Dictionary<string, int>.ValueCollection values = EmployeeList.Values;
            foreach(int value in values)
            {
                Console.WriteLine("Value={0}", value);
            }

            //Remove an Item
            EmployeeList.Remove("Vikas");

            //Find a Key
            if(!EmployeeList.ContainsKey("pandey"))
            {
                EmployeeList.Add("pandey", 30);
            }
           

            Console.WriteLine("New Dictionary=");
            foreach(KeyValuePair<string,int>lists in EmployeeList)
            {
                Console.WriteLine("Keys={0},Values={1}", lists.Key, lists.Value);
            }
            Console.ReadKey();
        }
    }
}
