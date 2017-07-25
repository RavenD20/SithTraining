using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using 2 arguments here!!!");
            DisplaySize(10, 20);
            Console.WriteLine("Using 3 arguements now");
            DisplaySize(1, 2, 3);
            Console.ReadLine();
        }

        public static void DisplaySize(int length, int width, int height = 1)
        {
            int area = length * width * height;
            Console.WriteLine($"the {length} * the {width} * the optional height of {height}  equals {area}");
            Console.ReadLine();


        }
    }
}
