using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPractice1
{
    class Football 
    {
        public int TeamID { get; set; }
        public string TeamName { get; set; }
        public string Division { get; set; }
        public string Conference { get; set; }
        public double Networth { get; set; }

        public void PrintClub()
        {

            Console.WriteLine($"The {TeamName} with a team ID of {TeamID} in the {Conference} conference, belong to the {Division} its worth is ${Networth}.");
        }


        public void PrintClub2()
        {
            Console.WriteLine($"The {TeamName} with a team ID of {TeamID} in the {Conference} are the best");



        }





    }
}
