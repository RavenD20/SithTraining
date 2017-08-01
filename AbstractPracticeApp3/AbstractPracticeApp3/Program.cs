using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPracticeApp3
{
   abstract class Program
    {
        static void Main(string[] args)
        {
            BioBoosted initiate = new BioBoosted();


            Console.WriteLine($"Zoanoid ability:{initiate.Getability()}");


            Console.WriteLine($"Zoanoid armor type:{initiate.Getarmor()}");


            Console.WriteLine($"Transformation type equation:{initiate.DisplayZoaformation()}");


            Console.WriteLine("Process is complete. New Zoanoid underway.");
            Console.Write("Thank you for choosing The Chronos Corporation. ");
          
            Console.ReadLine();
        }
    }
}
