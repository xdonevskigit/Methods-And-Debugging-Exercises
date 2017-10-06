using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace InstructionSet
{
    class Program
    {
        static void Main()
        {   BigInteger result = 0;
            byte count = 0;
            start:
            count++;
            if (result != 0 || count != 1)
            {
               Console.WriteLine(result);
            }
            
            string opCode = Console.ReadLine();

            while (opCode != "END")
            {
                string[] codeArgs = opCode.Split(' ');

                
                switch (codeArgs[0])
                {
                    case "INC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            operandOne++;
                            result = operandOne;
                            goto start;                          
                        }
                    case "DEC":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            operandOne--;
                            result = operandOne;
                            goto start;
                        }
                    case "ADD":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne + operandTwo;
                            goto start;
                        }
                    case "MLA":
                        {
                            long operandOne = long.Parse(codeArgs[1]);
                            long operandTwo = long.Parse(codeArgs[2]);
                            result = operandOne * operandTwo;
                            goto start;
                        }
                }

                
            }
        }
    }
}