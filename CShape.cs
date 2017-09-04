using System;
namespace CShapeProject
{
    abstract public class CShape
    {
        protected double area, perimeter;

        public CShape(){
            
        }

        abstract public double ComputeArea();
        abstract public double ComputePerimeter();
        public double GetArea(){
            return area;
        }
        public double GetPerimeter(){
            return perimeter;
        }

    }
}
