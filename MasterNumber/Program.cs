using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (WriteIsSymetric(i) 
                    && WriteIsSumOfDigitsIsDivisibleBySeven(i)
                    && WriteIsNumberHaveOneEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool WriteIsSymetric(int number)
        {
            if (number == 0)
            {
                return false;
            }
            string integerNumber = number.ToString();

            for (int i = 0; i < integerNumber.Length - 1 ; i++)
            {
                if (integerNumber[i] != integerNumber[integerNumber.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static bool WriteIsSumOfDigitsIsDivisibleBySeven(int number)
        {
            int sumOfTheDigits = 0;
            while (number > 0)
            {
                sumOfTheDigits = sumOfTheDigits + number % 10;
                number = number / 10;
            }
            if (sumOfTheDigits % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static bool WriteIsNumberHaveOneEvenDigit(int number)
        {
            int momentDigit;
            while (number > 0)
            {
                momentDigit = number % 10;
                if (momentDigit % 2 == 0)
                {
                    return true;
                }
                number = number / 10;
            }
            return false;
        }
    }
}
