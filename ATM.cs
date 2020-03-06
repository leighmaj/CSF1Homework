using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class ATM
    {
        static void Main(string[] args)
        {
            string hardcodeAccountNum = "245901858";
            string hardcodePIN = "2020";
            string accountNum = "";
            string PIN = "";
            bool enter = false;
            decimal acctBalance = 0;


            for (int i = 0; i < 3; i++)
            {
                Console.Write("Please enter your account number: ");
                accountNum = Console.ReadLine();

                if (accountNum == hardcodeAccountNum)
                {
                    Console.WriteLine("Yay, you have access!");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("Please enter the PIN: ");
                        PIN = Console.ReadLine();

                        if (PIN == hardcodePIN)
                        {
                            Console.WriteLine("Welcome Valued Customer!");
                            enter = true;
                            break;
                        }
                        else if (PIN != hardcodePIN && j == 2)
                        {
                            Console.WriteLine("Wrong PIN, you have been locked out.");
                        }
                        else
                        {
                            Console.WriteLine("Wrong PIN, please try again");
                        }

                    }

                    break;
                }
                else if (accountNum != hardcodeAccountNum && i == 2)
                {
                    Console.WriteLine("Sorry, you do not have access and have reached maximum attemps.");
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have access!");
                }
            }

            while(enter)
            {
                Console.WriteLine("\n==== MENU OPTIONS ====");
                Console.WriteLine();
                Console.WriteLine("1) Deposit \n2) Withdrawal \n3) Balance \n4) Exit\n");

                string option = Console.ReadLine().ToLower();

                switch (option)
                {
                    case "1":
                    case "deposit":
                        Console.Write("What is the amount you would like to deposit? ");
                        decimal deposit = decimal.Parse(Console.ReadLine());
                        Console.WriteLine();
                        acctBalance = acctBalance + deposit;
                        Console.WriteLine($"{deposit:c} has been deposited into account number {hardcodeAccountNum}");
                        Console.WriteLine($"\nYour new balance is {acctBalance:c}");
                        break;
                    case "2":
                    case "withdrawal":
                        Console.Write("What is the amount you would like to withdraw? ");
                        decimal withdrawal = decimal.Parse(Console.ReadLine());
                        Console.WriteLine();
                        acctBalance = acctBalance - withdrawal;
                        Console.WriteLine($"{withdrawal:c} has been withdrawn from account number {hardcodeAccountNum}");
                        Console.WriteLine($"\nYour new balance is {acctBalance:c}");
                        break;
                    case "3":
                    case "balance":
                        Console.WriteLine();
                        Console.WriteLine($"Your current balance is {acctBalance:c}");
                        break;
                    case "4":
                    case "exit":
                        Console.WriteLine();
                        Console.WriteLine("Thank you for your business!\n");
                        enter = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry, try again.");
                        break;

                }
            }
        }
    }
}
