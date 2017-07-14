using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumwork
{
    class Program
    {
        enum burgers
        {

            bigmac = 1,
            whopper,
            wendyssingle

        }



        static void Main(string[] args)
        {
            int favburgers;



            Console.WriteLine("What type of burger do you like? \n bigmac \n whopper \n single");

            string favorite = Console.ReadLine();
            int.TryParse(favorite, out favburgers);

            switch ((burgers)favburgers)
            {

                case burgers.bigmac:
                    Console.WriteLine("Not bad");
                    break;

                case burgers.whopper:
                    Console.WriteLine("Kinda tasty");
                    break;

                case burgers.wendyssingle:
                    Console.WriteLine(" wendys is ok");
                    Wendys();
                    break;

                default:
                    break;
            }
            Console.WriteLine("Out of the burger range");
            Console.ReadLine();

           int favfood;

            Console.WriteLine(" Whats your favorite mexican food? \n tacos \n burritos \n nachos");
            string favdish= Console.ReadLine();
            int.TryParse(favdish, out favfood);


            switch ((food)favfood)
            {

                case food.tacos:

                    Console.WriteLine("Tacos are good");
                    break;

                case food.burritos:
                    Console.WriteLine("Burritos are great");
                    break;

                case food.nachos:
                    nachos();
                    break;






            }








            


        }
            
        

        public static void Wendys()
        {

            Console.WriteLine("Wendys burgers are good");
        }


        public static void nachos()
        {

            Console.WriteLine("Nachos are best");

        }





        enum food
        {
            tacos = 1,
            burritos,
            nachos
        }

       
    }

      
       
}
      

      
               
























