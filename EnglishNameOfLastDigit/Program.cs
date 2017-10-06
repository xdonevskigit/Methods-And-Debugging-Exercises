using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            WriteNameOfTheLastDigit(number);
        }

        static void WriteNameOfTheLastDigit(long number)
        {
            string name = "";
            switch (Math.Abs(number % 10L))
            {
                case 1: name = "one";
                    break;
                case 2:
                    name = "two";
                    break;
                case 3:
                    name = "three";
                    break;
                case 4:
                    name = "four";
                    break;
                case 5:
                    name = "five";
                    break;
                case 6:
                    name = "six";
                    break;
                case 7:
                    name = "seven";
                    break;
                case 8:
                    name = "eight";
                    break;
                case 9:
                    name = "nine";
                    break;
                case 0:
                    name = "zero";
                    break;
                default:
                    break;
            }

            Console.WriteLine(name);
        }
    }
}
