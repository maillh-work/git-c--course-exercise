using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Exercise_2__Times_table_and_Fizz_buzz_game_
{
    internal class Program
    {
        /* Times table
         * ask user for a number for the table
         * write a for loop to print X times table
         * 
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, number,i * number);
            }
            Console.WriteLine();



            /*Fizz buzz game
             * create a for loop from 1 to X (15)
             * 3 and 5 = Fizz Buzz
             * 3 = Fizz
             * 5 = Buzz
             * else = number
            */

            bool threeDiv = false;
            bool fiveDiv = false;
            
            
            for(int i = 1; i <= 15; i++)
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;

                if(threeDiv && fiveDiv)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if(threeDiv)
                {
                    Console.WriteLine("Fizz");
                }
                else if(fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
