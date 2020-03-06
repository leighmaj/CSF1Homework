using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Variables
    {
        static void Main(string[] args)
        {

            //1

            int num1 = 4;
            char char1 = 'A';
            string word = "swords";
            double num2 = 12.25;
            float num3 = 12568;
            byte num4 = 5;

            Console.WriteLine("The value of number is: {0}", num1);
            Console.WriteLine("The value of character is: {0}", char1);
            Console.WriteLine("The value of word is: {0}", word);
            Console.WriteLine("The value of num2 is: {0}", num2);
            Console.WriteLine("The value of num3 is: {0}", num3);
            Console.WriteLine("The value of num4 is: {0}", num4);

            //2
            int[] numbers = { 2, 4, 6, 8, 10};
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            char[] characters = { 'A', 'B', 'C', 'D', 'E' };
            foreach (char character in characters)
            {
                Console.WriteLine(character);
            }

            string[] strings = { "red", "blue", "green", "yellow", "black" };
            foreach (string string1 in strings)
            {
                Console.WriteLine(string1);
            }

            double[] doubles = { 12.5, 15.89, 25.84, 1, 600.52 };
            foreach (double double1 in doubles)
            {
                Console.WriteLine(double1);
            }

            float[] floats = { 12.5f, 15.89f, 25.84f, 1f, 600.52f };
            foreach (float float1 in floats)
            {
                Console.WriteLine(float1);
            }

            byte[] bytes = { 1, 3, 5, 7, 9 };
            foreach (byte byte1 in bytes)
            {
                Console.WriteLine(byte1);
            }

            //3

            int whileNum = 0;
            while (whileNum <= 100)
            {
                Console.WriteLine(whileNum);
                whileNum += 2;
            }

            int doWhileNum = 0;
            do
            {
                Console.WriteLine(doWhileNum);
                doWhileNum += 2;
            } while (doWhileNum <= 100);

            for (int i = 0; i <= 100; i+=2)
            {
                Console.WriteLine(i);
            }
         

        }
    }
}
