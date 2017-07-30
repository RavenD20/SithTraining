// GetData() method accepts order number and quantity
// that are used in the Main() method
// Price is $3.99 each
using System;
using static System.Console;
class DebugEight1
{
   static void Main()
   {
        GetData();
        Console.ReadLine();
      
   }
   private static void GetData()
   {
      int orderNum,quantity;



        const double PRICE_EACH = 3.99;
        double total;

        String s1, s2;
       Write("Enter order number ");
       s1 = ReadLine();
       Write("Enter quantity ");
       s2 = ReadLine();
       orderNum = Convert.ToInt32(s1);
       quantity = Convert.ToInt32(s2);



        WriteLine("Order #{0}. Quantity ordered = {1}");
         total = quantity * PRICE_EACH;
        WriteLine("Total is {0}", total.ToString("C"));


    }
}

