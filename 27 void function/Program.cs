using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_void_function
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static void CreateAndPrintArray()
        {
            int[] numbers = new int[3] { 1, 2, 3 };

            foreach (var item in numbers)
            {
                Console.WriteLine($"{item} ");
            }
        }

        static void WelcomeMessage()
        {

        }
    }
}
