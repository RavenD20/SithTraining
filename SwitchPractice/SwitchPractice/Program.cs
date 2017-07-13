using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SwitchPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is you favorite color");
            string color = Console.ReadLine().ToLower();


            switch (color)
            {

                case "red":
                    Console.WriteLine("Red is an ok color");
                    break;

                case "blue":
                    Console.WriteLine("Eh blue");
                    break;

                case "pink":
                    Console.WriteLine("Pink is ok");
                    break;

                default:
                    Console.WriteLine("we dont understand your answer");
                    break;

            }

            
            Console.Write("We broke out of the loop");
            Console.ReadLine();
            int foodlike;
            Console.WriteLine(" Whats in your favorite pasta dish \n 1.Lasagna \n 2.Spaghetti \n 3. Ravioli");
            string foodchoice = Console.ReadLine();
            //int foodchoice = Convert.ToInt32(ReadLine().ToUpper());
            //double food = Convert.ToDouble(ReadLine().ToUpper());
             int.TryParse(foodchoice, out foodlike);

            switch(foodlike)
            {
                case 1:
                    Console.WriteLine("Lasagna is fantastic!!!");
                    break;

                case 2:
                    Console.WriteLine("Ravioli was invented by Chev Boyardi!");
                    break;

                case 3:
                    Console.WriteLine("Spaghetti is delicious");
                    break;

                default:
                    Console.WriteLine("That is not a pasta choice we recognize");
                    break;










            }    

                    Console.WriteLine(" We broke out the loop switch statement");

                    Console.ReadLine();






        }
            
       
    }
}
