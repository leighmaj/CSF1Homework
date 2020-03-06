using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Interest
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your beginning balance: ");
            double balance = double.Parse(Console.ReadLine());

            Console.Write("Please enter your interest rate: ");
            double interestRate = double.Parse(Console.ReadLine());

            Console.Write("Please enter the number of years: ");
            int years = int.Parse(Console.ReadLine());

            //decimal total = balance * interestRate;
            //decimal rateTotal = 0;

            for (int i = 0; i < years; i++)
            {
                balance = (balance * interestRate) + balance;
            }

            Console.WriteLine("The amount you will have in {0} year{1} is {2:c}", years, years==1 ? "" : "s", balance );

        }
    }
}
