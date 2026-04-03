using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37_debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "llhm";
            int age = 35;
            age = 23;

                PrintDetails(name, age);

            string message = ReadFromConsole("Enter anything: ");
            Console.WriteLine(message);

            Console.ReadLine();
        }

        static void PrintDetails(string name, int age)
        {
            Console.WriteLine($"{name} - {age}");
        }

        static string ReadFromConsole(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }



    }
}
