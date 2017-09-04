using System;
namespace CShapeProject
{
    public class CCircle:CShape
    {
        private double radius;
        private double pi = 3.14;

        public CCircle(double radius)
        {
            if (radius > 0)
                this.radius = radius;
            else
                this.radius = 0;
        }

        override public double ComputeArea(){
            area = radius * radius * pi;
            return area;
        }

        override public double ComputePerimeter(){
            perimeter = radius * 2 * pi;
            return perimeter;
        }

    }
}
