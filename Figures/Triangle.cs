 using System;

 namespace AreaOfFigure.Figures
{
    public class Triangle : IFigure
    {
        private readonly double[] _sidesLength;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            _sidesLength = new[] { firstSide, secondSide, thirdSide };
            Array.Sort(_sidesLength);
            Validate();
        }
        private void Validate()
        {
            for (var i = 0; i < _sidesLength.Length; i++)
            {
                if (_sidesLength[i] <= 0)
                    throw new ArgumentException("Side's length invalid");
            }
            if (_sidesLength[0] + _sidesLength[1] <= _sidesLength[2])
                throw new ArgumentException("Triangle with this side not exist");
        }
        public double GetArea()
        {
            return Math.Sqrt(4 * Math.Pow(_sidesLength[0], 2) * Math.Pow(_sidesLength[1], 2) - Math.Pow(Math.Pow(_sidesLength[0], 2) + Math.Pow(_sidesLength[1], 2) - Math.Pow(_sidesLength[2], 2), 2)) / 4;
        }
        public bool IsRightTriangle()
        {
            return (Math.Pow(_sidesLength[0], 2) + Math.Pow(_sidesLength[1], 2)).Equals(Math.Pow(_sidesLength[2], 2));
        }
    }
  
}
