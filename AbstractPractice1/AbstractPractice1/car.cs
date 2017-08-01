using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice1
{
    class Car
    {

        public int mileage = 60;


        public String color = "Red";


        private string formula = "a+b";

        public int GetMileage()
        {
            return mileage;



        }
        public string GetColor()
        {
            return color;

        }

        private string GetEngineFormula()
        {

            return formula;

        }

        public string DisplayEngineFormula()
        {
            return GetEngineFormula();


        }

    }
}
