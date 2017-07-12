using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is you favorite color");
            string color = Console.ReadLine();


            switch(color)
            {

                case "red":
                    Console.WriteLine("Red is an ok color");
                    break;

                default:
                    Console.WriteLine("we dont understand yur answer");
                    break; 

            }      

        }
    }
}
