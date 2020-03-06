using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class MinMaxAvg
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[5];

            Console.WriteLine("Please enter 5 non-decimal numbers: " );

            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numArray);
            double avg = numArray.Average();

            Console.WriteLine("The lowest number in the array is {0}, the highest number in the array is {1}, " +
                "and the average of all numbers is: {2}", numArray[0], numArray[4], avg);


        }
    }
}
