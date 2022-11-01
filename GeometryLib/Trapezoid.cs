using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryLib
{
    public class Trapezoid : IFigure
    {
        public double LowerSide { get; protected set; }
        public double LeftSide { get; protected set; }
        public double UpperSide { get; protected set; }
        public double RightSide { get; protected set; }

        public double Height { get; protected set; }

        public double Square { get; protected set; }
        public double Perimeter { get; protected set; }

        public Trapezoid(double lowerSide, double leftSide, double upperSide, double rightSide)
        {
            if (lowerSide <= 0 || leftSide <= 0 || upperSide <= 0 || rightSide <= 0)
                throw new Exception("Стороны неверные!");
            LowerSide = lowerSide;
            LeftSide = leftSide;
            UpperSide = upperSide;
            RightSide = rightSide;

            Perimeter = lowerSide + leftSide + upperSide + rightSide;
            double bigSide, smallSide;
            if (LowerSide >= UpperSide)
            {
                bigSide = LowerSide;
                smallSide = UpperSide;
            }
            else
            {
                bigSide = UpperSide;
                smallSide = LowerSide;
            }
            Height = Math.Sqrt(smallSide * smallSide -
                Math.Pow((Math.Pow(bigSide - RightSide, 2) + RightSide * RightSide + LeftSide * LeftSide) / (2 * (bigSide - smallSide)), 2));
            Square = 0.5 * (bigSide + smallSide) * Height;
        }

        //For Parallelogram
        protected Trapezoid()
        {

        }


    }
}
