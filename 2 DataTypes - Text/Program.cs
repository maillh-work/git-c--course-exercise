using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes___Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "name";
                //string can be empty
            char letter = '\0';
                //char cannot, can set default by \0

            Console.Write("Your name is: ");
            Console.WriteLine(name);
            Console.Write("letter: ");
            Console.Write(letter);
            
            //console.Write: print but not linebreak
            //console.WriteLine: print and linebreak

            Console.ReadLine();
        }
    }
}
