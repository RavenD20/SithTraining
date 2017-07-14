using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice1
{
    enum movies
    {
        jaws = 1,
        goodfellas,
        heat,
        scarface,
        godfather,
        avatar,
        inception,
        getout

    }




    class Program
    {
        static void Main(string[] args)
        {
            int favMovie;
            Console.WriteLine(" Which movie is your favorite \n 1. jaws \n 2. goodfellas \n 3. heat");
            string favorite = Console.ReadLine();
            int.TryParse(favorite, out favMovie);

            switch ((movies)favMovie)

            {
                case movies.jaws:

                    Console.WriteLine("Jaws was a great movie");
                    break;

                case movies.goodfellas:
                    Console.WriteLine("never seen it");
                    break;

                case movies.heat:
                    Console.WriteLine("Also never seen it");
                    break;

                default:
                    Console.WriteLine("That movie did not make the list");
                    break;

            }
            Console.WriteLine("Out of the movies switch statement block");
            Console.ReadKey();

        }





       
        
        




                 


























    }
}
