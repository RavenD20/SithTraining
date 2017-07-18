using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TScores
{
    class Program
    {
        static void Main(string[] args)
           
            
        {
         

            int testnum;
            int lowNum = 0;
            int[] bonus = { 20 };
            int highNum = 100;



         
           
            
           
            Console.WriteLine("What is your test score?");
            string valNum = Console.ReadLine();
            int.TryParse(valNum, out testnum);

            while (testnum < lowNum || testnum > highNum)
            {
                Console.WriteLine("The test score you entered isnt valid. What is your score?");
                valNum = Console.ReadLine();
                int.TryParse(valNum, out testnum);
            }
            Console.WriteLine($"Your test score is {testnum}");
              for(int z =0; z < bonus.Length; ++z)
            {
              //Console.WriteLine($"You grand total is {testnum}");
                testnum += bonus[z];
            }
            Console.WriteLine($"The total score is {testnum}");
            Console.ReadLine();







        }
    }
}
