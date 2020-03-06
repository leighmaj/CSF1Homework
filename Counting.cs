using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Counting
    {
        static void Main(string[] args)
        {
            //COUNTING Class: Counting.cs1.Display numbers from 1 to 25 on the screen with a loop.2.Display numbers from 25 to 1 on the screen 
            //        with a loop.3.Display numbers from 0 to 50 by 2’s with a loop.  4.Display numbers from 1 to 10 by 0.5 with a loop.
            //        Example Reference: All Looping classes in _5Friday.

            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine();
                Console.WriteLine(i);
            }

            for (int i = 25; i > 0; i--)
            {
                Console.WriteLine();
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 50; i+=2)
            {
                Console.WriteLine();
                Console.WriteLine(i);
            }

            for (double i = 1; i < 10; i+=0.5)
            {
                Console.WriteLine();
                Console.WriteLine(i);
            }
        }
    }
}
