using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            //Each number in the sequence is the sum of the two numbers that precede it. 
            //So, the sequence goes: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, and so on. The mathematical 
            //equation describing it is Xn+2= Xn+1 + Xn

            Console.Write("Please enter a max number: ");
            int maxNum = int.Parse(Console.ReadLine());
            int[] fibonacciArray = new int[100];
            int i = 2;
            int sum = 0;

            fibonacciArray[0] = 0;
            fibonacciArray[1] = 1;

            do
            {
                sum = fibonacciArray[i - 1] + fibonacciArray[i - 2];
                fibonacciArray[i] = sum;
                i++;
            } while (fibonacciArray[i - 1] <= maxNum);

            for (int j = 0; j < fibonacciArray.Length; j++)
            {
                if (fibonacciArray[j] <= maxNum)
                {
                    Console.Write($"{fibonacciArray[j]}, ");
                }
                else
                {
                    break;
                }
            }


        }
    }
}
