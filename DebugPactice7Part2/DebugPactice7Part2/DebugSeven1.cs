// Uses DisplayWebAddress method three times
using static System.Console;


class DebugSeven1
{
  public static void debugseven1()
   {


       // DebugSeven1.debugseven1();

        DisplayWebAddress();

        WriteLine("Shop at Shopper's World");

        DisplayWebAddress();

        WriteLine("The best bargains from around the world");

        DisplayWebAddress();

        ReadLine();
   }
   private static void DisplayWebAddress()
   {
      WriteLine("------------------------------");
      WriteLine("Visit us on the web at:");
      WriteLine("www.shoppersworldbargains.com");
      WriteLine("******************************");
   }
}
