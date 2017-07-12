using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithNumbersIfElsePracticeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First number please");
            string number = Console.ReadLine();
            int num1 = Convert.ToInt32(number);

            Console.WriteLine("The second number");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);

            if (num1 > num2)
            {
                Console.WriteLine($"Your first number{number} is greater than number2{number2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"Your first number {number} is lesser than number2{number2}");
            }
            else
            {
                Console.WriteLine($"Your first number{number} and second number{number2} are equal");
            }

              Console.ReadKey();



            Console.WriteLine("Enter a number:");
            double var1 = Convert.ToDouble(ReadLine());
            Console.WriteLine("Enter another number:");
            double var2 = Convert.ToDouble(ReadLine());
            Console.WriteLine("Enter a third number:");
            decimal dec3 = Convert.ToDouble(ReadLine());


                

               
            

            
        }
    }
}
