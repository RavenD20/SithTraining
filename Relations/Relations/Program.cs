using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using static System.Console;



namespace Relations
{
   public class Program
    {
        static void Main(string[] args)
        {

            using (var db = new BookContext())
            {
                Book book1 = new Book
                {
                    Title = "Beginning Visual C# 2015",
                    Author = "Perkins, Reid, and Hammer"

                };
                db.Books.Add(book1);

                Book1 book2 = new Book
                {
                    Title = "Beginning XML",
                    Author = "Fawcett,Quin, and Ayers"

                };








            }

        





    }







}
