using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _36_exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            bool success = false;

            try
            {
                Console.Write("enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                success = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(success ? "correct" : "incorrect");
            */

            Console.Write("enter number: ");
            if (TryParse(Console.ReadLine(), out int result))
            {
                Console.Write("correct" + result);
            }
            else
            {
                Console.Write("incorrect");
            }

            Console.ReadLine();
        }

        static bool TryParse(string input, out int result) //TryParse return whether sth has been successfully converted (true) or not (false)
        {
            result = -1;

            try
            {
                result = Convert.ToInt32(input);
                return true; //if convert fail, skip this line and jump straight to exception
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
