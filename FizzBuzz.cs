using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a max number: ");
            int maxNum = int.Parse(Console.ReadLine());

            int[] numArray = new int[maxNum];

            for (int i = 0; i < maxNum; i++)
            {
                numArray[i] = i + 1;

                if (numArray[i] % 3 == 0 && numArray[i] % 5 == 0)
                {
                    Console.Write("FizzBuzz, ");
                }
                else if(numArray[i] % 3 == 0)
                {
                    Console.Write("Fizz, ");
                }
                else if (numArray[i] % 5 == 0)
                {
                    Console.Write("Buzz, ");
                }
                else
                {
                    Console.Write($"{numArray[i]}, ");
                }
               
            }

            
            
        }
    }
}
