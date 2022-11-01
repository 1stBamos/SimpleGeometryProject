using System;

namespace GeometryLib
{
    public class Ellipse : IFigure
    {
        public double A { get; protected set; }
        public double B { get; protected set; }

        public double Square { get; }
        public double Perimeter { get; protected set; }

        public Ellipse(double a, double b)
        {
            if (a <= 0 || b <= 0) throw new Exception("Отричательное число!");
            A = a;
            B = b;
            Square = Math.PI * A * B;
            Perimeter = 2 * Math.PI * Math.Sqrt((A * A + B * B) / 2);
        }
    }
}
