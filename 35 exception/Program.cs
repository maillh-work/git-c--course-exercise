using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //format exception
            //overflow exception

            /*
            bool looping = true;

            while (looping)
            {
                try
                {
                    Console.WriteLine("enter number: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(num);
                    looping = false;
                }

                catch (FormatException)
                {
                    Console.WriteLine("pls enter number only");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("pls enter number < 2 bil>");
                }

                catch (Exception) //cannot out put very specific message
                {
                    Console.WriteLine("sth has went wrong");
                }
            }

            Console.WriteLine("goodbye");
            */

            //printing error message

            try
            {
                Console.Write("enter number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num);
            }

            catch (FormatException)
            {
                Console.WriteLine("Please only enter number");
            }

            catch (OverflowException)
            {
                Console.WriteLine("pls enter num < 2 bil");
            }
            catch (Exception e)
            {
                Console.WriteLine($"error: {e.Message}");
            }

            Console.WriteLine("goodbye");
            Console.ReadLine();
        }
    }
}
