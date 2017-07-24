using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstrealnumber, secondrealnumber;
            double firstDouble;
            Console.WriteLine("Give me a number to work with");
            
           string firstnum = Console.ReadLine();
            Console.WriteLine("Give me a second double to work with");
            string secondnum = Console.ReadLine();
            // string secondDouble = Console.ReadLine();
            int.TryParse(firstnum, out firstrealnumber);
            int.TryParse(secondnum, out secondrealnumber);
           // int.TryParse(secondDouble, out firstDouble);
            //multiplyIntegers();
            // multiplyIntegers(firstrealnumber);
            //multiplyIntegers();
            //  multiplyIntegers(firstDouble);

            multiplyIntegers(firstrealnumber, secondrealnumber);

        }


        public static void multiplyIntegers()
        {
            int number1= 0 ;
            Console.WriteLine($"The first real number is here {number1} with no integers");
            Console.ReadLine();


        }

        public static void multiplyIntegers(int number1)
        {
            int number2= 1 ;
            Console.WriteLine($"The first realnumber is here {number1} with 1 integers");
            Console.ReadLine(); 

        }

        public static void multiplyIntegers(int val1, int val2)
        {

            Console.WriteLine("The first real number is hear with two integers");
            Console.ReadLine();
            int product = val1 * val2;

            Console.WriteLine($"The product of {val1} and {val2} is {product}");
            Console.ReadLine();

        }

        public static void multiplyIntegers(double valdouble)
        {
            Console.WriteLine($"The first double value us {valdouble}");
            Console.ReadLine();






        }

           
            
            
    }









        
}
