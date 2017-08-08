using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeStoreApp
{
    class Shoes
    {
        public int ShoeID { get; set; }
        public double ShoeSize { get; set; }
        public bool ShoeLaces { get; set; }
        public string ShoeType { get; set; }
        public string ShoeColor { get; set; }

        private string shoeBox;
        public string ShoeBox
        {
            get { return shoeBox; }
            set { shoeBox = value; }
        }



















    }

}