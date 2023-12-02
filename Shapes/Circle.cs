using System;
namespace Shapes
{
	public class Circle
	{
        protected double radius;

		public Circle(double radius)
		{
            this.radius = radius;
		}

        protected double Perimeter()
        {
            return (2 * 3.14 * radius);
        }

        protected double Space()
        {
            return (3.14  * (radius * radius));
        }

        public void Out()
        {
            Console.WriteLine($"Периметр квадрата: {Perimeter()};");
            Console.WriteLine($"Площадь квадрата: {Space()}.");
            Console.WriteLine("Нажмите Enter:");
            Console.ReadKey();
        }
    }
}

