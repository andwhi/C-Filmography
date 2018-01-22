using System;

namespace ShapeCalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Shape Calculator");
            Console.WriteLine("================");
            System.Console.WriteLine("Enter the side: ");
            double face = double.Parse(System.Console.ReadLine());

            Tetrahedron t = new Tetrahedron(face);
            SquarePyramid s = new SquarePyramid(face);
            HexagonalPyramid h = new HexagonalPyramid(face);

            System.Console.WriteLine("Area of the tetrahedron = {0:F2}", t.Area);
            System.Console.WriteLine("Area of the square pyramid = {0:F2}", s.Area);
            System.Console.WriteLine("Area of the hexagonal pyramid = {0:F2}", h.Area);
            System.Console.WriteLine();

            System.Console.Write("Enter the area: ");
            double area = double.Parse(System.Console.ReadLine());

            t.Area = area;
            s.Area = area;
            h.Area = area;

            System.Console.WriteLine("Side of the tetrahedron = {0:F2}", t.face);
            System.Console.WriteLine("Side of the square pyramid = {0:F2}", s.face);
            System.Console.WriteLine("Side of the hexagonal pyramid = {0:F2}", h.face);
        }
    }
}