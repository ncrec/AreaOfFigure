using System;

namespace AreaOfFigure.Figures
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
            Validate();
        }
        private void Validate()
        {
            if (_radius <= 0)
                throw new ArgumentException("Radius must be positive");
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
