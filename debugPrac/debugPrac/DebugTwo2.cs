// This program greets the user
// and multiplies two entered values
using System;
using static System.Console;
class DebugTwo2
{
   static void Main()
   {
        string name;
        string firstString, secondString;

        int first, second, product;

        WriteLine("Enter your name");
        name = ReadLine();

        WriteLine("Hello {0}! Enter an integer", name);

        firstString = ReadLine();
         first = Convert.ToInt16(firstString);

        WriteLine("Enter another integer");

        secondString = ReadLine();
        second = Convert.ToInt32(secondString);

        product = first * second;

       WriteLine("Thank you {0}. The product of {1} and {2} is {3}",
	  name, first, second, product);
   }
}
