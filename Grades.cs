using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Grades
    {
        static void Main(string[] args)
        {
            Console.Write("How many scores would you like to enter?");
            int arraySize = int.Parse(Console.ReadLine());

            int[] grades = new int[arraySize];

            //int count = 0;
            int i = 0;
            int aCount = 0;
            int bCount = 0;
            int cCount = 0;
            int dCount = 0;
            int fCount = 0;

            do
            {
                Console.WriteLine("Please enter a score: ");
                grades[i] = int.Parse(Console.ReadLine());

                if(grades[i] < 0)
                {
                    Console.WriteLine("You have entered an invalid score, ending ability to enter grades!\n\n");
                    break;
                }

                Console.WriteLine(i);

                if (grades[i] >= 90)
                {
                    aCount += 1;
                }
                else if (grades[i] >= 80)
                {
                    bCount += 1;
                }
                else if (grades[i] >= 70)
                {
                    cCount += 1;
                }
                else if (grades[i] >= 60)
                {
                    dCount += 1;
                }
                else 
                {
                    fCount += 1;
                }
                i++;
                Console.WriteLine(i);

            } while (i<grades.Length);
            //grades[i-1] >= 0 || 

            Console.WriteLine("The total number of grades is: {0}.", i );

            Console.WriteLine("Number of A's: {0}", aCount);
            Console.WriteLine("Number of B's: {0}", bCount);
            Console.WriteLine("Number of C's: {0}", cCount);
            Console.WriteLine("Number of D's: {0}", dCount);
            Console.WriteLine("Number of F's: {0}", fCount);


        }
    }
}
