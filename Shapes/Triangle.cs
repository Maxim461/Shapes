using System;
namespace Shapes
{
	public class Triangle
	{
        private double A;
        private double B;
        private double C;
        private double PerimeterVar;
        
		public Triangle(double A, double B, double C)
		{
            this.A = A;
            this.B = B;
            this.C = C;
		}

        public void Perimeter()
        {
            Console.Clear();
            if (A != 0 && B == 0 && C == 0)
            {
                PerimeterVar = A * 3;
                Console.WriteLine($"Периметр равностороннего треугольника = {PerimeterVar}");
            }
            else if (A != 0 && B != 0 && C == 0)
            {
                PerimeterVar = A * 2 * B;
                Console.WriteLine($"Периметр равнобедренного треугольника = {PerimeterVar}");
            }
            else if (A != 0 && B != 0 && C != 0)
            {
                PerimeterVar = A + B + C;
                Console.WriteLine($"Периметр разностоннего треугольника = {PerimeterVar}");
            }
            else
            {
                Console.WriteLine("Треугольника не существует.");
            }
        }

        public void Space()
        {
            double HalfPerimeter = PerimeterVar / 2;
            double SpaceVar = Math.Sqrt(HalfPerimeter * (HalfPerimeter - A) * (HalfPerimeter - B) * (HalfPerimeter - C));
            if (A +  B <= C || A + C <= B || B + C <= A)
            {
                Console.WriteLine("Такого треугольника не существует.");
            }
            else if (A == B && A == C)
            {
                Console.WriteLine($"Площадь равностороннего треугольника = {SpaceVar}"); 
            }
            else if (A == B || A == C || B == C)
            {
                Console.WriteLine($"Площадь равнобедренного треугольника = {SpaceVar}"); 
            }
            else
            {
                Console.WriteLine($"Площадь разностороннего треугольника = {SpaceVar}");
            }
        }
    }
}

