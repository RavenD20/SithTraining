using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElsePractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite car?");
            string favorite = Console.ReadLine().ToLower();

            if (favorite == "chevy")
            {
                Console.WriteLine("I like chevy also.");
            }
            else if (favorite == "dodge")

            {
                Console.WriteLine("I like dodge also");
            }
            else if (favorite == "infiniti")
            {
                Console.WriteLine("Those are NICE");
            }
            else
            {
                Console.WriteLine("We dont understand that car choice");
            }
            Console.ReadLine();
        }   
    }
}









