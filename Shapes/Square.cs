using System;
namespace Shapes
{
	public class Square
	{
		protected double length;

        public Square(double length)
		{
			this.length = length;
		}

        protected double Perimeter()
		{
			return (length * 4);
		}

        protected double Space()
		{
            return (length * length);
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