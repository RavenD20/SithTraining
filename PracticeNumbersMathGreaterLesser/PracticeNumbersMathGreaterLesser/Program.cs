using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeNumbersMathGreaterLesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What level were you when fighting the boss?");
           double firstnum = double.Parse(Console.ReadLine());

            if (firstnum >= 1 && firstnum <= 10)
            {
                Console.WriteLine("Dead before you even knew it");
            }
            else if (firstnum >= 11 && firstnum <= 20)
            {
                Console.WriteLine("Massacre");
            }
            else if (firstnum >= 21 && firstnum <= 30)
            {
                Console.WriteLine("A brutal loss");
            }
            else if (firstnum >= 31 && firstnum <= 40)
            {
                Console.WriteLine("Dead Already?");
            }
            else if (firstnum >= 41 && firstnum <= 50)
            {
                Console.WriteLine("Struggling Much?");
            }
            else if (firstnum >= 51 && firstnum <= 60)
            {
                Console.WriteLine("Now youre getting somewhere");
            }
            else if (firstnum >= 61 && firstnum <= 70)
            {
                Console.WriteLine("A Challenger Appears...");
            }
            else if (firstnum >= 71 && firstnum <= 80)
            {
                Console.WriteLine("Now this is a real fight");
            }
            else if (firstnum >= 81 && firstnum <= 90)
            {
                Console.WriteLine("Bloodfest");
            }
            else if (firstnum >= 91 && firstnum <= 100)
            {
                Console.WriteLine("WAR");
            }
            else
            {
                Console.WriteLine("This is utter destruction?! Where did you get this power???!!!!");
            }
            Console.ReadKey();
        }
}   }            