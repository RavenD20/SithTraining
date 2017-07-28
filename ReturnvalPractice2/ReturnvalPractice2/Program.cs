using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnvalPractice2
{
    class Program
    {
        static void Main(string[] args)
        {



            string age = "";
            string year = "";
            double dig = ;
            double diggery= ;
            string favplace = "";
            string favfood ="";
            string place;
            string food;
            string myfavorites = Preference(favplace, favfood);


            Console.WriteLine("What is your favorite restuarant?");
             place = Console.ReadLine();
            Console.WriteLine("what is your favorite food?");
            food = Console.ReadLine();
            Console.WriteLine($"The place you like to go is {favplace} and your favorite food is {favfood}");
            
            Console.ReadLine();

            double Bdate = Birthday(dig,diggery);

            Console.WriteLine("What is the year?");
            year = Console.ReadLine();
            dig = Convert.ToDouble(year);



            Console.WriteLine("How old are you?");
            age = Console.ReadLine();
            diggery = Convert.ToDouble(age);

            Console.WriteLine($" The year you were born in is {Bdate}");

            Console.WriteLine($"So your favorite place is {favplace} and the dish you like is {favfood} and the year you were born in was {Bdate}.");
            Console.ReadKey();

            //Console.WriteLine("What month were you born in?");


            //int reply = Birthday(Year,age);
            //Console.WriteLine("Your birthday is..");
            //Console.Write(reply);
            //Console.ReadLine();
        }


        public static double Birthday(double dig, double diggery)
        {

           double DateofBirth = dig - diggery;
            return DateofBirth;

        }
        private void Web()
        {






        }

        private static string Preference( string place, string food)
        {
            string WhatILike = place + food;
            return WhatILike;
           
        }

    }       
}
