using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Hardware> partStore = new Dictionary<int, Hardware>();


            

            Hardware h1 = new Hardware();

            h1.PartID =01;
            h1.PartName = "Headphones";
            h1.PartType = "Acessory";
            h1.Internal = false;
            h1.External = true;
            h1.PreformanceRating = 6.7;


               Hardware h2 = new Hardware();

            h2.PartID =02;
            h2.PartName = "Hard Drive";
            h2.PartType = "Main";
            h2.Internal = true;
            h2.External = false;
            h2.PreformanceRating = 9.9;



               Hardware h3 = new Hardware();

            h3.PartID =03;
            h3.PartName = "Keyboard";
            h3.PartType = "Accessory";
            h3.Internal = true;
            h3.External = false;
            h3.PreformanceRating = 7.5;


            foreach (KeyValuePair<int, Hardware> item in partStore)
            {
                Hardware hw = item.Value;
                hw.CompGear();


                if (hw.PartID == 02)
                {
                    hw.CompGear2();
                }

            }  Console.ReadLine();

            
            







        }
    }
}
