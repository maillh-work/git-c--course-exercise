using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        /*
         * define a var to hold name
         * define a var to hold phone number
         * define a var to hold age
         * print vars line by line
         * extra: define vars using the var keyword
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Storing user data exercise:\n");
            //string name = "llhm";
            var name = "llhm";
            //string phone = "0123456789";
            var phone = "0123456789";
            //int age = 26;
            var age = 26;
            Console.WriteLine("Your name: " + name);
            Console.WriteLine("Your phone number: " + phone);
            Console.WriteLine("Your age: " + age);
            Console.WriteLine();

            /*
            * create and initialize 2 ints
            * make a variable to worlk out the remainder
            * out put remainder to the screen
            * change the 1st int to another number
            *  recalculate remainder
            *  output new remainder to the screen
            */

            Console.WriteLine("Check odd/even exercise:\n");
            int firstnumb = 22;
            int secondnumb = 09;

            var remainder = (firstnumb % secondnumb);
            Console.WriteLine("Remainder: " + remainder);

            firstnumb = 1;
            remainder = (firstnumb % secondnumb);
            Console.WriteLine("Remainder: " + remainder);

            Console.ReadLine();
        }
    }
}
