using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age");
            double firstnum = double.Parse(Console.ReadLine());

            if (firstnum > 1 && firstnum < 10)
            {
                Console.WriteLine("youre just a kid");
            }
            else if (firstnum > 11 && firstnum < 21)
            {
                Console.WriteLine("Youre in your middle years");
            }
            else if (firstnum > 22 && firstnum < 35)
            {
                Console.WriteLine("Your are getting there");
            }
            else if (firstnum > 36 && firstnum < 55)
            {
                Console.WriteLine("You have it figured out by now");
            }
            else if (firstnum > 56 && firstnum < 99)
            {
                Console.WriteLine("You are in your golden years !!!");
            }
            else
            {

                Console.WriteLine("I see dead people");







                
            }
        }
    }
}
                