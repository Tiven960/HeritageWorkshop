using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Trapeze : Triangle
    {
        private double _d;
        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
        {
            D = d;
        }
        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }

        public override double GetArea()
        {
            return (B + D) * H / 2;
        }
        public override double GetPerimeter()
        {
            return A + B + C + D;
        }
        private double ValidateD(double d)
        {
            if (d <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(d),"Side length must be greater than zero.");
            }
            return d;
        }
    }
}
