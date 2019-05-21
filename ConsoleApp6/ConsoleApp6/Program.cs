using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp6.Classes;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Figures.Triangle triangle = new Figures.Triangle();
             triangle.A = 4;
             triangle.B = 5;
             triangle.C = 6;

           var a = triangle.CalculateArea();

           //a Figures.Circle c = new Figures.Circle(5);


            Console.Write(a);
            Console.ReadLine();
        }
    }
}
