using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceRestaurant
{
    class program
    {

        static void Main(string[] args)
        {
            pizzaBogo pb = new pizzaBogo();

            pb.sauce = "Tomato Basil";
            pb.beef1 = "steak";
            pb.veg1 = "Mushroom";
            pb.PrintToppings();
            Console.WriteLine();
            

            PizzaHut ph = new PizzaHut();

            ph.sauce = "marinara";
            ph.meat1 = "chicken";
            ph.bread1 = "stuffedcrust";
            ph.PrintToppings();
            Console.WriteLine();
            Console.ReadLine();
        }

        public class pizzaBogo : Restaurant
        {

            public string specialty1;
            public string specialty2;



        }




    }   


}
