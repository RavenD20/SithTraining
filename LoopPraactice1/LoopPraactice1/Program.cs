using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPraactice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //i < 10;
            //i++;


            string[] stars = { "Beyonce", "Rihanna", "Janet Jackson", "Madonna" };

            string[] ninjas = { "Scorpion", "Smoke", "Sub-Zero", "Rain", "Ermac", "Noob" };

            int[] lvl = { 1000, 2000, 4000, 6000, 8000, 10000 };

            int[] numbers = { 2, 4, 88, 11, 55, 99, 165 };


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The value of i is {i}");
                //Console.WriteLine("the value of i is {0}", i);
            }
            Console.ReadLine();
            //

            for (int k = 0; k < stars.Length; ++k)
            {
                Console.WriteLine("The stars are " + (stars[k]));

            }
            Console.ReadLine();

            for (int ss = 0; ss <= 5; ++ ss)
            {
                Console.WriteLine($"{ss} ah ah ah ");

            }
            Console.ReadLine();

            for (int n = 0; n < 5; ++n)
            {
                Console.WriteLine("The name of the warring ninjas are \n" +(ninjas[n]));

            }
            Console.ReadKey();

            for (int d = 0; d < numbers.Length; ++d)
            {
                Array.Reverse(numbers);
                Console.WriteLine(numbers[d]);
            }
            Console.ReadKey();

        }
    }
}
