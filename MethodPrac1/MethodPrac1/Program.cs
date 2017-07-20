using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPrac1
{
    class Program
    {
        static void Main(string[] args)
        {

            restaurants r = new restaurants();

            Fashion Fash = new Fashion();
            Fashion F = new Fashion();



            Console.WriteLine("This is the main method landing page");

            r.Chipotle();
            F.pants();
            F.shoes();
            r.Benihana();
           
        }

        

        public static void Addition()
        {




        }

        public static void Multiplication()
        {






        }

        public static void division()
        {




        }
     class Fashion
    {

            public static void shirts()
            {

                Console.WriteLine("Button down");






            }

            public void pants()
            {


                Console.WriteLine("No pants no service");


            }


            public void shoes()
            {
                Console.WriteLine(" Shoes?..Yes please we dont like cornchips.");

                Console.WriteLine("Except on tacos");

            }
    }










    }
}
