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

            
            
            string month = "";
         //   string age = "";
           string year = "";
            string favplace = "";
            string favfood = "";


            string myfavorites = Preference(favplace, favfood);

            Console.WriteLine($"The place you like to go is {favplace} and your favorite food is {favfood}");
            
            Console.ReadLine();


            //Console.WriteLine("What year is it?");
            //year = Console.ReadLine();

            //Console.WriteLine("How old are you?");
            //string age = Console.ReadLine();

            //Console.WriteLine("What month were you born in?");


            //int reply = Birthday(Year,age);
            //Console.WriteLine("Your birthday is..");
            //Console.Write(reply);
            //Console.ReadLine();
        }


        public static int Birthday(int n, int n2)
        {

            //int DateofBirth = year - age;
            //return DateofBirth;

        }
        private static string Preference( string place, string food)
        {
            string WhatILike = place + food;
            return WhatILike;
           
        }

    }       
}
