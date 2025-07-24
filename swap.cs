using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT
{
    internal class swap
    {
        
        static void Swap(ref int a,ref int b)
        {
            int Temp = 0;
            Temp = a;
            a = b;
            
            b = Temp;
            return;

        }
        static void Main(string[] args)
        {
            int a = 10;int b = 20;
            Console.WriteLine("a is "+a+"b is  "+b);
            Swap(ref a, ref b);
            Console.WriteLine("a is " + a + "b is " + b);
        }
    }
}
