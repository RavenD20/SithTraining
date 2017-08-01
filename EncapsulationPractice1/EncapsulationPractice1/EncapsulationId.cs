using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPractice1
{
    class Student
    {

        private int idNumber;
        private string lastName;
        private string firstName;


        public int IdNumber
        {

            get
            {

                return idNumber;

            }
            set
            {

                IdNumber = value;

            }




        }

        public string LastName
        {

            get
            {

                return LastName;


            }
            set
            {

                LastName = value;

            }






        }

        public string FirstName
        {

            get
            {
                return FirstName;


            }

            set
            {

                FirstName = value;

            }




        }


    }
}
