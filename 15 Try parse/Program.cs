using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Try_parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool success = true;

            while (success)
            {
                Console.Write("Enter a number: ");
                string numInput = Console.ReadLine();


                if (int.TryParse(numInput, out int num))
                {
                    success = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed to convert");
                }
            }
            
            //interpretion: tao 1 bien bool, cho no luon la true de chay while loop
            //tao input tren console
            //tryParse (bool) -> check xem data input tren console co dung hay khong, return True-False
            //if:neu true -> declare var success = false de ket thuc vong lap, print out gia tri
            //if: neu false -> print out failed to convert va tiep tuc vong lap, cho den khi success != true (bien bool dau tien)


            Console.ReadLine();
        }
    }
}
