using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberForCheck = long.Parse(Console.ReadLine());
            Console.WriteLine(PrimeChecker(numberForCheck));
        }

        static bool PrimeChecker(long number)
        {
            if (number == 0)
            {
                return false;
            }
            if (number == 1)
            {
                return false;
            }
            if (number == 2)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return false;
            }
 
            for (int i = 3; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
