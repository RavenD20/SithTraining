using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValuePractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string favorite1 ="Lasagna";
            string favorite2 = "Eggs Woodhouse";

            int fav1 = 342;
           int fav2 = 324;
            


           string  ourFavorite = FavoriteFood(favorite1, favorite2);

            Console.WriteLine($"Our favorite foods are {favorite1} and {favorite2} put together these are {ourFavorite}.");
            Console.ReadLine();

           int rnumber = FavoriteNumbers(fav1, fav2);
            
            Console.WriteLine($"Our favorite numbers are {fav1} and {fav2} put together they are {rnumber}");
            Console.Write("Its all for you Damien");
            Console.ReadLine();

        }

        private static string FavoriteFood( string food1, string food2)
        {

            string bestfood = food1 + food2;
            return bestfood;

        }
        private static int FavoriteNumbers( int fav1, int fav2)
        {

            int total = fav1 + fav2;
            return total;
           

        }




    }   
    
}
