using System;
namespace Shapes
{
	public class SquarePyramid : Square
	{
		protected double heightPyramid;

        public SquarePyramid(double length, double heightPyramid) : base(length)
		{
			this.heightPyramid = heightPyramid;
        }

		protected double SpaceSquarePyramid()
		{
            double x = Math.Sqrt((length / 2) * (length / 2) + heightPyramid * heightPyramid);
            return Space() + 4 * (0.5 * length * x);
        }

		protected double Valume()
		{
            return (1.0 / 3) * Space() * heightPyramid;
        }

		public void Out()
		{
            Console.WriteLine($"Площадь поверхности пирамиды: {SpaceSquarePyramid()}");
            Console.WriteLine($"Объем пирамиды: {Valume()}");
            Console.WriteLine("Нажмите Enter:");
            Console.ReadKey();
        }
	}
}

