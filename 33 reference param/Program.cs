using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_reference_param
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            string name = "Joe";
            //Assign(ref num, ref name);

            //Console.WriteLine(num);
            //Console.WriteLine(name);

            Console.Write("Enter your new name: ");
            string newName = Console.ReadLine();

            if (ChangeName(ref name, newName))
            {
                Console.WriteLine($"Your new name is {name}.");
            }
            else
            {
                Console.WriteLine("New name cannot be empty or null!");
            }
           

            Console.ReadLine();
        }

        static void Assign(ref int num, ref string name)
        {
            name = "Aba";
            num = 20;
        }

        static bool ChangeName(ref string name, string newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }
            return false;
        }
    }
}
