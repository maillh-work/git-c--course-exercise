using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _10_conditional_statement___if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter yout age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Your name is " + name + " and your age is " + age + ".");

            //== > < >= <= || or && and


            if(age < 0 || age > 150)
            {
                Console.WriteLine("Invalide age!");
            }
            else if (0 <= age && age <= 18) //return true or false
            //if true:
            {
                Console.WriteLine(" You are in your teenage period.");
            }
            //if false, will move to the next conditional statement
            else if (age <= 35)
            {
                Console.WriteLine(" You are in the work slave period.");
            }
            else if (age <= 150)
            {
                Console.WriteLine(" You should want to be retired by now.");
            }
            */

            Console.Write("Enter the first number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int answer = numberA * numberB;

            Console.Write("Value of " + numberA + " x " + numberB + ": ");
            int inputAnswer = Convert.ToInt32(Console.ReadLine());
            
            if(answer == inputAnswer)
            {
                Console.WriteLine("Correct.");
            }
            else
            {
                Console.WriteLine("Incorrect.");
            }

            Console.ReadLine();
        }
    }
}
