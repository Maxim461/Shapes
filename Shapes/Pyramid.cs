using System;
namespace Shapes
{
	public class Pyramid
	{
		private double PerimeterOfTheBase;
		private double Apoferma;
		private double SpaceFooting;
		private double Height;

        public Pyramid(double PerimeterOfTheBase, double Apoferma, double SpaceFooting, double Height)
		{
			this.PerimeterOfTheBase = PerimeterOfTheBase;
			this.Apoferma = Apoferma;
			this.SpaceFooting = SpaceFooting;
			this.Height = Height;
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
    }
}

