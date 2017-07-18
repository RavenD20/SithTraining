using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopsPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
           int idNum;
            int lowNum = 1000;
            int highNum = 2000;

            Console.WriteLine("Enter a valid ID number");
            string valNum = Console.ReadLine();
            int.TryParse(valNum, out idNum);

            while(idNum < lowNum || idNum > highNum)
            {
                Console.WriteLine($"The ID number you entered {valNum} \n" + $"must be between {lowNum} and {highNum}.\n Try again?");

                valNum = Console.ReadLine();
                int.TryParse(valNum, out idNum);
            }

            Console.WriteLine("The ID number that you entered is valid.");
            Console.ReadKey();



        }
    }
}
