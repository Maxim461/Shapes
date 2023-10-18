using System;
namespace Shapes
{
	public class Circle
	{
        private double Radius;

		public Circle(double Radius)
		{
            this.Radius = Radius;
		}

        public void Perimeter()
        {
            Console.Clear();
            double PerimeterVar = 2 * 3.14 * Radius;
            Console.WriteLine($"Периметр квадрата = {PerimeterVar}");
        }

        public void Space()
        {
            double SpaceVar = 3.14  * (Radius * Radius);
            Console.WriteLine($"Площадь квадрата = {SpaceVar}");
        }
    }
}

