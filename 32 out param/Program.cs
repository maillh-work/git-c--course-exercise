using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _32_out_param
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            test(out num);

            Console.WriteLine(num);



            List<string> shoppingList = new List<string>
            {
                "Coffee", "Milk"
            };

            //Console.WriteLine(shoppingList.IndexOf("Milk"));
            // Console.WriteLine(FindInList("Coffee", shoppingList, out int index));
            //Console.WriteLine(index);

            Console.Write("Enter an item to search: ");
            string search = Console.ReadLine();

            if (FindInList(search, shoppingList, out int index))
            {
                Console.WriteLine($"Found {search} at index {index}.");
            }
            else
            {
                Console.WriteLine("Not found");
            }


            //int index = shoppingList.IndexOf("Milk");
            //Console.WriteLine(index > -1 ? "Found" : "Not found");

            Console.ReadLine();
        }

        static void test(out int num)
        {
            num = 5;
        }

        static bool FindInList(string s, List<string> list, out int index)
        {
            index = -1;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                }
            }

            return index > -1;
        }
    }
}
