using System;
namespace Shapes
{
	public class Pyramid
	{
		private double PerimeterOfTheBase;
		private double Apoferma;
		private double SpaceFooting;
		private double Height;
		private double NumberOfSides;
		private double LengthOfSides;

        public Pyramid(double PerimeterOfTheBase, double Apoferma, double SpaceFooting, double Height, double NumberOfSides, double LengthOfSides)
		{
			this.PerimeterOfTheBase = PerimeterOfTheBase;
			this.Apoferma = Apoferma;
			this.SpaceFooting = SpaceFooting;
			this.Height = Height;
			this.NumberOfSides = NumberOfSides;
			this.LengthOfSides = LengthOfSides;
        }

		public void Space()
		{
			Console.Clear();
			double SpaceVar = ((PerimeterOfTheBase * Apoferma) / 2) * SpaceFooting;
			Console.WriteLine($"Площадь поверхности = {SpaceVar}");
        }

		public void Volume()
		{
			double VolumeVar = (1 / 3) * SpaceFooting * Height;
			Console.WriteLine($"Объем поверхности = {VolumeVar}");

        }

		public void Perimeter()
		{
			double PerimeterVar = NumberOfSides * LengthOfSides;
			Console.WriteLine($"Периметр поверхности = {PerimeterVar}");
        }
    }
}

