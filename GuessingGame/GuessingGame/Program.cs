using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();

            Console.WriteLine("Hello World");

            p.Working();
            p.Extra();
            p.Why();
           

            Console.WriteLine("Im back in the main method");
            Console.ReadKey();
        }
        public void Working ()
        {
            Program Talking = new Program();
            Console.WriteLine("Hey...Im workin over here!!!!");
            
        }

        public static void Talking()
        {

            
            Console.WriteLine("Talking a lot today");

        }
        
        public void Extra()
        {
            Program Extra = new Program();

            Console.WriteLine("Today is too extra");

        }

        public void Why()
        {
            Program Why = new Program();
           
                
                
                Console.WriteLine("Why is fizzbuzz ridiculous");

        }



    }
}
