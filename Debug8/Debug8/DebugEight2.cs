// Overloaded method gives bonus points
// whether grade is a number or letter
using static System.Console;
class DebugEight2
{
   static void TScores()
   {
      int numericScore = 82;
        string B = null;
        string letterScore = B;

        Write("Score was {0}. ", numericScore);
      GiveBonus(numericScore);
      WriteLine("Now it is {0}.", numericScore);
      Write("Grade was ", letterScore);
      GiveBonus(letterScore);
      WriteLine("Now it is ", letterScore);
   }
   private static void GiveBonus(int testScore)
   {
      const int BONUS = 5;
      testScore = BONUS;
   }
   private static void GiveBonus(string letterScore)
   {
      const string BONUS = "+";
      letterScore = BONUS;
   }
}

