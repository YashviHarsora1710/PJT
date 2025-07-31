using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJT
{
    internal class OutDemo
    {
        static void Change(ref int a,ref int b)
        {
            a = 100;
            b = 200;

        }
        static void Update(out int x,out int y)
        {
            x = 100;
            y = 200;
        }
        static void Main()
        {
            int a = 10;int b = 10;
            int x = 14;int y = 85;
            Console.WriteLine("before change: a={0} and b={1} " + a, b);
            Change(ref a,ref b);
            Console.WriteLine("after change: a={0} and b={1} " + a + b);
            Console.WriteLine("before change: x={0} and y={1} " + x, y);
            Update(out x, out y);
            Console.WriteLine("after change: x={0} and y={1} " + x + y);
        }
    }
}
