using System;
using System.Reflection;
using System.Reflection.Metadata;
using Shapes;

while (true)
{
    Console.Clear();
    Console.WriteLine("Введите, что вы хотите подсчитать:\n1 - квадрат;\n2 - прямоугольник;\n3 - круг;\n4 - треугольник;\n5 - пирамида(квадрат);\n6 - пирамида(прямоугольник);\n7 - пирамида(круг);\n8 - пирамида(треугольник).");
    int button = int.Parse(Console.ReadLine());
    switch (button)
    {
        case 1:
            Console.Write("Введите длину квадрата: ");
            double length = double.Parse(Console.ReadLine());
            Square square = new Square(length);
            square.Out();
            break;

        case 2:
            Console.Write("Введите ширину прямоугольника: ");
            double width = int.Parse(Console.ReadLine());
            Console.Write("Введите длину прямоугольника: ");
            length = int.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, length);
            rectangle.Out();
            break;

        case 3:
            Console.Write("Введите радиус: ");
            double radius = Double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            circle.Out();
            break;

        case 4:
            Console.Write("Введите значение A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение C: ");
            double c = double.Parse(Console.ReadLine());
            Triangle triangle = new Triangle(a, b, c);
            triangle.Out();
            break;
        //Пирамидки
        case 5:
            Console.Write("Введите длину квадрата: ");
            double doubleLength = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту пирамиды: ");
            double heightPyramid = double.Parse(Console.ReadLine());
            SquarePyramid squarePyramid = new SquarePyramid(doubleLength, heightPyramid);
            squarePyramid.Out();
            break;

        case 6:
            Console.Write("Введите длину прямоугольника: ");
            length = double.Parse(Console.ReadLine());

            Console.Write("Введите ширину прямоугольника: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Введите высоту пирамиды: ");
            heightPyramid = double.Parse(Console.ReadLine());

            RestanglePyramid restanglePyramid = new RestanglePyramid(length, width, heightPyramid);
            restanglePyramid.Out();
            break;

        case 7:
            Console.Write("Введите радиус круга: ");
            radius = double.Parse(Console.ReadLine());

            Console.Write("Введите высоту пирамиды: ");
            heightPyramid = double.Parse(Console.ReadLine());

            CirclePyramid circlePyramid = new CirclePyramid(radius, heightPyramid);
            circlePyramid.Out();
            break;

        case 8:
            Console.WriteLine("Введите A сторону треугольника\nВведите B сторону треугольника\nВведите C сторону треугольника");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту пирамиды: ");
            double heightPyramid3 = double.Parse(Console.ReadLine());
            TrianglePyramid trianglePyramid = new TrianglePyramid(a, b, c, heightPyramid3);
            trianglePyramid.Out();
            break;
    }
}