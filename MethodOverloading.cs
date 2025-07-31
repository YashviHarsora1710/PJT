using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT
{
    internal class MethodOverloading
    {
        void Sum(int x, int y)
        {
            int sum = x + y;    
            Console.WriteLine("Sum of two integers: " + sum);
        }
        void Sum(int x, int y, int z)
        {
            int sum = x + y + z;
            Console.WriteLine("Sum of three integers: " + sum);
        }
        void Sum(float x, double y)
        {
            double sum = x + y;
            Console.WriteLine("Sum of float and double: " + sum);
        }
        public static void Main(string[] args)
        {
            MethodOverloading mo = new MethodOverloading();
            mo.Sum(10, 20); // Calls the first Sum method
            mo.Sum(10, 20, 30); // Calls the second Sum method
            mo.Sum(10.5f, 20.5); // Calls the third Sum method
            Console.WriteLine("Method Overloading Program completed.");
           
        }
    }
}
