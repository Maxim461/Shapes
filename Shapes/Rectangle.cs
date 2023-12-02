using System;
namespace Shapes
{
	public class Rectangle
	{
		protected double width;
        protected double length;

        public Rectangle(double width, double length)
		{
			this.width = width;
			this.length = length;
		}

        protected double Perimeter()
        {
            return ((length + width) * 2);
        }

        protected double Space()
        {
            return (length * width);
        }

        public void Out()
        {
            Console.WriteLine($"Периметр прямоугольника: {Perimeter()};");
            Console.WriteLine($"Площадь прямоугольника: {Space()}.");
            Console.WriteLine("Нажмите Enter:");
            Console.ReadKey();
        }
    }
}

