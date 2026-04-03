using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string speech = "He said \"something\"";

            Console.WriteLine(speech);

            //@ $ + 

            string path = @"C:\Users\CoffeNode" + "\nNew line test";
            Console.WriteLine(path);

            string name = "Hello \"some one\"";
            Console.WriteLine(name);

            name = "Hello 'someone'";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
