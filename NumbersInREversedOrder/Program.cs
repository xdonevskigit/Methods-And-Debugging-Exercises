using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInREversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string someChars = Console.ReadLine();
            ReversingString(someChars);
        }

        static void ReversingString(string someChars)
        {
            string revString = "";

            for (int i = someChars.Length - 1; i >= 0; i--)
            {
                revString = revString + someChars[i];
            }

            Console.WriteLine(revString);
        }
    }
}
