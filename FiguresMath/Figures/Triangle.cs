using System;
using System.Collections.Generic;

namespace FiguresMath.Figures
{
    public class Triangle : IFigure
    {
        public double FirstSide { get; }

        public double SecondSide { get; }

        public double ThirdSide { get; }

        public Triangle()
        {
            FirstSide = 3.0;
            SecondSide = 4.0;
            ThirdSide = 5.0;
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            bool isInvalidTriangle = firstSide + secondSide <= thirdSide
                || firstSide + thirdSide <= secondSide
                || secondSide + thirdSide <= firstSide;
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0 || isInvalidTriangle)
                throw new ArgumentException("There is no triangle with given sides.");
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public bool IsRight()
        {
            var sides = new List<double>() { FirstSide, SecondSide, ThirdSide };
            sides.Sort();
            return sides[2] * sides[2] == sides[1] * sides[1] + sides[0] * sides[0];
        }


        public double Calculate()
        {
            var semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * 
                (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
        }
    }
}
