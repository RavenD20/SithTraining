using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInt = { 1, 5, 12, 66, 27 };
            string[] nameofArray = { "Nancy Drew", "Columbo", "Hardy Boys" };
            for (int i = 0; i < arrayInt.Length; i++)
            {
                Console.WriteLine("The value of the ArrayInt array is\n"  + arrayInt[i]);

            }

            Console.WriteLine("we are now out of the loop");
            Console.ReadLine();
            Maxarray(arrayInt);
            SumArray(arrayInt);
            ListNames(nameofArray);
        }

        public static void SumArray(int[]arrayVals)
        {
            int sumation = arrayVals.Sum();
            Console.WriteLine($"The sum of the array is\n {sumation}");
            Console.ReadLine();
            //int none = arrayVals
        }
        public static void Maxarray(int [] intArray)
        {
            int maxVal = intArray.Max();
            Console.WriteLine($"The maximum value of the array is\n  {maxVal} ");
            Console.ReadLine();
        }

        public static void ListNames(string [] Names)
        {
            //string allNames = Names.All
            for(int k = 0; k < Names.Length; k++)
            {

                Console.WriteLine("The names of the Array Names array are\n"  + Names[k]);
            }

            Console.ReadLine();
        }





    }      
         
         
}
