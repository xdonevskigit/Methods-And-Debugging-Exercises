using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());        
            Console.WriteLine(TakeFibonacciValue(number));
        }

        static int TakeFibonacciValue(int number)
        {
            int firstNumber = 1;
            int secondNumber = 1;
            
            for (int i = 0; i < number; i++)
            {
                int temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp + firstNumber;         
            }

            return firstNumber;
        }
    }
}
