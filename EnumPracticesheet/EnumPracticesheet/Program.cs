using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPracticesheet
{
    enum Fightstyles
    {
        gungfu =1,
        capoeria,
        silat,
        karate,
        akido


    }

    class Program
    {
        static void Main(string[] args)
        {

            int favstyle;

            Console.WriteLine("What is your favorite fighting style? \n Gungfu \n Capoeria  \n Silat \n Karate \n Akido");

            string fav = Console.ReadLine();

            int.TryParse(fav, out favstyle);


            switch ((Fightstyles)favstyle)
            {

                case Fightstyles.gungfu:
                    Console.WriteLine("Dynamic style");
                    break;

                case Fightstyles.capoeria:
                    Console.WriteLine("Fun style");
                    break;

                case Fightstyles.silat:
                    Console.WriteLine("Deadly style");
                    break;

                case Fightstyles.karate:
                    Console.WriteLine("Strong Style");
                    break;

                case Fightstyles.akido:
                    Console.WriteLine("Smooth Style");
                    break;


                 default:
                    Console.WriteLine("Dont know anything about it");
                    break;

            }
            Console.WriteLine("Out of the Martial Block");
            Console.ReadKey();










        }
    }
}
