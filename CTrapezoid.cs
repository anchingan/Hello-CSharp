using System;
namespace CShapeProject
{
    public class CTrapezoid:CShape
    {
        private double upperBase, lowerBase, height;

        public CTrapezoid(){
            this.upperBase = 0;
            this.lowerBase = 0;
            this.height = 0;
        }

        public CTrapezoid(double upperBase, double lowerBase, double height):this()
        {
            if (upperBase > 0)
                this.upperBase = upperBase;
            if (lowerBase > 0)
                this.lowerBase = lowerBase;
            if (height > 0)
                this.height = height;
        }

        public override double ComputeArea()
        {
            area = (upperBase + lowerBase) * height / 2;
            return area;
        }

        public override double ComputePerimeter()
        {
            double temp = Math.Sqrt(Math.Pow((Math.Abs(upperBase - lowerBase) / 2), 2) + height * height);
            perimeter = temp * 2 + upperBase + lowerBase;
            return perimeter;
        }
    }
}
