using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Figures
{
   public  class Circle: Abstracts.Figure
    {
        public double Radius { get; set; }

        public override double  CalculateArea()
        {
           return  Math.PI * Math.Pow(Radius, 2);
        }
            
        public Circle()
        {
            Radius = default(int);
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
