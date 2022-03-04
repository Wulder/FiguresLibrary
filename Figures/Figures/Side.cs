using System;


namespace Figures
{
    internal class Side
    {
        double length;
        public double Length { get { return length; } set {length = value < 0 ? -value : value; } }
        Point origin, direction;

        public Side(double value)
        {
            Length = value;
        }

        public Side(double value, Point triangleOrigin, Point triangleDirection) : this(value)
        {
            origin = triangleOrigin;
            direction = triangleDirection;
        }
      
    }
    struct Point
    {
       public double x, y, z;
    }
        

}
