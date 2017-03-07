using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        class Student
        {
          
            public string FirstName;
            public string LastName;
            public double GPA;

           
            public Student(string FirstName, string LastName, double GPA)
            {
                
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.GPA = GPA;
            }
           

            public override string ToString()
            {
                return FirstName + " " + LastName + " " + GPA;
            }
        }

        static void Main(string[] args)
        {
           
            Student a = new Student("Alisher", "Baigazin", 3.82);
            Student b = new Student("Akzhan", "Almukhan", 3.54);
         

            
            Console.WriteLine(a);
            Console.WriteLine(b);

          
            Console.ReadKey();
        }
    }
}
