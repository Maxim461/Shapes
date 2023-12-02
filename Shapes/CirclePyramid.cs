using System;
namespace Shapes
{
	public class CirclePyramid : Circle
	{
        private double pyramidHeight;

        public CirclePyramid(double radius, double pyramidHeight) : base(radius)
        {
            this.pyramidHeight = pyramidHeight;
        }

        private double SpaceCirclePyramid()
        {
            double x = Math.PI * radius * Math.Sqrt(radius * radius + pyramidHeight * pyramidHeight);
            return Space() + x;
        }

        public double Volume()
        {
            return (1.0 / 3) * Space() * pyramidHeight;
        }

        public void Out()
        {
            Console.WriteLine($"Площадь полной поверхности: {SpaceCirclePyramid()}");
            Console.WriteLine($"Объем пирамиды: {Volume()}");
            Console.WriteLine("Нажмите Enter:");
            Console.ReadKey();
        }
    }
}

