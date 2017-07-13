using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;




namespace MoreSwitchPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What are your favorite martial arts");
            string art = Console.ReadLine().ToLower();

            switch (art)
            {
                case "gungfu":
                    Console.WriteLine("That is my favorite as well");
                    break;

                case "jujitsu":
                    Console.WriteLine("They definately have a good ground game");
                    break;

                case "muay thai boxing":
                    Console.WriteLine("Love it brutal and deadly");
                    break;

                default:
                    Console.WriteLine("I am not familiar with that");
                    break;
            }
                    Console.WriteLine("End of sequence");
                    Console.ReadKey();

               


                   Console.WriteLine("What is the other name for OHIO");
                   string question = Console.ReadLine().ToLower();
                         int oh;
                         int.TryParse(question, out oh);

            switch (oh)
            {
                 case 1:
                  Console.WriteLine("The Orange state");
                  break;
                  
                case 2:
                    Console.WriteLine("The Buckeye state");
                    break;

                case 3:
                    Console.WriteLine("The Mountain state");
                    break;

                default:
                    Console.WriteLine("That was not one of the choices. Automatic failure");
                    break;
            }


                    Console.WriteLine("One an Done");
                    Console.ReadKey();

                 






            }
         
                  

            }








}
