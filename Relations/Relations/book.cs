using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotation;
using static System.Console;

namespace Relations
{
   public class book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        [key]
        public int code { get; set; }
    }
    public class store
    {
        [key]
        public int storeID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual List<Stock> Inventory { get; set; }
    }   
    public class stock
    {
        public int StockID { get; set; }
        public int OnHand { get; set; }
        public int OnOrder { get; set; }
        public virtual book Item { get; set; }

    }
        public class BookContext : DbContext
    {
        public Dbset<book> Books { get; set; }
        public DbSet<store>Stores { get; set; }
        public DbSet<stock>Stocks { get; set; }
    }   









}       
