using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRestaurant
{
  public class PizzaHut : Restaurant
    {

        //PizzaHut ph = new PizzaHut();

        
      

        public string bread1;
        public string meat1;
       

        public override void PrintToppings()
        {

            Console.WriteLine($"Your Pizza Hut pizza has {sauce} & {meat1} plus {bread1}");



        }
     


    }
}   