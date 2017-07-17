using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] saiyan = { "Vegeta", "Nappa", "Raditz", "Turles", "Bardock", "Kakorat", "Tarble" };

            int[] lvl = { 1000, 2000, 4000, 6000, 8000, 10000 };




            for (int r = 0; r < 6; r++)
            {
                Array.Reverse(lvl);
                Console.WriteLine("Their power levels are \n" +(lvl[r]));
            }
            Console.ReadLine();

            for (int dbz = 0; dbz < saiyan.Length; ++dbz)
            {

                Array.Sort(saiyan);
                Console.WriteLine("The exsisting Saiyans seen so far are \n" + (saiyan[dbz]));

            }
            Console.ReadKey();
            int[] nums = new int[4];
            nums[0] = 10;
            nums[1] = 20;
            nums[2] = 30;
            nums[3] = 40;

            for (int n = 0; n < 4; ++n)
            {
              //  Console.WriteLine("The values of array nums is " + (nums[n]));
                Console.WriteLine($"The values of array nums is  + {(nums[n])}");
            }

            Console.ReadLine();

            char[] letters = {'v', 'i', 'n', 'e'};
            for (int m = 0; m < letters.Length; ++m)
            {
               Console.WriteLine($"The value of the letters array are {(letters[m])}");
                
              
            }
            Console.ReadKey();


          
            for (int m = 0; m < letters.Length; ++m)
            {

                Console.Write((letters[m]));
            }
            Console.ReadKey();















        }
    }
}
