using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extra;

namespace MultipleInheritance
{
    class program
    {
        public static void Main(string[] args)
        {
            Apprentice a = new Apprentice();
            a.Display();

            Console.ReadLine();

            Durango d = new Durango();
            int total;

           total= d.preformAddition(4,20);

            Console.WriteLine(total);
            Special();
        }

        public static void Special()
        {
            int sum;
            int total2;
            Durango dur = new Durango();
            dur.Boxer();

           total2 = dur.preformAddition(20,200);
            Console.WriteLine(total2);
        }








    }   


    
    
    
}

