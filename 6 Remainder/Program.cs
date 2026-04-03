using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumb = 14;
            int secondNumb = 3;

            //mondulus operator -> return the remainder of a divide operation
            Console.WriteLine(firstNumb % secondNumb); //2
            Console.WriteLine(firstNumb % 2); //0
            Console.WriteLine(secondNumb % 2); //1
            Console.WriteLine(1000 % 90); //10

            Console.ReadLine();
        }

    }
}
