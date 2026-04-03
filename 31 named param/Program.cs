using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_named_param
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameInput = "llhm";
            int ageInput = 26;
            string addresInput = "26 nps";

            PrintDetails(age: ageInput, 
                            name: nameInput, 
                            address: addresInput);

            Console.ReadLine();
        }

        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Address: {address}");
        }
    }
}
