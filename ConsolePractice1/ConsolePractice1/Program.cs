using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola what is your name");
            // string guy = Console.ReadLine();
            // Console.WriteLine($"My name is {guy}");

            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine($"You are {age} old.");


            Console.WriteLine("What is your street name?");
            string street = Console.ReadLine();
            Console.WriteLine($"You live on {street}");

            Console.WriteLine("What is your email address?");
            string address = Console.ReadLine();
            Console.WriteLine($"Your email address is {address}");

            Console.WriteLine($"What is your favorite game?");
            string game = Console.ReadLine();
            Console.WriteLine($"{game} is my favorite game too.");








        }
    }
}
