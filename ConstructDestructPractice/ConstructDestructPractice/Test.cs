using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructDestructPractice
{
    class Test
    {

        private double length= 5;
        //This is a constructor below, the name of the class itself

        public Test(double 1)
        {
            double x = 1 + 5;
            Console.WriteLine("This the constructor now");
            Console.WriteLine("");

        }
        //tilda denotes the destructor!
        ~Test()
        {
            System.Diagnostics.Trace.WriteLine("Cleaning up the mess now");
            Console.WriteLine("");

        }
    }
}
