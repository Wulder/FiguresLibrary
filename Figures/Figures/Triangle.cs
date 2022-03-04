using System;
using System.Collections.Generic;
using System.Linq;


namespace Figures
{
    public class Triangle : Figure
    {

        Side[] sides = new Side[3];

        public Triangle(double[] triangleSides)
        {
            for (int i = 0; i < sides.Length; i++)
                sides[i] = new Side(triangleSides[i]);
        }
        public override double GetArea()
        {
            double hp= GetPerimeter() / 2; //Half of perimeter

            return Math.Sqrt(hp * (hp - sides[0].Length) 
                * (hp - sides[1].Length)
                    * (hp - sides[2].Length));
        }

        public override string GetInfo()
        {
            return
                $"Sides: {sides[0].Length}; {sides[1].Length}; {sides[2].Length};\n" +
                $"Perimeter: {GetPerimeter()}\n" +
                $"Area: {GetArea()}\n" +
                $"Is Right Triangle: {IsRightTriangle()}\n";
        }

        public override double GetPerimeter()
        {
            return sides[0].Length + sides[1].Length + sides[2].Length;
        }

        public bool IsRightTriangle()
        {
            List<Side> components = sides.ToList();
            components.Sort((x,y) => x.Length.CompareTo(y.Length)); //sort sides by Length

            return Math.Pow(components[2].Length, 2) == Math.Pow(components[0].Length, 2) + Math.Pow(components[1].Length, 2) ? true : false;
        } //Проверка прямоугольный ли треугольник

     
    }
}
