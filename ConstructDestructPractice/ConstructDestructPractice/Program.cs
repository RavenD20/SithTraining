using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructDestructPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Test t = new Test(13);
            Console.WriteLine("We are in the main method");

            Console.WriteLine("I know who you are");
            Console.ReadLine();

        }
    }
}
