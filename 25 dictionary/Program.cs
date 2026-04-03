using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _25_dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Dictionary<int, string> names = new Dictionary<int, string>()
            //names.Add(1, "AA");
            //names.Add(2, "BB");
            //names.Add(3, "CC");

            {
                //Key value pair
                { 100, "AA"},
                { 4, "AA"},
                { 2, "BB"},
                { 3, "CC"},
            };

            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value} ");
            }
            Console.WriteLine();

            foreach (KeyValuePair<int, string> item in names)
            {
                Console.WriteLine($"{item.Key} - {item.Value} ");
            }
            */

            Dictionary<string, string> teachers = new Dictionary<string, string>()
            {
                {"Math", "AA"},
                {"Science", "BB" }
            };
            
            //the [] in dictionary is refer to a key, rather than a position
            //Console.WriteLine(teachers["math"]);// int.tryParse convert

            if (teachers.TryGetValue("Math", out string teacher))
            {
                Console.WriteLine(teacher);
                teachers["Math"] = "Joe";
            }
            else
            {
                Console.WriteLine("Math teacher not found");
            }

            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine("Math teacher not found");
            }
            
            

            foreach (KeyValuePair<string, string> item in teachers)
            {
                Console.WriteLine($"{item.Key} - {item.Value} ");
            }

            Console.ReadLine();

            //diff: list can only  store 1 data type while dictionary can store a key value pair
        }
    }
}
