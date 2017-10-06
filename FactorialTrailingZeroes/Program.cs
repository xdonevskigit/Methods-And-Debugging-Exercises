using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(WriteTheTrailingZeroes(number));
        }

        static int WriteTheTrailingZeroes(int number)
        {
            BigInteger factorialNumber = number;
            int zeroes = 0;
            for (int i = number; i > 1; i--)
            {
                factorialNumber = factorialNumber * (i - 1);
            }
            string strFactNumber = factorialNumber.ToString();

            for (int i = 0; i < strFactNumber.Length - 1; i++)
            {
                if (strFactNumber[strFactNumber.Length - 1 - i].Equals('0'))
                {
                    strFactNumber.Remove(strFactNumber.LastIndexOf('0'));
                    zeroes++;
                }
                else
                {
                    break;
                }
            }
            return zeroes;
        }
    }
}
    
