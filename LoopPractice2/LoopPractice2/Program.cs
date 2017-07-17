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
                Array.Sort(lvl);
                Console.WriteLine("Their power levels are \n" +(lvl[r]));
            }
            Console.ReadLine();

            for (int dbz = 0; dbz < saiyan.Length; ++dbz)
            {

                Array.Sort(saiyan);
                Console.WriteLine("The exsisting Saiyans seen so far are \n" + (saiyan[dbz]));

            }
            Console.ReadKey();
















        }
    }
}
