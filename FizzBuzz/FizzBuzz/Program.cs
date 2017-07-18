using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
      class fizzbuzz
    {
        public static void Main(string[] args)
        {


          // $step[0] = 3;
         //  $step[1] = 5;
         //   $step[2] = 15;


            for (int i = 1; 1<= 100; i++)
            {

                if (i % 3 == 0)
                {
                   Console.WriteLine("fizz");
                }
                             
                else if (i % 5 == 0)
                {
                  Console.WriteLine("buzz");
                }
                  
                else if (i % 15 == 0)
                {
                  Console.WriteLine("fizzbuzz");
                }
                 
                else
                {
                  Console.WriteLine(i);
                }
                  Console.ReadKey();
              





            }







        }
    }
}
