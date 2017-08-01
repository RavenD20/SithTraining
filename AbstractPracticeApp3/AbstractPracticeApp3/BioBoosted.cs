using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPracticeApp3
{
   class BioBoosted
    {
       // public abstract string Zoanoid();
    
        public int AbiilityLvl = 225;

        public string Armor = "Scales";

        private string Zoaforming = "Mass*Strength+Speed";

        public int Getability()
        {

            return AbiilityLvl;



        }
        public string Getarmor()
        {

            return Armor; 

        }

        private string GetZoaformation()
        {

            return Zoaforming;
        }

        public string DisplayZoaformation()
        {

            return GetZoaformation();

        }



    }



}
