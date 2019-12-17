using AreaOfFigure;
using AreaOfFigure.Figures;
using System;

namespace Client
{
    internal class Program
    {
        //не знаю, правильно ли я понял получение площади без знания фигуры
        private static double GetArea(IFigure figure)
        {
            return figure.GetArea();
        }
        private static void Main()
        {
            var triangle = new Triangle(4, 3, 5);
            Console.WriteLine(triangle.IsRightTriangle());
            Console.WriteLine(GetArea(triangle));
            Console.ReadLine();
        }
    }
}
