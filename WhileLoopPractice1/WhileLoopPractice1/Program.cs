using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoopPractice1
{
    class Program
    {
        static void Main(string[] args)
        {

            string userName = "Locutus of Borg";
            string password = "assimilation";
            Console.WriteLine("What is your username?");
           string inputName = Console.ReadLine();
            Console.WriteLine("What is your password");
            string pw = Console.ReadLine();

            while (inputName != userName || pw != password)
            {
                Console.WriteLine($"Your response is not the correct one {inputName}. Get off the computer poser...Uploading location now.");
                Console.WriteLine("Retry?");
                inputName = Console.ReadLine(); 
                pw = Console.ReadLine();
            }
            Console.WriteLine($"Correct username and password were correct you may proceed {inputName}.");
            Console.ReadLine();





        }
    }
}
