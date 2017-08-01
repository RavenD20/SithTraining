using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRestaurant
{
    public class Restaurant
    {
        public string sauce;
        public string beef1;
        public string beef2;
        public string veg1;
        public string veg2;



        public virtual void PrintToppings()
        {

            Console.WriteLine($"Your pizza has {sauce} + {beef1} and {veg1}");


            



        }
    }
}
