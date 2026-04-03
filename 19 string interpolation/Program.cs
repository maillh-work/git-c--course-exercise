using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_string_interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "llhm";
            int age = 26;

            Console.WriteLine($"Your name is {name} your age is {age}.");

            string test = string.Concat("Your name is ", name, " and your age is ", age);
            Console.WriteLine(string.Concat("Your name is ", name, " and your age is ", age));

            string[] names = new string[] { "Aba ", "Test ", "Test " };

            Console.WriteLine(string.Concat(names));


            Console.ReadLine();
        }
    }
}
