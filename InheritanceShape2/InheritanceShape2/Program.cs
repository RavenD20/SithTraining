using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShape2
{
    using System;
    namespace ShapeApplication
    {
        class Rectangle
        {
            


            


            protected double length;
            protected double width;
            public Rectangle(double l, double w)
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
                
                


                Console.WriteLine("What is the Length? {0}", length);
                string L = Console.ReadLine();
              length = Convert.ToInt32(L);
                Console.WriteLine("Whats the Width? {0}", width);
                string W = Console.ReadLine();
                width = Convert.ToInt32(W);
                Console.WriteLine("Area: {0}", GetArea());
                
               


            }

            static void Main()
            {
               Rectangle Rec = new Rectangle(0,0);

                Rec.Display();

               Square Sqr = new Square(0, 0);


                Sqr.Display();

                Triangle Tri = new Triangle(0, 0);

                Tri.Display();

                Octogon Oct = new Octogon(0, 0);

                Oct.Display();


                Console.ReadLine();
            }





        }


    








    }
}
