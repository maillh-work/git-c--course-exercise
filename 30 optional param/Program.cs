using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _30_optional_param
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(5,5);
            Console.WriteLine(result);

            PrintName("llhm");

            Console.ReadLine();
        }

        static void PrintName(string name = "Aba")
        {
            Console.WriteLine($"My name is {name}.");
        }

        static int Add(int a, [Optional] int b)
        //static int Add(int a, int b = default)
        {
            return a + b;
        }
    }
}
