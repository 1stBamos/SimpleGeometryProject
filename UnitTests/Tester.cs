using NUnit.Framework;
using GeometryLib;
using System;

namespace UnitTests
{
    public class Tester
    {
        [Test]
        public void Correct_Creation_Ellipse_Perimeter()
        {
            //ARRANGE
            Ellipse ellipse = new Ellipse(5, 4);

            //ACT

            //ASSERT
            Assert.AreEqual(28.45, Math.Round(ellipse.Perimeter, 2));
        }

        [Test]
        public void Correct_Creation_Ellipse_Square()
        {
            //ARRANGE
            Ellipse ellipse = new Ellipse(5, 4);

            //ACT

            //ASSERT
            Assert.AreEqual(62.83, Math.Round(ellipse.Square, 2));
        }

        [Test]
        public void Incorrect_Creation_Ellipse()
        {
            //ARRANGE

            //ACT

            //ASSERT
            Assert.Throws<Exception>(() => new Ellipse(-5, 4));
        }

        [Test]
        public void Correct_Creation_Circle_Perimeter()
        {
            //ARRANGE
            Circle circle = new Circle(5);

            //ACT

            //ASSERT
            Assert.AreEqual(31.42, Math.Round(circle.Perimeter, 2));
        }

        [Test]
        public void Correct_Creation_Circle_Sguare()
        {
            //ARRANGE
            Circle circle = new Circle(5);

            //ACT

            //ASSERT
            Assert.AreEqual(78.54, Math.Round(circle.Square, 2));
        }

        [Test]
        public void Incorrect_Creation_Circle()
        {
            //ARRANGE

            //ACT

            //ASSERT
            Assert.Throws<Exception>(() => new Circle(0));
        }

        [Test]
        public void Correct_Creation_Triangle_Perimeter()
        {
            //ARRANGE
            Triangle triangle = new Triangle(4, 5, 6);

            //ACT

            //ASSERT
            Assert.AreEqual(15, Math.Round(triangle.Perimeter, 2));
        }

        [Test]
        public void Correct_Creation_Triangle_Square()
        {
            //ARRANGE
            Triangle triangle = new Triangle(4, 5, 6);

            //ACT

            //ASSERT
            Assert.AreEqual(9.92, Math.Round(triangle.Square, 2));
        }

        [Test]
        public void Incorrect_Creation_Triangle_Minus()
        {
            //ARRANGE

            //ACT

            //ASSERT
            Assert.Throws<Exception>(() => new Triangle(4, -5, 6));
        }

        [Test]
        public void Incorrect_Creation_Triangle_IncorrectSides()
        {
            //ARRANGE

            //ACT

            //ASSERT
            Assert.Throws<Exception>(() => new Triangle(2, 3, 6));
        }

        [Test]
        public void Right_Triangle()
        {
            //ARRANGE
            Triangle triangle = new Triangle(3, 4, 5);

            //ACT

            //ASSERT
            Assert.AreEqual(true, triangle.IsRight);
        }

        [Test]
        public void NotRight_Triangle()
        {
            //ARRANGE
            Triangle triangle = new Triangle(4, 5, 6);

            //ACT

            //ASSERT
            Assert.AreEqual(false, triangle.IsRight);
        }

        [Test]
        public void Correct_Creation_Parallelogram_Perimeter()
        {
            //ARRANGE
            Parallelogram parallelogram = new Parallelogram(5, 3, 60);

            //ACT

            //ASSERT
            Assert.AreEqual(16, Math.Round(parallelogram.Perimeter, 2));
        }

        [Test]
        public void Correct_Creation_Parallelogram_Square()
        {
            //ARRANGE
            Parallelogram parallelogram = new Parallelogram(5, 3, 60);

            //ACT

            //ASSERT
            Assert.AreEqual(12.99, Math.Round(parallelogram.Square, 2));
        }

        [Test]
        public void Incorrect_Creation_Parallelogram()
        {
            //ARRANGE

            //ACT

            //ASSERT
            Assert.Throws<Exception>(() => new Parallelogram(5, 3, 181));
        }
    }
}