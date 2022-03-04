using System;


namespace Figures
{
    public class Circle : Figure
    {
        double radius;
        public double Radius { get { return radius; } set { radius = value < 0 ? -value : value; } }

        public Circle(double circleRadius)
        {
            Radius = circleRadius;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double GetPerimeter()
        {
            return Math.PI * (radius * 2);
        }

        public override string GetInfo()
        {
            return
                $"Radius: {radius}\n" +
                $"Perimeter: {GetPerimeter()}\n" +
                $"Area: {GetArea()}\n";
        }
    }
}
