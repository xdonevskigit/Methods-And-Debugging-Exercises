using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeInGivenRange
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            bool isEmpty = !FindPrimesInRange(startNumber,endNumber).Any();
            if (isEmpty)
            {
                Console.WriteLine("(empty list)");
                return;
            }
    
            foreach (var item in string.Join(", ",FindPrimesInRange(startNumber,endNumber)))
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        static List<int> FindPrimesInRange(int startNumber, int endNumber)
        {
            List<int> primeNumbers = new List<int>();
            if (startNumber == 0 || startNumber == 1)
            {
                startNumber = 2;
            }
        
            for (int i = startNumber; i <= endNumber; i++)
            {
                bool isPrime = false;

                for (int j = 3; j <= Math.Sqrt(i); j++)
                {
                    if (i % 2 == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    else
                    {
                        isPrime = true;
                    }
                }
                if (i == 2 || i == 5 || i == 7 || i == 3)
                {
                    isPrime = true;
                }
                if (isPrime)
                {
                    primeNumbers.Add(i);
                }                
            }
            string.Join<int>(",", primeNumbers);
            return primeNumbers.ToList();
        }
    }
}
