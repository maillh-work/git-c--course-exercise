using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Conditional_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //condition ? true : false
            int age = -10;
            string result;
            Console.WriteLine(age >= 0 ? "Valid" : "Invalid");

            Console.ReadLine();
        }
    }
}
