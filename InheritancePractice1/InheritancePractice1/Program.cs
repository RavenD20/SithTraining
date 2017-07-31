using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice1
{
    public class Employee
    {

        //base class

        public string FirstName;
        public string LastName;
        public int EmployeeId;
        public string Email;

        public void PrintFullName()
        {

            Console.WriteLine($"My first name is? {FirstName} and my lastname is {LastName}");

        }

    }

    class Program
    {
       
       

    
        public class FullTimeEmployee : Employee
        {
            public double salary;
            public double FullTimeId;




        }
        public class PartTimeEmployee : Employee
        {

            public double HourlyRate;
            public int PartTimeID;


        }
        static void Main(string[] args)
        {
            FullTimeEmployee ft = new FullTimeEmployee();
            ft.FullTimeId = 1001;
            ft.FirstName = "Mary";
            ft.LastName = "Mitchell";
            ft.PrintFullName();

            Console.WriteLine("");

            PartTimeEmployee pt = new PartTimeEmployee();
            pt.PartTimeID = 3025;
            pt.FirstName = "Peter";
            pt.LastName = "Parker";
            pt.PrintFullName();

            Console.ReadLine();


            SeasonalEmployee Se = new SeasonalEmployee();
            CutBackList Cuts = new CutBackList();


        }

        public class SeasonalEmployee : FullTimeEmployee
        {
            public int SeasonalId = 6255;



        }

        public class CutBackList : Employee
        {





        }






    }

  
    






} 













   