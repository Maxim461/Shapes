using System;
namespace Shapes
{
	public class RestanglePyramid : Rectangle
	{
		private double heightPyramid;
        private double height;

        public RestanglePyramid(double width, double height, double heightPyramid) : base(width, height)
        {
			this.heightPyramid = heightPyramid;
            this.height = height;
        }

        private double SpaceRestanglePyramid()
        {
            double x = width * Math.Sqrt(Math.Pow(height / 2, 2) + Math.Pow(heightPyramid, 2)) + height * Math.Sqrt(Math.Pow(width / 2, 2) + Math.Pow(heightPyramid, 2));

            return Space() + x; ;
        }

        public double Volume()
        {
            return (1.0 / 3) * Space() * heightPyramid;
        }

        public void Out()
        {
            Console.WriteLine($"Площадь полной поверхности: {SpaceRestanglePyramid()}");
            Console.WriteLine($"Объем пирамиды: {Volume()}");
            Console.WriteLine("Нажмите Enter:");
            Console.ReadKey();
        }
    }
}

