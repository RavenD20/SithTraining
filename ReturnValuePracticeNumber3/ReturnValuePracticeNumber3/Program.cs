using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValuePracticeNumber3
{
    class Program
    {
        static void Main(string[] args)
        {
            int earth = 1;
            int fire = 2;
            int wind = 3;
            int water = 4;
            int heart = 5;

            int byyourpowerscombined = CaptainPlanet(earth, fire, wind, water, heart);
            Console.WriteLine(" by your numbers combined");
            Console.WriteLine("You get... ");



            Console.Write(byyourpowerscombined);

            Console.ReadLine();
        }
        private static int CaptainPlanet(int earth, int fire, int wind, int water, int heart)
        {

            int Letourpowerscombine = earth + fire + wind + water + heart;

            return Letourpowerscombine ;
        

        }


    }
}
