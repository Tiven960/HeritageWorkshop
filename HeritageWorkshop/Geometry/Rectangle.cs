using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry
{
    public class Rectangle : Square
    {
        private double _b;
        public Rectangle(string name, double a, double b) : base(name, a)
        {
            B = b;
        }
        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }
        
        public override double GetArea()
        {
            return A * B;
        }
        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }
        private double ValidateB(double b)
        {
            if (b <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(b),"Side length must be greater than zero.");
            }
            return b;
        }
    }
}
