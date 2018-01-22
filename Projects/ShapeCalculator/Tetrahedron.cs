using System;
namespace ShapeCalculator
{
     class Tetrahedron : Shape
    {
        public double face;

        public Tetrahedron(double f)
        {
            face = f;
        }

        public override double Area
        {
            get
            {
                return 4 * face * face;
            }
            set
            {
                face = System.Math.Sqrt(value / 4);
            }
        }
    }
}
