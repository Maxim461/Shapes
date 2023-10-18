using System;
using System.Reflection;
using System.Reflection.Metadata;
using Shapes;

while (true)
{
    Console.Clear();
    Console.WriteLine("Введите, что вы хотите подсчитать:");
    Console.WriteLine("1 - Квадрат;");
    Console.WriteLine("2 - Прямоугольник;");
    Console.WriteLine("3 - Круг;");
    Console.WriteLine("4 - Треугольник;");
    Console.WriteLine("5 - Пирамидка.");

    ConsoleKey keyInfo = Console.ReadKey().Key;
    switch (keyInfo)
    {
        case ConsoleKey.D1:
            Console.Clear();
            Console.WriteLine("Введите значение в целочисленном виде: ");
            Console.WriteLine("Длина: ");
            int Length = int.Parse(Console.ReadLine());
            Console.WriteLine($"Длина: {Length}");
            Square square = new Square(Length);
            Console.Clear();
            typeof(Square).GetMethod("Perimeter", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(new Square(Length), null);
            typeof(Square).GetMethod("Space", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(new Square(Length), null);
            Console.WriteLine("Нажмите Enter чтобы вернуться.");
            Console.ReadLine();
            break;

        case ConsoleKey.D2:
            Console.Clear();
            Console.WriteLine("Введите значения в целочисленном виде: ");
            Console.WriteLine("Ширина: ");
            int Width = int.Parse(Console.ReadLine());
            Console.WriteLine("Длина: ");
            Length = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ширина: {Width}, длина: {Length}");
            Rectangle rectangle = new Rectangle(Width, Length);
            Console.Clear();
            rectangle.Perimeter();
            rectangle.Space();
            Console.WriteLine("Нажмите Enter чтобы вернуться.");
            Console.ReadLine();
            break;

        case ConsoleKey.D3:
            Console.Clear();
            Console.WriteLine("Введите значение: ");
            Console.WriteLine("Радиуса: ");
            double Radius = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Радиуса: {Radius}");
            Circle circle = new Circle(Radius);
            Console.Clear();
            circle.Perimeter();
            circle.Space();
            Console.WriteLine("Нажмите Enter чтобы вернуться.");
            Console.ReadLine();
            break;

        case ConsoleKey.D4:
            Console.Clear();
            Console.WriteLine("Введите значение: ");
            Console.WriteLine("A: ");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("B: ");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("C: ");
            double C = double.Parse(Console.ReadLine());
            Console.WriteLine($"A: {A}, B: {B}, C: {C}");
            Triangle triangle = new Triangle(A, B, C);
            Console.Clear();
            triangle.Perimeter();
            triangle.Space();
            Console.WriteLine("Нажмите Enter чтобы вернуться.");
            Console.ReadLine();
            break;

        case ConsoleKey.D5:
            Console.Clear();
            Console.WriteLine("Введите периметр основания:");
            double PerimeterOfTheBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите апоферму:");
            double Apoferma = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите площадь основания:");
            double SpaceFooting = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту пирамидки:");
            double Height = double.Parse(Console.ReadLine());
            Pyramid pyramid = new Pyramid(PerimeterOfTheBase, Apoferma, SpaceFooting, Height);
            pyramid.Space();
            pyramid.Volume();
            Console.ReadLine();
            break;
    }
}