using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _20_Empty_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //String to Empty
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            if (name != string.Empty)
            {
                Console.WriteLine($"Your name is {name}.");
            }
            else
            {
                Console.WriteLine("Name is empty.");
            }

            //String equals function

            string message = "Hello";
            string compare = "Hello";

            if (message.Equals(compare))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Different");
            }
            

            //String iteration (loop)
            string message1 = "C# is awesome";

            Console.WriteLine(message1[0]); //C
            Console.WriteLine(message1[1]); //#
            Console.WriteLine(message1[2]); //
            Console.WriteLine(message1[3]); //i

            for (int i = 0; i < message1.Length;i++)
            {
                Console.Write(message1[i]);
                Thread.Sleep(50);//1000ms = 1second
            }

            Console.WriteLine();

            Console.WriteLine(message1.Contains("C"));

            bool contains = false;
            
            for (int i = 0; i < message1.Length; i++)
            {
                if (message1[i].Equals('7'))
                {
                    contains = true;
                }
            }
            Console.WriteLine(contains);

            */

            //isNull or Empty

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Your name is {name}.");

            //if(name != "")
                //Console.WriteLine("0");

            //if (!name.Equals(""))
                //Console.WriteLine("1");

            if(!string.IsNullOrEmpty(name))
                Console.WriteLine("2");

            Console.ReadLine();

        }
    }
}
