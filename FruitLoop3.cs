using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class FruitLoop3
    {
        static void Main(string[] args)
        {
            //Repeat the previous exercise, but for each of the fruit names that you display, on the next line display a number 
            //    of periods that is equal to the number of the index of the array.Output Example: “Apple”. //one period

            string[] fruits = { "grapes", "blueberries", "oranges", "apples", "plums", "bananas" };

            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
        }
    }
}
