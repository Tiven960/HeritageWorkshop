using System;
using System.Collections.Generic;
using System.Text;

namespace Geometry;

public class Circle : GeometricFigure
{
    private double _r;
    public Circle(string name, double r) : base()
    {
        Name = name;
        R = r;
    }
    public double R { 
        get => _r ;
        set => _r = ValidateR(value) ;
    }
    
    public override double GetArea()
    {
        return Math.PI * Math.Pow(R, 2);
    }
    public override double GetPerimeter()
    {
        return 2 * Math.PI * R;
    }

    private  double ValidateR(double r)
    {
        if (r <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(r), "Radius must be greater than zero.");
        }
        return r;
    }
}
