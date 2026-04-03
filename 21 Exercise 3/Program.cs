using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Exercise_3
{
    internal class Program
    {
        /*
         * ask user to input msg
         * print in order
         * print in reverse
         */
        static void Main(string[] args)
        {
            /*
            Console.Write("Input message: ");
            string message = Console.ReadLine();

            Console.WriteLine(message);

            for (int i = message.Length - 1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }
            */

            //Password checker
            /*
             *ask user to enter a password, store it
             *ask user to enter pwd again, and store
             *check if they both contain sth
                *if so check if they are the same
                    *if same, print "PWD match"
                    *else print 'PWD does not match"
                *if empty, print "Please enter a PWD"
            */

            Console.Write("Enter PWD: ");
            string inputPWD = Console.ReadLine();

            Console.Write("Confirm PWD: ");
            string confirmPWD = Console.ReadLine();
            if (confirmPWD != inputPWD)
            {

            }        
            
            Console.ReadLine();
        }
    }
}
