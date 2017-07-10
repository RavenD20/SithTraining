using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    class Program
    { 
        static void Main(string[] args)
        {
            // Rudeboy

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            // string concatenation
            Console.WriteLine("Hello " + name + " it is a good day to die");
            Console.ReadLine();
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("Wow youre old...");
            Console.Write("Im sorry that was mean... \n");
            Console.WriteLine(age + " Years old person named " + name + " ..Hmm..Well atleast you look your age.");
            Console.Write("Hahaha... You wont be missed\n");
            Console.Write("Are you going out tonight?:");
            string goingout = Console.ReadLine();
        
            //string interpolation
            Console.WriteLine($"Your name is {name} and youre {age} of course you are, {goingout}");
        
            Console.ReadKey();






          

        }
    }
}
