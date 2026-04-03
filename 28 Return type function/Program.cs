using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _28_Return_type_function
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Console.Title = $"{returnName()} - {returnAge()}";
            PrintIntroduction();

            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = readNumberFromConsole();
            }

            Console.WriteLine();

            int[] newNumbers = createRandomArray();

            foreach (var item in createRandomArray())
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            Console.WriteLine(Add());

            Console.ReadLine();
        }


        //all functions 
        static void PrintIntroduction()
        {
            Console.WriteLine($"Hello my name is {returnName()} and my age is {returnAge()}.");
        }

        static string returnName()
        {
            return "mllh";
        }

        static int returnAge()
        {
            return 26;
        }

        static int readNumberFromConsole()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int[] createRandomArray()
        {
            return new int[3] {0, 1, 2};
        }

        static int Add()
        {
            return 5 + 5; 
        }
    }
}
