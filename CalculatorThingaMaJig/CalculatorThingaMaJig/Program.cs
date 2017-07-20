using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorThingaMaJig
{
    class Program
    {
        static void Main(string[] args)
        {

            int val1;
            int val2;
            int Mathstuff;


            Console.WriteLine("Welcome to the Calculatron.");
            Console.Write("Your name please?");

            string name = Console.ReadLine();

            Console.WriteLine($"Hello! How may I assist you today {name}?");
            Console.Write("Would you would like to: 1. Add \n 2. Subtract \n 3. Multiply \n 4. Divide");
            string assist = Console.ReadLine();

            int.TryParse(assist, out Mathstuff);



            switch (Mathstuff)           
            {
                case 1:
                   Console.WriteLine(" ");
                    break;



                








            }



        }
    }
}
