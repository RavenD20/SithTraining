using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp
{
    class Program
    {
        static void Main(string[] args)
        {

            FoodItems Noms = new FoodItems();

            Noms.FoodID = 00;
            Noms.Icing = "Yes-Lemon and White";
            Noms.FoodName = "Mario Question Block";
            Noms.CakeType = "Yellow";
            Noms.Filling = "Gold Chocolate Coins";
            Noms.Layers = 4;
            Noms.Size = "Large";
            Noms.DeliciousFactor = 8.9;

            FoodItems Noms1 = new FoodItems();

            Noms1.FoodID = 01;
            Noms1.Icing = "Yes-Dark Fudge";
            Noms1.FoodName = "Vampires Delight";
            Noms1.CakeType = "Chocolate";
            Noms1.Filling = " Blood Mwah ha ha-Marachino Cherries";
            Noms1.Layers = 3;
            Noms1.Size = "Medium";
            Noms1.DeliciousFactor = 7.5;


            FoodItems Noms2 = new FoodItems();

            Noms2.FoodID = 02;
            Noms2.Icing = "Yes-Melted Candy";
            Noms2.FoodName = "Robot Brownie Pops";
            Noms2.CakeType = "Brownie";
            Noms2.Filling = "Brownies";
            Noms2.Layers = 0;
            Noms2.Size = "Small";
            Noms2.DeliciousFactor = 10;






            
            List<FoodItems> menuList = new List<FoodItems>(new FoodItems[] { Noms, Noms1, Noms2 });



            //List<FoodItems> menuList = new List <FoodItems>();
            menuList.Add(Noms);
            menuList.Add(Noms1);
            menuList.Add(Noms2);

            foreach (FoodItems item in menuList)
            {
                if (item.Layers == 3)
                {
                    Console.WriteLine("Vampires Delight on sale 30%");
                }

                
            }
           






            foreach (FoodItems item in menuList)
                

            {
                Console.WriteLine($"The Name of the dessert is {item.FoodName}\n");
                Console.WriteLine($"It is filled with {item.Filling} and covered with {item.Icing}. On a scale from one to ten it is rates {item.DeliciousFactor}\n");
                Console.Write($"An it comes in {item.Size} size.\n");
            }


            Console.ReadLine();



        }
    }
}
