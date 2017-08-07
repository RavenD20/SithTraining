// Program demonstrates overloaded methods
// that display an int, an amount of money, or a string
// decorated with an argument character
// or a default character 'X'
using static System.Console;
class DebugEight4
{
  public static void EightFour()
   {
       FancyDisplay(33);
       FancyDisplay(44, '0');
       FancyDisplay(55.55);
       FancyDisplay(77.77, '*');
       FancyDisplay("hello");
       FancyDisplay("goodbye", '#');
   }
   private static void FancyDisplay(int num, char decoration = 'X')
   {
      WriteLine("{0}{1}  {1}  {0}{1}\n",
         decoration, num); 
   }
   private static void FancyDisplay(double num, char decoration = 'X')
   {
      WriteLine("{0}{1}    {0}{1}\n",
         decoration, num.ToString("C")); 
   }
   private static void FancyDisplay(string word, char decoration = 'X')
   {
      WriteLine("{0}{1}  {1}  {0}{1}\n",
         decoration, word); 
   }
         
}
