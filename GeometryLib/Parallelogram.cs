using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryLib
{
    public class Parallelogram : Trapezoid
    {
        public double Angle { get; }

        public Parallelogram(double baseSide, double sideSide, double angle)
        {
            if (angle >= 180 || angle <= 0) throw new Exception("Угол неверный!");
            if (baseSide <= 0 || sideSide <= 0) throw new Exception("Стороны неверные!");
            LowerSide = baseSide;
            LeftSide = sideSide;
            UpperSide = baseSide;
            RightSide = sideSide;
            Angle = angle;

            Perimeter = 2 * (baseSide + sideSide);
            Square = baseSide * sideSide * Math.Sin((angle * Math.PI) / 180);
        }




    }
}
