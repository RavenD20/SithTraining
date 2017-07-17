using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopArray
{
    class Program
    {
        static void Main(string[] args)
        {


            int d = 0;           
           int[] pieces = { 33, 22, 51, 78, 90};

            for (d = 0; d < pieces.Length; ++d) 
            {
               
                    Console.WriteLine($"The value of the pieces array is currently {(pieces[d])}");

                    if (pieces[d] == 51)
                {

                        Console.WriteLine("We found 51");
                        break;
                }
                //Console.WriteLine($"The value of the pieces array is currently {(pieces[d])}");

                Console.ReadLine();
            }
            Console.WriteLine("The loop is over!!!");
            Console.ReadLine();


            string[] cars = { "buick", "Datsun", "BMW", "Chevy", "Corvette", "Olds" };

            for (int e = 0; e < cars.Length; ++e)
            {
                Console.WriteLine($"The value of cars array is currently {(cars[e])}");

                if (cars[e] == "Corvette")
                {

                    Console.WriteLine("We found the Vette");
                    break;
                }
                Console.ReadLine();

            }
            Console.WriteLine("We were kicked out of the loop");
            Console.ReadLine();
        }
    }
}
