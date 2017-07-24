using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethodPassing1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sith;
            Sith = ("The Emperor");
           string sith = Console.ReadLine();

            Console.WriteLine($"Sith is in the immediate main method");

            WeirdMethodThing(Sith);
            Console.WriteLine($"Sith is now {sith}");

            MegaMan(ref sith);
            Console.WriteLine($"{Sith} is here, using the MegaMan method");

            DeathStar(ref Sith);
            Console.WriteLine($"The value of the DeathStar Method is now {Sith}");

            Console.WriteLine("I call this the Villan string method");

            Chameleon(ref sith);
            Console.WriteLine($"The new name of sith is {sith}");
            Console.Write("BOOM.");

            Console.ReadLine();



        }
        private static void WeirdMethodThing(String Sith)
        {

            Sith = "Count Dooku";
            Console.WriteLine($"The method we're using is the weirdmethodthing where sith is \n {Sith}");


        }
        private static void MegaMan(ref string DoctorWiley)
        {
            DoctorWiley = "Proto Man";
            Console.WriteLine($"The Doctor Wiley method changes the value of sith to \n {DoctorWiley}");


        }
        private static void DeathStar(ref string LordVader)
        {

            LordVader = "The Darkside";
            Console.WriteLine($"The value of Lord Vader is now {LordVader}");

        }
        private static void Chameleon(ref string Gamechanger)
        {
            Console.WriteLine("What is my new name?");
           string changename = Console.ReadLine();

            Console.WriteLine($"My new name is {changename}");
            Gamechanger = $"{changename}";

            
        }




    }       
}
