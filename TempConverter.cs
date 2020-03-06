using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            bool degrees = true;
            do
            {
                Console.WriteLine("Please choose from the following options: \n1) Convert Celcius to Fahrenheit \n2) Convert Fahrenheit to Celcius");
                int option = int.Parse(Console.ReadLine());

                if(option == 1)
                {
                    Console.Write("Please enter the Celcius temperature that you want to convert to Fahrenheit: ");
                    double inputCelToFahr = double.Parse(Console.ReadLine());

                    double degreeCeltoFahr = inputCelToFahr * 9 / 5 + 32;
                    Console.WriteLine($"{inputCelToFahr} degrees Celcius is {degreeCeltoFahr} degrees Fahrenheit.");
                    Console.WriteLine("Do you want to convert again? Y/N");
                    if (Console.ReadLine().ToUpper() == "N")
                    {
                        Console.WriteLine("Thanks for stopping by!");
                        degrees = false;
                    }
                    else
                    {
                        degrees = true;
                    }
                }
                else if (option == 2)
                {
                    Console.Write("Please enter the Fahrenheit temperature that you want to convert to Celcius: ");
                    double inputFahrToCel = double.Parse(Console.ReadLine());

                    double degreeFahrToCel = ((inputFahrToCel - 32) / 9 * 5);
                    Console.WriteLine($"{inputFahrToCel} degrees Fahrenheit is {degreeFahrToCel} degrees Celcius.");
                    Console.WriteLine("Do you want to convert again? Y/N");
                    if (Console.ReadLine().ToUpper() == "N")
                    {
                        Console.WriteLine("Thanks for stopping by!");
                        degrees = false;
                    }
                    else
                    {
                        degrees = true;
                    }
                }
                else
                {
                    Console.WriteLine("Option invalid, press enter to continue or type E to exit.");
                    if(Console.ReadLine().ToUpper() == "E")
                    {
                        Console.WriteLine("Thanks for stopping by!");
                        degrees = false;
                    }
                }

            } while (degrees);

        }
    }
}
