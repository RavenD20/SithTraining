using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp
{
    class FoodItems
    {
        public int FoodID { get; set; }

        public string FoodName { get; set; } 

        public string Icing { get; set; }

        public string CakeType { get; set; }

        public string Filling { get; set; }

        public int Layers { get; set; }

        public string Size { get; set; }

        public double DeliciousFactor { get; set; }

        private string yumYums;

        public string YumYums
        {
            get { return yumYums; }
            set { yumYums = value; }

        }



    }
}
