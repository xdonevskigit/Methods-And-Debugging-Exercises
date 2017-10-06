using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(WriteTheFactorialOfNumber(number));
        }

        static BigInteger WriteTheFactorialOfNumber(int number)
        {
            BigInteger factorialNumber = number;
            for (int i = number; i > 1; i--)
            {
                factorialNumber = factorialNumber * (i - 1); 
            }
            return factorialNumber;
        }
    }
}
