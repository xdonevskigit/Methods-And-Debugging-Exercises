using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int biggerNumber = GetMax(firstNumber,GetMax(secondNumber,thirdNumber));
            Console.WriteLine(biggerNumber);
        }

        static int GetMax(int firstNumber, int secondNumber)
        {
            int biggerNumber = firstNumber;
            if (firstNumber < secondNumber)
            {
                biggerNumber = secondNumber;
            }
            return biggerNumber;
        }
    }
}
