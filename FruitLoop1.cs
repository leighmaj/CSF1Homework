using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop1
    {
        static void Main(string[] args)
        {
            string[] fruits = { "grapes", "blueberries", "oranges", "apples", "plums", "bananas" };
            int count = 0;

            while (count < fruits.Length)
            {
                Console.WriteLine(fruits[count]);
                count++;
            }
        }
    }
}
