using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutPutparameterPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            int first = 0, second = 0;
            Console.WriteLine($"the initial value of the first is {first} \n the inital value of the second = {second}");


            p.FindValues(out first, out second);
            Console.WriteLine($"The final value of the first is {first} \n the final value of the second = {second}");

        }

        private void FindValues(out int firstnum, out int secondnum)
        {
            Console.WriteLine("Give me a first # to work with");

            string firstval = Console.ReadLine();

            int.TryParse(firstval, out firstnum);
            Console.WriteLine("Give me a second # to work with");

            string secondval = Console.ReadLine();
            int.TryParse(secondval, out secondnum);


            firstnum = firstnum + secondnum;
            secondnum = (firstnum - secondnum) * secondnum;

            Console.WriteLine("");
        }





    }    
}
