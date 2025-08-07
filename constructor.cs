using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT
{
    internal class constructor
    {
        class employee
        {
            int EmpId;
            string Name;
            string City;
            public employee()
            {

            }
            public employee(int EmpId, string Name)
            {
                this.EmpId = EmpId;
                this.Name = Name;
                
            }
            public employee(int EmpId, string Name, string City):this(EmpId, Name)
            {
                this.City = City;
            }
            public void Display()
            {
                Console.WriteLine("Employee ID: " + EmpId);
                Console.WriteLine("Employee Name: " + Name);
                Console.WriteLine("Employee City: " + City);

            }
            public static void Main(string[] args)
            {
                employee e1 = new employee(1,"john","rjkt");
                e1.Display();

                employee e2 = new employee(2,"hello");
                e2.Display();

                


            }
        }
    }
}
