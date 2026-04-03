using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // +-*/
            int age = 23;

            age++;
            age = age + 10;
            age += 10;

            Console.WriteLine(age);
            age--;
            Console.WriteLine(age);

            //text
            string name = "llhm";
            name += " is programming!";
            //name -= " is programming!"; -> difficult for the compiler to understand and handle
            Console.WriteLine(name);

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch); //combine bit of 2 chars together and display the char of the result


            //++i and i++
            int i = 0;
            Console.WriteLine(++i); //if operator is before the variable, it tells the compiler to do the action first then return the result value
            Console.WriteLine(i);

            int i2 = 0;
            Console.WriteLine(i2++);//in this case, it will return value of i first then do the action increment
            Console.WriteLine(i2); 


            Console.ReadLine();
        }
    }
}
