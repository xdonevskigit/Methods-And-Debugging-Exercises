﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            PrintTheCLosestPointsToTheCenter(x1,y1,x2,y2);
        }

        static void PrintTheCLosestPointsToTheCenter(double x1, double y1, double x2, double y2)
        {
            if (Math.Pow(x1, 2) + Math.Pow(y1, 2) < Math.Pow(x2, 2) + Math.Pow(y2, 2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }

        }
    }
}
