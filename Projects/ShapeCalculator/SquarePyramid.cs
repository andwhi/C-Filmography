using System;
namespace ShapeCalculator
{
    class SquarePyramid : Shape
    {
        public double face;

        public SquarePyramid(double f)
        {
            face = f;
        }

        public override double Area
        {
            get
            {
                return 5 * face * face;
            }
            set
            {
                face = System.Math.Sqrt(value / 5);
            }
        }
    }
}
