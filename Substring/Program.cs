using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentText = Console.ReadLine();
            int numberOfCharsForChecke = int.Parse(Console.ReadLine());

            char letter = 'p';
            bool hasMatch = false;

            for (int i = 0; i < currentText.Length - 1; i++)
            {
                string matchedString = "";
                if (currentText[i] == letter)
                {
                    hasMatch = true;

                    int endIndex = i + numberOfCharsForChecke + 1;

                    if (endIndex >= currentText.Length - 1)
                    {
                        numberOfCharsForChecke = currentText.Length - 1 - i;
                    }
                    
                    matchedString = currentText.Substring(i, numberOfCharsForChecke + 1);
                    Console.WriteLine(matchedString);
                    i += numberOfCharsForChecke;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
