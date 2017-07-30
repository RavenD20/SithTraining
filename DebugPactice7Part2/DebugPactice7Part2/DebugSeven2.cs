// Address an envelope one of two ways
// Using zip code, or using city and state
using static System.Console;
class DebugSeven2
{
    static void Adresses()
   {
      string addressee = "Ms. Brooke Jefferson";
      int zipCode = 60007;
      string cityAndState = "Elk Grove, IL";
        AddressMethod(addressee, cityAndState);
        WriteLine("-----------------------");
      AddressMethod(zipCode);
      WriteLine("-----------------------");
   }
   private static void AddressMethod(int zipCode)
   {
      WriteLine("Zip: {0}" ,zipCode);
   }
   private static void AddressMethod(string person, string cityAndState)
   {
      WriteLine("To : {0}", person);
      WriteLine("{0}, city", cityAndState);
   }
}

