using System;
namespace Shapes
{
	public class Rectangle
	{
		private int Width;
        private int Length;

        public Rectangle(int Width, int Length)
		{
			this.Width = Width;
			this.Length = Length;
		}

        public void Perimeter()
        {
            Console.Clear();
            int PerimeterVar = (Length + Width) * 2;
            Console.WriteLine($"Периметр круга = {PerimeterVar}");
        }

        public void Space()
        {
            int SpaceVar = Length * Width;
            Console.WriteLine($"Площадь круга = {SpaceVar}");
        }
    }
}

