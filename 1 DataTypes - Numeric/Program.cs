using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = 20;
            //int z = 30;

            //instead of listing as above, it'd more neat to write as follow:

            int x = 10, 
                y = 20, 
                z = 30;

            //declaring a value: var type + name
            //initialize a value: give the var a value

            int age = -23;
            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNumber = -999999999L;
            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -55.2;
            Console.WriteLine(negative);

            float precision = 99.99F;
            Console.WriteLine(precision);

            decimal money = 88.88M;
            Console.WriteLine(money);

            age = 50;

            Console.ReadLine();
        }
    }
}
