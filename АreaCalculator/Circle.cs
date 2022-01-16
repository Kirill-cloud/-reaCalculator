using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АreaCalculator
{
    public class Circle : IHaveArea
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            if (radius<0)
            {
                throw new NegativeValueException();
            }
            Radius = radius;
        }

        public double GetArea
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }

    }
}
