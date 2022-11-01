using System;

namespace GeometryLib
{
    public class Circle : Ellipse
    {
        public double Radius { get; }

        //public double Square { get; }
        //public double Perimeter { get; }

        public Circle(double radius) : base(radius, radius)
        {
            Radius = radius;
            Perimeter = 2 * Math.PI * Radius;
        }


        /*
        public Circle(double radius, double a, double b)
        {
            Radius = radius;
            Square = Math.PI * Radius * Radius;
            Perimeter = 2 * Math.PI * Radius;
        }
        */
    }
}
