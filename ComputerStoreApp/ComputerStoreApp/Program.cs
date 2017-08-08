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

            h1.PartID = 001;
            h1.PartName = "Headphones";
            h1.PartType = "Acessory";
            h1.Internal = "No";
            h1.External = "Yes";
            h1.PreformanceRating = 6.7;


            Hardware h2 = new Hardware();

            h2.PartID = 002;
            h2.PartName = "Hard Drive";
            h2.PartType = "Main";
            h2.Internal = "Yes";
            h2.External = "No";
            h2.PreformanceRating = 9.9;



            Hardware h3 = new Hardware();

            h3.PartID = 003;
            h3.PartName = "Keyboard";
            h3.PartType = "Accessory";
            h3.Internal = "No"; 
            h3.External = "Yes";
            h3.PreformanceRating = 7.5;



            partStore.Add(h1.PartID, h1);
            partStore.Add(h2.PartID, h2);
            partStore.Add(h3.PartID, h3);


            foreach (var item in partStore)
            {

                Hardware micro = item.Value;
                micro.CompGear();

                if (micro.PartID == 002)
                {
                    micro.CompGear2();
                }

            }
            Console.ReadLine();

            foreach (KeyValuePair<int, Hardware> item in partStore)
            {
                Hardware hw = item.Value;
                hw.CompGear();
              
            }
            Console.ReadLine();

            
            






        }
    }
}
