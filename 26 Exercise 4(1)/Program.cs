using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Exercise_4_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercise 1: even/odd split
            int number = 0;

            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();
            
            for (int i = 0; i < 21; i++)
            {
                number = i;
                if (number % 2 == 0)
                {
                    evenList.Add(number);
                }
                else
                {
                    oddList.Add(number);
                }
            }

            Console.WriteLine("Evenlist: ");
           foreach (int even in evenList)
            {
                Console.Write($"{even} ");
            }

           Console.WriteLine();

            Console.WriteLine("OddList: ");

           foreach (int odd in oddList)
            {
                Console.Write($"{odd} ");
            }
            Console.WriteLine();

            //exercise 2: array of multiples
            int num = 7;
            int length = 5;
            int[] result = new int[length];
            int counter = 0;

            for (int i = 1; i <= length; i++, counter++)
            {
                result[counter] = num * i;
                //result[i] = num * (i+1);
                //int i = 1; i <= length; i++
                //result[i-1] = num * (i+1);
            }

            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }

            Console.ReadLine();

            }
    }
}
