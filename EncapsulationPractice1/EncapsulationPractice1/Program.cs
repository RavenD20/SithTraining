using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPractice1
{
    class program
    {
       
       static void Main(string[] args)
        {
            Student s = new Student();
            Student s1 = new Student();
            Student s2 = new Student();

            s.IdNumber = 1001;
            s.FirstName = "Diana";
            s.LastName = "Prince";

        }

       public void ShowStudent(Student scholar)
        {

            Console.WriteLine($"My Id Number is {scholar.IdNumber}, my first name is {scholar.FirstName} and my lastname is {scholar.LastName}");


        }
                
                
                
       
                
                
                
                
                
                
                
                
                
                
                
        
                            
            
                       
       
    }
}
