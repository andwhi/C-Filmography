using System;
namespace ShapeCalculator
{
    class HexagonalPyramid : Shape
    {
        public double face;

        public HexagonalPyramid(double f)
        {
            face = f;
        }

        public override double Area
        {
            get
            {
                return 7 * face * face;
            }
            set
            {
                face = System.Math.Sqrt(value / 7);
            }
        }
    }
}
