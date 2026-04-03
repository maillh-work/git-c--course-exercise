using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;

            int[] numbers = new int[3];

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Console.Write("Enter a number: ");
            //numbers[0] = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter a number: ");
            //numbers[1] = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter a number: ");
            //numbers[2] = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine($"{num1} {num2} {num3}");
            Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");

            for (int i = 0; i < numbers.Length; i++) //can select certain position to go through
            {
                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine();

            foreach (int num in numbers) //go through every single position of the array
            {
                Console.Write($"{num} ");
            }
            */
            //version not store data of "angle 1,2,3" 
            const int angleCount = 3;
            int angleSum = 0;

            for (int i = 0; i < angleCount; i++)
            {
                Console.Write($"Enter angle {i + 1}: ");
                angleSum += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(angleSum == 180 ? "Valid" : "Invalid");

            //version store data of "angle 1,2,3"

            const int angleCount1 = 3;
            int[] angles1 = new int[angleCount1];

            for (int i = 0; i < angles1.Length; i++)
            {
                Console.Write($"Enter angle {i + 1}: ");
                angles1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleSum1 = 0;
            foreach (int angle1 in angles1)
            {
                angleSum1 += angle1; //0 + value of each CW
            }
            Console.WriteLine(angleSum1 == 180 ? "Valid" : "Invalid");


            Console.ReadLine();
        }
    }
}
