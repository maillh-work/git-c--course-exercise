using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes___Convert_string_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textAge = "-23";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine(age);

            string textBigNumber = "-999999999";
            long bigNumber = Convert.ToInt64(textBigNumber);
            //convert doesn't have to include L,D,F,M definator at the end
            Console.WriteLine(bigNumber);

            string textDouble = "-55.2";
            double negative = Convert.ToDouble(textDouble);
            Console.WriteLine(negative);

            string textFloat = "99.99";
            float precision = Convert.ToSingle(textFloat);
            Console.WriteLine(precision);

            string textMoney = "88.88";
            decimal money = Convert.ToDecimal(textMoney);
            Console.WriteLine(money);

            Console.ReadLine();
        }
    }
}
