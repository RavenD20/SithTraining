// Creates a Breakfast class
// and instantiates an object
// Displays Breakfast special information
using static System.Console;
class FirstMeal
{
  public static void FixedDebugNine()
{


        Breakfast special = new Breakfast ("French Toast" , 4.99);
      //Display the info about breakfast
    WriteLine(special.INFO);
    // then display today's special
    WriteLine("Today we are having {0} for {1}",
       special.INFO,  special.price.ToString());
}

class Breakfast
{
    public string INFO ="Breakfast is the most important meal of the day.";
       
    private string name;
    private double Price;
    // Breakfast constructor requires a
    // name, e.g "French toast", and a price
    public Breakfast(string FrenchToast, double Price)
    {
        name = Frenchtoast;
        Price = 4.99;
    }
    public string Frenchtoast { get; set; }
   public string price { get; set; }

       
}









































}
