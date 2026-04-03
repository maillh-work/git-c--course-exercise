using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Var___Const_keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age = 23
            var age = 23; //declare a variable by giving its name and its init value for the compiler to define
            Console.WriteLine(age);

            //long bigNumber = -999999999L;
            var bigNumber = -99999999L;
            Console.WriteLine(bigNumber);

            var negative = -55.2D;
            Console.WriteLine(negative);

            var precision = 99.99F;
            Console.WriteLine(precision);

            var money = 88.88M;
            Console.WriteLine(money);
            Console.WriteLine();

            var name = "llhm";

            var letter = 'a';

            //using var to declare too many variables at at time may be time consuming since you have to read the init value or hover to see which data type it is
            //should use it when the data type is obvious


            //Constant
            Console.WriteLine("Constant section");

            const int vat = 20;
            const double percentVAT = vat / 100D;

            int balance = 1000;

            Console.WriteLine(balance * percentVAT);
            Console.WriteLine(vat);

            Console.ReadLine();
        }
    }
}
