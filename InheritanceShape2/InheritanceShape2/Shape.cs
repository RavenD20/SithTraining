using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceShape2
{
    class Shape
    {
          static void Main(string[] args)
            {
             //  Rectangle Rec = new Rectangle(0,0);

               // Rec.Display();

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
