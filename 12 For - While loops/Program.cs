using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_For___While_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("How many times do you want to say hi?: ");
            int sayHiTimes = Convert.ToInt32(Console.ReadLine());
            Console.Write("What do you want to repeat?: ");
            string message = Console.ReadLine();
            Console.WriteLine();

            
            Console.WriteLine("For loop:");
            if(sayHiTimes <= 0)
            {
                Console.WriteLine("Invalid.");
            }
            else
            {
                for (int i = 0; i < sayHiTimes; i += 1)
                {
                    Console.WriteLine(message);
                }
            }
            
            for(int i = 0; i < 10; i += 2)
            {
                Console.WriteLine();
            }

            int i = 0;
            while(i < 10)
            {
                Console.WriteLine(i);
                i++;
            
            */

            //while loop will check the condition before perform the action
            Console.WriteLine("While loop:");
            Console.Write("Enter the first number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());
            

            int answer = numberA * numberB;
            int inputAnswer = 0;

            Console.Write("Value of " + numberA + " x " + numberB + ": ");

            while (answer != inputAnswer)
            {
                Console.Write("Enter your answer: ");
                inputAnswer = Convert.ToInt32(Console.ReadLine());
                if (answer != inputAnswer)
                {
                    Console.WriteLine("Incorrect.");
                }
            }
            Console.WriteLine("Correct.");
            
            /*
            //Do- while loop will always execute action before checking the condition
            Console.WriteLine("Do-While loop: ");

            Console.Write("Enter the first number: ");
            int numberA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int answer = numberA * numberB;
            int inputAnswer = 0;

            do
            {
                Console.Write("Enter your answer: ");
                inputAnswer = Convert.ToInt32(Console.ReadLine());

                if (answer != inputAnswer)
                {
                    Console.WriteLine("Incorrect.");
                }
            } while (answer != inputAnswer);
            Console.WriteLine("Correct.");

            Console.ReadLine();
            */


            //summarize:
            //for loop: su dung khi biet truoc so vong lap
            //while loop: du dung khi khong biet truoc so lan lap, chi can lap lai khi dieu kien con dung
        }
    }
}
