using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShape2
{
                
        
     public class Octogon 
    {


        Octogon Oct = new Octogon(0, 0);

              



        protected double length;
        protected double width;
        public Octogon(double l, double w)
        {
            length = l;
            width = w;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {

            Oct.Display();

            Console.WriteLine("What is the Length: {0}", length);
            string L = Console.ReadLine();
            length = Convert.ToInt32(L);
            Console.WriteLine("Whats the Width: {0}", width);
            string W = Console.ReadLine();
            width = Convert.ToInt32(W);
            Console.WriteLine("Area: {0}", GetArea());
            
        }














    } 
}

                
        

