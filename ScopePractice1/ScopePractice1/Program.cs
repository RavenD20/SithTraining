using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopePractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 1;
            int number2 = 2;

            int sum = number1 * number2;

            Console.WriteLine($" The {number1} * {number2} equals {sum}");
            Console.WriteLine("We are at the bottom of the main method");

            Console.ReadLine();

            Printing();



        }
        static void Printing()
        {

            Console.WriteLine("This is great");
            Console.ReadLine();



            Display();
        }
            public static void Display()
        {

            Console.WriteLine("Today is friday!");
            Console.WriteLine("press any key to continue");
            Console.ReadLine();
        }
        public static void Multiply()
        {





        }

    }

    public class start
    {



        
    }      



} 
