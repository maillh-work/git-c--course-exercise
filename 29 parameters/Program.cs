using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _29_parameters
{
    //Parameter = biến trong định nghĩa hàm
    //Argument = giá trị truyền vào khi gọi hàm
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5,5));

            int num = ReadInt("a number");
            Console.WriteLine(num);

            int angle = ReadInt("an angle");
            Console.WriteLine(angle);

            int firstNum = ReadInt("the first number");
            int secondNum = ReadInt("the second number");

            Console.WriteLine(Add(firstNum, secondNum));

            string name = ReadString("your name");
            int age = ReadInt("your age");
            Console.WriteLine(UserDetails(name, age));

            Console.ReadLine();
        }

        static int Add(int a, int b)
        {
            return a + b; 
        }

        static int ReadInt(string message)
        {
            Console.Write($"Enter {message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static string ReadString(string message)
        {
            Console.Write($"Enter {message}: ");
            return Console.ReadLine();
        }

        static string UserDetails(string name, int age)
        {
            return $"Hello my name is {name} and my age is {age}.";
        }
    }
}
