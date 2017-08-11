using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extra
{
   public class Begin
    {
        public static void Main()
        {

            int complete;
            Console.WriteLine("Hello...its Friday!!!");
            Durango dr = new Durango();

                complete = dr.preformAddition(80, 100);
            Console.WriteLine(complete);
            Console.ReadLine();

        }


    }

    public class Durango
    {

        public void Boxer()
        {
            Console.WriteLine("We work to be the best programmers in the world.");

            
        }
        public int preformAddition(int x , int y)
        {

            return x + y;

        }
    }





}
