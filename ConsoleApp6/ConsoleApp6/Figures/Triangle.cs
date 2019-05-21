using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp6.Figures
{
    public class Triangle: Abstracts.Figure
    {

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        /// <summary>
        /// Используем формулу Герона для вычисления площади
        /// </summary>
        public override double CalculateArea()
        {       
                double p = (A + B + C) / 2;

                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public Triangle()
        {
            A = B = C = default(int);
        }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool IsRightTriangle()
        {
            return (A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2))
                || B == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(C, 2))
                || C == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)));
        }
    }
}
