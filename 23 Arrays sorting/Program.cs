using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Arrays_sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                1,2,3,0,6,8,7,4,9,5
            };

            string test = " ";
            test = test.Replace(" ", "");

            Array.Sort(numbers); //return a void, sort function will affect the array directly
            
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            //array reversal
            int[] numbers1 = new int[]
            {
                0,1,2,3,4,5
            };


            int[] sortedNumbers = new int[numbers1.Length];
            int x = 0;
            
            for (int i = numbers1.Length - 1; i >= 0; i--)
            {
                sortedNumbers[x] = numbers1[i];
                x++;
            }
            foreach (var num in sortedNumbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();


            Array.Reverse(numbers1);

            foreach (int num1 in numbers1)
            {
                Console.Write($"{num1} ");
            }
            Console.WriteLine();

            //Array clearing 

            int[] numbers2 = new int[]
            {
                1,2,3,0,6,8,7,4,9,5
            };
            //Array.Clear(numbers2, 5, 5); //clearing = assign all positions of the array the value 0
            
            for (int i = 5; i < 10; i++)
            {
                numbers2[i] = default;
            }
            

            foreach (var item in numbers2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            //Arrays index of
            int[] numbersIndexOf = new int[]
            {
                90, 199, 22, 50, 30
            };

            Console.Write("Enter number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            
            int position = Array.IndexOf(numbersIndexOf, search);
            //int position = Array.IndexOf(numbersIndexOf, search, 1, 2);

            if (position > -1)
            {
                Console.WriteLine($"Number {search} has been found at position {position}.");
            }
            else
            {
                Console.WriteLine("Not found.");
            }


            /*
            int position = -1;

            for (int i = 0; i < numbersIndexOf.Length; i++)
            {
                if (numbersIndexOf[i] == search)
                {
                    position = i;
                }
            }

            if (position > -1)
            {
                Console.WriteLine($"Number {search} has been found at position {position}.");
            }
            else
            {
                Console.WriteLine("Not found.");
            }
            */

            Console.ReadLine();
        }
    }
}
