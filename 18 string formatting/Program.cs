using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_string_formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "llhm";
            int age = 26;

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            
            Console.WriteLine();

            Console.WriteLine("Name" + name + "\nAge: " + age);

            //composite format
            Console.WriteLine("Your name is {0}, and your age is {1}.\n", name, age);
            Console.WriteLine("Name: {0} \nAge: {1}", name, age);

            Console.ReadLine(); 
        }
    }
}
