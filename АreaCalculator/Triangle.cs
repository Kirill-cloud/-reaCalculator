using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АreaCalculator
{
    public class Triangle : IHaveArea
    {
        public Triangle((double a, double b, double c) triangleSides)
        {
            if (triangleSides.a < 0 || triangleSides.b < 0 || triangleSides.c < 0)
            {
                throw new NegativeValueException();
            }
            this.triangleSides = triangleSides;
        }
        private (double A, double B, double C) triangleSides;
        public double A { get { return triangleSides.A; } }
        public double B { get { return triangleSides.B; } }
        public double C { get { return triangleSides.C; } }

        public double GetArea
        {
            get
            {
                double p = (A + B + C) / 2;

                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }

        public bool IsRightTriangle
        {
            get
            {
                List<double> sortedSides = new() { A, B, C };
                sortedSides.Sort();

                return sortedSides[0] * sortedSides[0] + sortedSides[1] * sortedSides[1] == sortedSides[2] * sortedSides[2];
            }
        }
    }
}
