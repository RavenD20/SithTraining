using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the first # to add");
         string firstnum = Console.ReadLine();

            int firstn = Convert.ToInt16(firstnum);



            Console.WriteLine("Give me the second # to add");
         string secondnum = Console.ReadLine();

            int secondn = Convert.ToInt32(secondnum);

          double sum = firstn + secondn; 

            Console.WriteLine($"your first number was {firstnum} and your second number was {secondnum} so your sum is {sum}");
            Console.ReadLine();







        }
    }
}
