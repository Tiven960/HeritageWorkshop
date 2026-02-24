using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Triangle : Rectangle
    {
        private double _c;
        private double _h;
        public Triangle(string name, double a, double b,double c, double h) : base(name, a, b)
        {
            C = c;
            H = h;
        }
        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }
        public double C
        { 
            get => _c;
            set => _c = ValidateC(value);
        }
        public override double GetArea()
        {
            return B * H / 2;
        }
        public override double GetPerimeter()
        {
            return A + B + C;
        }
        private double ValidateH(double h)
        {
            if (h <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(h),"Height must be greater than zero.");
            }
            return h;
        }
        private double ValidateC(double c)
        {
            if (c <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(c),"Side length must be greater than zero.");
            }
            return c;
        }
    }
}
