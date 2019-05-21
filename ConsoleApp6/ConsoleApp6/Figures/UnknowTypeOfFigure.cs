using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Figures
{
    public class UnknowTypeOfFigure: Abstracts.Figure
    {
        // Немного не понял задачи про неизвестный тип фигуры
        private Abstracts.Figure _figure;
        public override double CalculateArea() {

            return new double { };
        }

        public UnknowTypeOfFigure(Abstracts.Figure figure)
        {
          _figure = figure;
        }
    }
}
