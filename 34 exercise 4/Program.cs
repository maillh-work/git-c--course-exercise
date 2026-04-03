using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34_exercise_4
{
    internal class Program
    {
        //ask user for width and height, store them
        //create function to calculate the area: (width * height/ 2)
        //call in main and print out the area of the triangle
        
        static void Main(string[] args)
        {
            int width = ReadInt("width");
            int height = ReadInt("height");

            Console.WriteLine($"Area of this triangle is {area(width,height)}.");
            
            Console.ReadLine();

            //exercise 2: sum of int array

        }

        static int ReadInt(string message)
        {
            string input = "";

            /*
            while (true) //dung while(true) luon phai co break -> neu khong, infinite loop
            {
                Console.Write($"Enter a {message}: ");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Cannot be empty");
                }
                else
                {
                    break;
                }
            }
            return Convert.ToInt32(input);
            */
            
            Console.Write($"Enter a {message}: ");
            input = Console.ReadLine();

            while(string.IsNullOrEmpty( input ))
            {
                Console.WriteLine("Cannot be empty");
                Console.Write($"Enter a {message}: ");
                input = Console.ReadLine(); //neu khong co, input van giu gia tri empty o lan nhap trc do -> infinite loop
            }
            return Convert.ToInt32(input);
        }

        static int area(int x, int y)
        {
            return (x * y) / 2;
        }
    }
}
