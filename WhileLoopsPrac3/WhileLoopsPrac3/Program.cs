using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopsPrac3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();



            int randomNum = r.Next(1, 10);
            int actualNum;
            int numofGuesses = 1;
            // string hello = "";

            Console.WriteLine("Guess a number between one and ten. ");

            do
            {

                string numGuess = Console.ReadLine();

                while (int.TryParse(numGuess, out actualNum) || actualNum < 1 || actualNum > 10)

                {
                    Console.WriteLine($"You have entry of {numGuess} is not valid. \n Try again.");
                    numGuess = Console.ReadLine();
                    //int.TryParse(numGuess, out actualNum);

                    numofGuesses++;
                }

                if (randomNum == actualNum)
                {

                    Console.WriteLine($"Your guess of {randomNum} was correct. \n You guessed {numofGuesses} times");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine($"Your guess of {actualNum} was not correct... \n Try again"); numofGuesses++;
                }
                while (actualNum != randomNum) ;
             


            

    }   }     
} 




