using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame1
{
    class Program
    {
        static void Main(string[] args)
        {



            Random rand = new Random();
            int rNum = rand.Next(1, 20);
            int realNum;
            Console.WriteLine("Enter a number between 1 and 20");
            string numGuess = Console.ReadLine();
            int.TryParse(numGuess, out realNum);


            while(realNum != rNum)
            {
                Console.WriteLine($"Your guess of {numGuess} was not the correct number...\n guess again");

                numGuess = Console.ReadLine();

                int.TryParse(numGuess, out realNum);
            }
                              
                    Console.WriteLine($"Youre guess of {rNum} was correct...Hooray");


                    numGuess = Console.ReadLine();
                
               


        }
    }
}
