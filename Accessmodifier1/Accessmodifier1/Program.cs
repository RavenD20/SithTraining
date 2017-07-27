using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessmodifier1
{
    class Program
    {
         public static void Main()
        {
            int number1 = 200;
            int number2 = 300;

            int therealnumber = TotalNumber(number1, number2);

            Console.WriteLine($"The numbers {number1} and {number2} multiplied together is... ");

            Console.Write(therealnumber);

            Console.ReadLine();

            int answer = PlusNumber(number1, number2);
            Console.WriteLine(answer);

            double divide = DivideNumber(number1, number2);

            Console.WriteLine(divide);

        }
        private static int TotalNumber(int n1, int n2)
        {

            int product = n1 * n2;
            return product;


        }

        private static int PlusNumber(int n1, int n2)
        {

            int sum = n1 + n2;
            return sum;


        }
        public static double DivideNumber(int n1, int n2)
        {
            double divNumber = n1 / n2;
            return divNumber;

        }
    }
}
