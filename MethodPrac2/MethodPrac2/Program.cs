using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPrac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program P = new Program();


           int val1;
            int val2;
          

            Console.WriteLine("Give me the first number ");
            string num1 = Console.ReadLine();
            int.TryParse(num1, out val1);

            Console.WriteLine("Give me the second number ");
            string num2 = Console.ReadLine();
            int.TryParse(num2, out val2);

            // P.Multiply(val1, val2);
            // P.Addition(val1, val2);
            // P.Division(val1, val2);
            // P.Subtraction(val1, val2);
          

            Console.ReadLine();

        }

        public void Multiply(int realnum1, int realnum2)
        {

            int product = realnum1 *realnum2;

            Console.WriteLine($"The product of {realnum1} and {realnum2} is {product}");


        }
        public void Addition(int val1, int val2)
        {

            

            int total = val1 + val2;
            Console.WriteLine($"The total of {val1} added to {val2} is {total}");


        }

          public void Division(int val1, int val2)
        {

            int answer = val1 / val2;
            Console.WriteLine($"{val1} divided by {val2} is {answer}");       


        }

        public void Subtraction(int val1, int val2)
        {


            int remainder = val1 - val2;
            Console.WriteLine($"The remainder of {val1} and {val2} is {remainder}.");

        }

       

    }  
     
}
