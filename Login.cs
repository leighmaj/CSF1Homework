using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1Homework
{
    class Login
    {
        static void Main(string[] args)
        {
            string hardcodeUsername = "leighann";
            string hardcodePassword = "majkowski";
            string username = "";
            string password = "";

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Please enter your username: ");
                username = Console.ReadLine().ToLower();

                if (username == hardcodeUsername)
                {
                    Console.WriteLine("Yay, you have access!");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("Please enter the password: ");
                        password = Console.ReadLine().ToLower();

                        if(password == hardcodePassword)
                        {
                            Console.WriteLine("Welcome Leigh Ann!");
                            break;
                        }
                        else if(password != hardcodePassword && j==2)
                        {
                            Console.WriteLine("Wrong password, you have been locked out.");
                        }
                        else
                        {
                            Console.WriteLine("Wrong password, please try again");
                        }

                    }

                    break;
                }
                else if(username != hardcodeUsername && i == 2)
                {
                    Console.WriteLine("Sorry, you do not have access and have reached maximum attemps.");
                }
                else
                {
                    Console.WriteLine("Sorry, you do not have access!");
                }
            }

        }
    }
}
