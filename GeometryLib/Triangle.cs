using System;

namespace GeometryLib
{
    public class Triangle : IFigure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public double Square { get; }
        public double Perimeter { get; }
        public bool IsRight { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0) throw new Exception("Отрицательные числа!");
            if (a > b + c || b > a + c || c > a + b) throw new Exception("Такой треугольник не существует!");

            A = a;
            B = b;
            C = c;
            Perimeter = a + b + c;

            var halfPerimeter = Perimeter / 2;
            Square = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

            var a2 = a * a;
            var b2 = b * b;
            var c2 = c * c;
            if (a2 == b2 + c2 || b2 == a2 + c2 || c2 == a2 + b2) IsRight = true;
        }


    }
}
