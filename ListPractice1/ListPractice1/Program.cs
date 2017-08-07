using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMobile a1 = new AutoMobile();
            a1.AutoID = 1000;
            a1.Make = "Chevy";
            a1.Model = "Equinox";
            a1.Year = 2009;
            a1.color = "Red";

            AutoMobile a2 = new AutoMobile();
            a2.AutoID = 2000;
            a2.Make = "Ford";
            a2.Model = "Explorer";
            a2.Year = 2012;
            a2.color = "Black";

            List<AutoMobile> carList = new List<AutoMobile>();
            carList.Add(a1);
            carList.Add(a2);

            foreach(AutoMobile item in carList)
            {

                Console.WriteLine($"Our make and model is {item.Make} and {item.Model}");
                Console.WriteLine($"Our car color and year is {item.color} and {item.Year}");
            }


            Console.ReadLine();
            
            
            //for(int i=0; < carList. ; i++)
            //foreach (var item in collection)
            //{

            //}
        }
    }
}
