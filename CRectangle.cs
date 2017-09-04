using System;
namespace CShapeProject
{
    public class CRectangle:CShape
    {
        private double wide, height;

        public CRectangle(){
            wide = 0;
            height = 0;
        }
        public CRectangle(double wide, double height)
        {
            if (wide > 0)
                this.wide = wide;
            if (height > 0)
                this.height = height;
        }

        public override double ComputePerimeter()
        {
            perimeter = (wide + height) * 2;
            return perimeter;
        }

        public override double ComputeArea()
        {
            area = wide * height;
            return area;
        }
    }
}
