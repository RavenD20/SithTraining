using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsole
{
    class Program
    {
        public class File
        {

            //public double account = 1000;

            //public File()
            //{
            //   acct = 1000.00;

            //}

            public double add(ref double account)
            {
                //double BalanceNow;
                double add;

                Console.WriteLine("What would you like to deposit?");
                add = double.Parse(Console.ReadLine());
                account += add;

                return account;


            }

            public double take(ref double account)
            {
                //double BalanceNow;
                double take;

                Console.WriteLine("How much would you like to withdraw today?");
                take = double.Parse(Console.ReadLine());
                //BalanceNow = acct - take;
                account -= take;
                if (take > account) 
                {
                    // Console.WriteLine("Limit exceeded");
                    throw new ArgumentOutOfRangeException("Limit Reached");

                }


                return account;


            }
            public double Bal(ref double mid)
            {
                //double BalanceNow;
                //double Bal;


                //Bal = double.Parse(Console.ReadLine());

                //BalanceNow = Bal;
                //Console.WriteLine("Your account is currently {0}", Bal);
                return mid;/*= BalanceNow*/
            }



        }

        public static double account = 1000;

        static void Main()
        {

            double BalanceNow;
            string acct;
            //double account = 1000;
            File A = new File();

            Console.WriteLine(@"   $
                                ,$$$$$,
                              ,$$$'$`$$$
                              $$$  $   `
                              '$$$,$
                                '$$$$,
                                 '$$$$,
                                   $ $$$,
                               ,   $  $$$
                                $$$,$.$$$'
                                '$$$$$'
                                   $");
            Console.WriteLine(@"
                                Hello and welcome to ___  ___ _ __ ___   ___   __ _  ___ 
                                                    / __|/ __| '__/ _ \ / _ \ / _` |/ _ \
                                                    \__ \ (__| | | (_) | (_) | (_| |  __/
                                                    |___/\___|_|  \___/ \___/ \__, |\___|
                                                                               __/ |     
                                                                              |___/ McDucks state of the art Money Pen.");
            Console.Write("Best vault in all of DuckBurg!");
            Console.WriteLine($"Your balance as is, is {account}!");
            Console.WriteLine("What may we assist you with today?");
            Console.WriteLine("1.Id like to make a deposit.\n2.I would like to make a withdrawl.\n3.Id like to know my balance.\n");
            acct = Console.ReadLine();
            /*d*//*ouble.TryParse(acct, out bruh);*/


            if (acct == "1")
            {
                A.add(ref account);
                Console.WriteLine("Your new balance is {0}", account);
            }
            if (acct == "2")
            {

                A.take(ref account);
                Console.WriteLine("Your ending balance is {0}", account);
            }
            if (acct == "3")
            {

                A.Bal(ref account);
                Console.WriteLine("Your current balance is {0}", account);

            }


            Console.WriteLine("Is there anything else I can do for you?");
            string reply = Console.ReadLine().ToUpper();
            if (reply == "YES" || reply == "Y" || reply == "SI" || reply == "OUI" || reply == "HAI")
            {

                Main();

            }
            if (reply == "NO" || reply == "N")
            {
                Console.WriteLine("Have a great day, here in DuckBurg.");
                Console.ReadLine();

            }

            else
                Console.WriteLine("Incorrect. Would you like to start over?");
            reply = Console.ReadLine().ToUpper();
            if (reply == "YES" || reply == "Y" || reply == "SI" || reply == "OUI" || reply == "HAI")
            {

                Main();

            }
            else if (reply == "NO" || reply == "N")
            {
                Console.WriteLine("Have a great day, here in DuckBurg.");
                Console.ReadLine();

            }




        }
    }
}

