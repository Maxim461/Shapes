using System;
namespace Shapes
{
	public class TrianglePyramid : Triangle
    {
        private double pyramidHeight;
		public TrianglePyramid(double a, double b, double c, double pyramidHeight) : base(a, b, c)
        {
            this.pyramidHeight = pyramidHeight;
        }
        private double SpaceTrianglePyramid()
        {
            double s = Perimeter() / 2;
            double triangleArea = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return triangleArea;
        }

        private double Volume()
        {
            return (1.0 / 3) * SpaceTrianglePyramid() * pyramidHeight;
        }

        public void Out()
        {
            Console.WriteLine($"Площадь полной поверхности: {SpaceTrianglePyramid()}");
            Console.WriteLine($"Объем пирамиды: {Volume()}");
            Console.WriteLine("Нажмите Enter:");
            Console.ReadKey();
        }
    }
}

