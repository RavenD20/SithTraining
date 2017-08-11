using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionPractice1
{
    class Program
    {
        static void Main(string[] args)
        {
            int milesDriven;
            int gallonsOfGas;
            int mpg;
            Program p = new Program();

            p.StringError();

            p.NewError();

            p.ArrayError();



            try
            { 

            Console.WriteLine("Enter miles driven");
            milesDriven = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter gallon of gas purchased");
            gallonsOfGas = Convert.ToInt16(Console.ReadLine());

            mpg = milesDriven / gallonsOfGas;
            Console.WriteLine($"You are getting {mpg} miles per gallon");
            Console.ReadLine();
            }

            catch(Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine("there was an div by zero exception");
            }
            Console.WriteLine("our code blew up...but we are still running...Yes.");

        }

        public void ArrayError()
        {

            try
            { 

            int num = 12, denom = 0, result;
            int[] numArray = { 20, 30, 40 };
            //result = num / denom;
                result = numArray[num];
              
            }
             catch(DivideByZeroException er)
            {
                Console.WriteLine(er.Message);

            }
            catch(IndexOutOfRangeException i)
            {

                Console.WriteLine("Wubba lubba dub dub.You broke the array program");
                Console.WriteLine(i.Message);
            }
            Console.WriteLine("We are still running");
            Console.ReadLine();
        }

        public void NewError()
        {

            try
            {
                int firstNum = 20, secondNum = 0, answer;
            answer = firstNum / secondNum;
            Console.ReadLine();

            }
            catch (Exception)
            {

                Console.WriteLine("our code had an error..but we dont know what happend");
            }

            finally // runs no matter what
            {
                Console.WriteLine(" running regardless ");
                Console.Clear();

            }

            Console.ReadLine();
        }
          
        public void StringError()
        {

            try
            {

                int x = 100, y = 0, done;
                done = x / y;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("we are inside the string exception");

            }
            Console.WriteLine("our code keeps going");

            Console.ReadLine();
        }



    }
}
