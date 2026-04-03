using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Console_Input_ouput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write( "Enter your name: ");
            string name = Console.ReadLine(); //after input name in console, data will be stored in var "name"
            //Console.WriteLine("Confirm your name: " + name); //in this line, the compiler will display data of var "name"
            
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Confirm your age: " + age);

            Console.WriteLine();
            Console.Write("Your name is "+ name + ". Your age is " + age + "."); // -> notion of concatenate strings


            Console.ReadLine(); //console read line can only return a string
        }
    }
}
