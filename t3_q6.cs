using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace PJT
{


namespace LineApplication

    {

        class Line

        {

            private double length;   // Length of a line

            public Line()

            {

                length = 12;
                Console.WriteLine("length is " + length);

                //………………………………Missing statement-2……………………………….// 

            }



            public void setLength(double len)

            {
                length = len;

                //………………………………Missing statement-3……………………………….//      



            }

            public double getLength()

            {
                return length;

                //………………………………Missing statement-4……………………………….//      

            }

        }



        class TestLine

        {

            static void Main(string[] args)

            {

                Line line = new Line();

                // set line length
                line.setLength(20);

                Console.WriteLine("Length of line : {0}", line.getLength());

                // set line length
                line.setLength(30);

                Console.WriteLine("Length of line : {0}", line.getLength());

                Console.ReadKey();

            }

        }

    }

}