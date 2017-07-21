using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorThingaMaJig
{
    class  Program
    {
        static void Main()
        {
           
            int Mathstuff;

            


            Program p = new Program();

            


       Console.WriteLine("Welcome to the Calculatron.");



            Console.Write("Your name please?");

            string name = Console.ReadLine();

            Console.WriteLine($"Hello! How may I assist you today {name}?");
            Console.Write("Would you would like to:\n 1. Add \n 2. Subtract \n 3. Multiply \n 4. Divide \n");
            string assist = Console.ReadLine();


            int.TryParse(assist, out Mathstuff);
            
            switch (Mathstuff)
            {

                case 1:

                    p.Addition();

                    //Console.WriteLine("Please enter your first number.");
                    //string val1 = Console.ReadLine();
                    //Console.WriteLine("Please enter your second number.");
                    //string val2 = Console.ReadLine();

                  

                    //Console.WriteLine($"You have entered {val1} and {val2} which gives you a sum of {sum}");

                    break;


                case 2:

                    p.Subtraction();
                    
                    //Console.WriteLine("What is your first number?");
                    //var1 = Console.ReadLine();
                    //Console.WriteLine("What is your second number?");
                    //var2 = Console.ReadLine();



                    //Console.WriteLine($"Your first number of {var1} subtracted from {var2} is {remainder}.");

                    break;


                case 3:

                    p.Multiplication();

                    //Console.WriteLine("Your first number is?");
                    //vaz1 = Console.ReadLine();
                    //Console.WriteLine("An your second number is?");
                    //vaz2 = Console.ReadLine();



                    //Console.WriteLine($"The product of {vaz1} and {vaz2} is {product}.");
                    break;


                case 4:

                    p.Division();

                    //Console.WriteLine("Enter your first number please.");
                    //van1 = Console.ReadLine();
                    //Console.WriteLine("And what will be your second?");
                    //van2 = Console.ReadLine();


                    //Console.WriteLine($"{van1} divided by {van2} is {answer}.");
                    break;

                default:
                   
                         Console.WriteLine("You did not enter a numerical value.");
                       Console.WriteLine("Again? \n Yes or No?\n");
                        string answer = Console.ReadLine().ToUpper();
                 
                    if (answer == "YES" || answer =="Y")
                    {

                        p.Recall();

                    }

                    else
                    {
                        Console.WriteLine("Alright..Goodbye!");
                        
                    }


                      Console.WriteLine(" XXXX ");
                      Console.WriteLine("X    XX");
                     Console.WriteLine("X  ***  X                XXXXX");
                    Console.WriteLine("X  *****  X            XXX     XX ");
                 Console.WriteLine("XXXX ******* XXX      XXXX          XX ");
                Console.WriteLine("XX   X ******  XXXXXXXXX                XX XXX");
               Console.WriteLine("XX      X ****  X                           X**  X");
            Console.WriteLine("X        XX    XX     X                      X*** X");
          Console.WriteLine("X         //XXXX       X                      XXXX");
         Console.WriteLine("X         //   X                             XX");
        Console.WriteLine("X         //    X          XXXXXXXXXXXXXXXXXX/");
        Console.WriteLine("X     XXX//    X          X ");
        Console.WriteLine("X    X   X     X         X ");
        Console.WriteLine("X    X    X    X        X");
          Console.WriteLine("X   X    X    X        X                    XX");
          Console.WriteLine("X    X   X    X        X                 XXX  XX ");
           Console.WriteLine("X    XXX      X        X               X  X X  X ");
           Console.WriteLine("X             X         X              XX X  XXXX ");
             Console.WriteLine("X             X         XXXXXXXX\\    XX   XX  X ");
              Console.WriteLine("XX            XX              X     X    X  XX ");
               Console.WriteLine(" XX            XXXX   XXXXXX/     X     XXXX ");
                 Console.WriteLine(" XXX             XX***         X     X ");
                    Console.WriteLine(" XXXXXXXXXXXXX *   *       X     X ");
                                 Console.WriteLine(" * ---* X     X     X ");
                               Console.WriteLine(" * -* *   XXX X     X ");
                               Console.WriteLine(" * - *       XXX   X  ");
                              Console.WriteLine(" * - *X          XXX ");
                              Console.WriteLine(" * - *X  X          XXX ");
                             Console.WriteLine(" * - *X    X            XX  ");
                              Console.WriteLine(" * - *XX    X             X  ");
                              Console.WriteLine(" *  *X* X    X             X  ");
                              Console.WriteLine(" *  *X * X    X             X  ");
                             Console.WriteLine(" *  * X**  X   XXXX          X  ");
                             Console.WriteLine(" *  * X**  XX     X          X  ");
                            Console.WriteLine(" *  ** X** X     XX          X  ");
                            Console.WriteLine(" *  **  X*  XXX   X         X  ");
                           Console.WriteLine(" *  **    XX   XXXX       XXX  ");
                          Console.WriteLine(" *  * *      XXXX      X     X  ");
                         Console.WriteLine(" *   * *          X     X     X  ");
          Console.WriteLine(" =======*******   * *           X     X      XXXXXXXX\\  ");
                 Console.WriteLine(" *         * *      /XXXXX      XXXXXXXX\\      )  ");
            Console.WriteLine(" =====**********  *     X                     )  \\  )  ");
              Console.WriteLine(" ====*         *     X               \\  \\   )XXXXX  ");
          Console.WriteLine(" =========**********       XXXXXXXXXXXXXXXXXXXXXX  ");
                     Console.ReadKey();
                    break; 
            }
        }
        public void Addition()
        {
            Program p = new Program();
            int val3 = (0);
            int val4 = (0);

            Console.WriteLine("Please enter your first number.");
           string val1 = Console.ReadLine();
            Console.WriteLine("Please enter your second number.");
            string val2 = Console.ReadLine();


            int.TryParse(val1, out val3);
            int.TryParse(val2, out val4);
         


            int sum = val3 + val4;

            Console.WriteLine($"You have entered {val1} and {val2} which gives you a sum of {sum}");
            Console.WriteLine("Would you like to go again?\n Yes or No");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "YES" || answer== "Y")
            {

                p.Recall();

            }

            else

            {
                Console.WriteLine("Glad to be of assistance.Goodbye!");
                Console.ReadKey();
            }
        }

        public void Subtraction()

        {
            Program p = new Program();
            int var3 = (0);
            int var4 = (0);

            Console.WriteLine("What is your first number?");
           string var1 = Console.ReadLine();
            Console.WriteLine("What is your second number?");
           string var2 = Console.ReadLine();

            int.TryParse(var1, out var3);
            int.TryParse(var2, out var4);

            int remainder = var3 - var4;
            Console.WriteLine($"Your first number of {var1} subtracted from {var2} is {remainder}.");
            Console.WriteLine("Would you like to go again?\n Yes or No");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "YES"|| answer =="Y")
            {

                p.Recall();

            }

            else
            {
                Console.WriteLine("Adios!");
                Console.ReadKey();
            }
        }

        public void Multiplication()

        {
            Program p = new Program();
            int dig3 = (1);
            int dig4 = (1);

            Console.WriteLine("Your first number is?");
          string dig1 = Console.ReadLine();
            Console.WriteLine("An your second number is?");
           string dig2 = Console.ReadLine();

            int.TryParse(dig1, out dig3);
            int.TryParse(dig2, out dig4);

            int product = dig3 *dig4;
            Console.WriteLine($"The product of {dig1} and {dig2} is {product}.");
            Console.WriteLine("Would you like to go again?\n Yes or No");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "YES"|| answer =="Y")
            {

                p.Recall();

            }

            else
            {
                Console.WriteLine("Alright.I'll be here if you need me!");
                Console.ReadKey();
            }
        }

        public void Division()
        {
            Program p = new Program();
            int van3 = (0);
            int van4 = (0);

            Console.WriteLine("Enter your first number please.");
            string van1 = Console.ReadLine();
            Console.WriteLine("And what will be your second?");
            string van2 = Console.ReadLine();

            int.TryParse(van1, out van3);
            int.TryParse(van2, out van4);

            int response = van3 / van4;
            Console.WriteLine($"{van3} divided by {van4} is {response}.");
            Console.WriteLine("Would you like to go again?\n Yes or No");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "YES"|| answer =="Y")
            {

                p.Recall();

            }

            else
            {
                Console.WriteLine("A pleasure working with you!");
                Console.ReadKey();
            }

        }

        public void Recall()
        {

            Main();

        }

        //public void Addition(int val1, int val2)
        //{
        //   int sum = val1 + val2;

        //    Console.WriteLine("Please enter your first number.");
        //    string val1 = Console.ReadLine();
        //    Console.WriteLine("Please enter your second number.");
        //    string val2 = Console.ReadLine();

        //    Console.WriteLine($"You have entered {val1} and {val2} which gives you a sum of {sum}");


        //}

        //public void  Subtraction(int num1, int num2)
        //{
        //    int remainder = num1 - num2;
        //    Console.WriteLine("What is your first number?");
        //  string num1 = Console.ReadLine();
        //    Console.WriteLine("What is your second number?");
        //   string num2 = Console.ReadLine();

        //    Console.WriteLine($"Your first number of {num1} subtracted from {num2} is {remainder}.");



        //}

        //public void Multiplication(int dig, int dig1)
        //{
        //    int product = dig *dig1;
        //    Console.WriteLine("Your first number is?");
        //   dig = Console.ReadLine();
        //    Console.WriteLine("An your second number is?");
        //   string dig1 = Console.ReadLine();
        //    Console.WriteLine($"The product of {dig} and {dig1} is {product}.");


        //}

        //public void Divisioin(int val3, int val4)
        //{
        //    int answer = val3 / val4;
        //    Console.WriteLine("Enter your first number please.");
        //  string  var3 = Console.ReadLine();
        //    Console.WriteLine("And what will be your second?");
        //  string  var4 = Console.ReadLine();

        //    Console.WriteLine($"{val3} divided by {val4} is {answer}.");

    }
}        

    

