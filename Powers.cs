using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Powers
    {
        static void Main(string[] args)
        {
            Console.Clear();
            long powerOf2 = 2;

            for (int i = 1; i < 50; i++)
            {
                powerOf2 *= 2;
                Console.WriteLine(powerOf2);
            }
        }
    }
}
