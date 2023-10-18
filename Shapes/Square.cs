using System;
namespace Shapes
{
	public class Square
	{
		private int Length;

        public Square(int Length)
		{
			this.Length = Length;
		}

		private void Perimeter()
		{
			Console.Clear();
			int PerimeterVar = Length * 4;
			Console.WriteLine($"Периметр квадрата = {PerimeterVar}");
		}

        private void Space()
		{
            int SpaceVar = Length * Length;
            Console.WriteLine($"Площадь квадрата = {SpaceVar}");
        }
    }
}

