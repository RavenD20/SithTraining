using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStoreApp
{
    class Hardware
    {
        public int PartID { get; set; }
        public string PartType { get; set; }
        public string PartName  { get; set; }
        public bool Internal { get; set; }
        public bool External { get; set; }
        public double PreformanceRating { get; set; }


        public void CompGear()
        {
            Console.WriteLine($"The part name and ID is {PartName} and {PartID}. Is it internal{Internal}? Is it external {External}?\n");
            Console.WriteLine($"The preformance rating is {PreformanceRating}");
            
        }

             public void CompGear2()
        {
            Console.WriteLine("Attention:High preformance Hard Drive parts 20% off!\n");
           
        }
    }
}
