using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodpassingRef1
{
    class Program
    {
        static void Main(string[] args)
        {
           int x = 5;
            Console.WriteLine($"in the method x= {x}");
             DisplayValueParameter(x);
            Console.WriteLine($"In the main method the value of x is now {x}");

           DisplayNewValue(ref x);

            Console.WriteLine($"the value of exciting x is now {x}");

            DisplaySecondValue(ref x);

            Console.WriteLine($"The value of z is now {x}");
            Console.ReadLine();
           
        }
        private static void DisplayValueParameter(int x)
        {

            x = 1000;
            Console.WriteLine($" We're in the display Value Parameter \n where x = {x}");
        
        }

        private static void DisplayNewValue(ref int n)
        {

          n = 1000;
            Console.WriteLine($"We are in the very exciting new value method \n where x = {n}");

        }
        private static void DisplaySecondValue(ref int z)
        {
           z = 555;
            Console.WriteLine($"The value of z is now {z}");



        }


    }


}
