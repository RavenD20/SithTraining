using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Shoes Sbx = new Shoes();
            Sbx.ShoeID =00;
            Sbx.ShoeSize =8.5;
            Sbx.ShoeLaces = false;
            Sbx.ShoeType ="Sandals";
            Sbx.ShoeColor ="Tan";



            Shoes Sbx1 = new Shoes();
            Sbx1.ShoeID =01;
            Sbx1.ShoeSize =10;
            Sbx1.ShoeLaces = false;
            Sbx1.ShoeType = "Loafers";
            Sbx1.ShoeColor = "Brown";



            Shoes Sbx2 = new Shoes();
            Sbx2.ShoeID =02;
            Sbx2.ShoeSize =7.5;
            Sbx2.ShoeLaces = true;
            Sbx2.ShoeType = "Sneakers";
            Sbx2.ShoeColor = "White";

            Shoes Sbx3 = new Shoes();
            Sbx3.ShoeID =03;
            Sbx3.ShoeSize =6.25;
            Sbx3.ShoeLaces = false;
            Sbx3.ShoeType = "Ballet Slippers";
            Sbx3.ShoeColor = "Pink";

            Shoes Sbx4 = new Shoes();
            Sbx4.ShoeID =04;
            Sbx4.ShoeSize =8;
            Sbx4.ShoeLaces = false;
            Sbx4.ShoeType = "Flip Flops";
            Sbx4.ShoeColor = "Black";


            List<Shoes> menuList = new List<Shoes>();

            menuList.Add(Sbx);
            menuList.Add(Sbx1);
            menuList.Add(Sbx2);
            menuList.Add(Sbx3);
            menuList.Add(Sbx4);


            foreach (Shoes item in menuList)
            {
                if (item.ShoeLaces == true)
                {
                    Console.WriteLine("Sneaker half off Sale!!!!!");
                }
                 
               else if (item.ShoeLaces == false)
                {
                    Console.WriteLine("Sale for all others starts next Week!!! Reserve yours now!");
                }

            }

            foreach (Shoes item in menuList)
            {
                Console.WriteLine("Welcome to ShoesStuff Galore.");
                Console.WriteLine($"We carry {item.ShoeType}");
                Console.WriteLine($"The size and color are {item.ShoeSize} and {item.ShoeColor}\n");
               



            }

            Console.ReadLine();
        }
    }
}
