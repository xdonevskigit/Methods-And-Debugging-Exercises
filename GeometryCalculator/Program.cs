using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string geometryFigure = Console.ReadLine();
            ReadAndWriteAreaForChosenGeometryFigure(geometryFigure);
        }

        static void ReadAndWriteAreaForChosenGeometryFigure(string figure)
        {
            switch (figure)
            {
                case "triangle":
                    double triangleSide = double.Parse(Console.ReadLine());
                    double triangleHeight = double.Parse(Console.ReadLine());
                    double triangleArea = triangleSide * triangleHeight / 2;
                    Console.WriteLine($"{triangleArea:F2}");
                    return;
                case "rectangle":
                    double rectangleWidhth = double.Parse(Console.ReadLine());
                    double rectangleHeight = double.Parse(Console.ReadLine());
                    double rectangleArea = rectangleWidhth * rectangleHeight;
                    Console.WriteLine($"{rectangleArea:F2}");
                    return;
                case "square":
                    double squareSide = double.Parse(Console.ReadLine());                   
                    double squareArea = squareSide * squareSide;
                    Console.WriteLine($"{squareArea:F2}");
                    return;
                case "circle":
                    double circleRadius = double.Parse(Console.ReadLine());
                    double circleArea = Math.PI * circleRadius * circleRadius;
                    Console.WriteLine($"{circleArea:F2}");
                    return;
                default:
                    return;
            }
        }
    }
}
