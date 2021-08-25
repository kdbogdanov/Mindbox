using System;

namespace FiguresMath.Figures
{
    public class Circle : IFigure
    {
        public double Radius { get; }

        public Circle() =>
            Radius = 1;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Radius of the circle can't be <= 0.");
            Radius = radius;
        }

        public double Calculate() =>
            Math.PI * Radius * Radius;
    }
}
