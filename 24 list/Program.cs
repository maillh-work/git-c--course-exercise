using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[3]
            { 
                1, 2, 3
            };

            List<int> listNumbers = new List<int>();
            
            //{
              //  1,2,3,4,5,6,7,8
            //};

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i]);
            }

            listNumbers.RemoveAt(0);

            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}
