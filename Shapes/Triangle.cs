using System;
namespace Shapes
{
	public class Triangle
	{
        protected double a;
        protected double b;
        protected double c;
        protected string result;
        protected double spaceVar;

		public Triangle(double a, double b, double c)
		{
            this.a = a;
            this.b = b;
            this.c = c;
		}

        protected double Perimeter()
        {
            if (a != 0 && b == 0 && c == 0)
            {
                return (a * 3);
            }
            else if (a != 0 && b != 0 && c == 0)
            {
                return a * 2 * b;
            }
            else if (a != 0 && b != 0 && c != 0)
            {
                return a + b + c;
            }
            else
            {
                return 0;
            }
            double halfPerimeter = Perimeter() / 2;
            spaceVar = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
        }

        protected string Space()
        {
            if (a +  b <= c || a + c <= b || b + c <= a)
            {
                return "Такого треугольника не существует.";
            }
            else if (a == b && a == c)
            {
                return "Площадь равностороннего треугольника: "; 
            }
            else if (a == b || a == c || b == c)
            {
                return "Площадь равнобедренного треугольника:"; 
            }
            else
            {
                return "Площадь разностороннего треугольника = {SpaceVar}";
            }
        }

        public void Out()
        {
            Console.WriteLine($"Периметр равностороннего треугольника: {Perimeter()}");
            Console.WriteLine($"{Space()}{spaceVar}");
            Console.WriteLine("Нажмите Enter:");
            Console.ReadKey();
        }
    }
}

