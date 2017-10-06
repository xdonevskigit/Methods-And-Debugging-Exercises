using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cupeSide = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            CalculateSomeParameterOfCube(cupeSide, parameter);

        }

        static void CalculateSomeParameterOfCube(double cubeSide, string parameter)
        {
            double volume = cubeSide * cubeSide * cubeSide;
            double faceDiagonals = Math.Sqrt(2 * (cubeSide * cubeSide));
            double spaceDiagonals = Math.Sqrt(3 * (cubeSide * cubeSide));
            double surfaceArea = 6 * (cubeSide * cubeSide);

            switch (parameter)
            {
                case "face":
                     Console.WriteLine($"{faceDiagonals:F2}");
                    return;
                case "space":
                    Console.WriteLine($"{spaceDiagonals:F2}");
                    return;
                case "volume":
                    Console.WriteLine($"{volume:F2}");
                    return;
                case "area":
                    Console.WriteLine($"{surfaceArea:F2}");
                    return;

                default:
                    return;
            }
        }
    }
}
