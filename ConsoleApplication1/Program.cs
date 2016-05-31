using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string patternlogin="^[a-t]+$";
            string patternpassword = "^[0-9]+$";
            while (true)
            {
                Console.Write("Enter login:");
                string login = Console.ReadLine();
                Console.Write("Enter password:");
                string password = Console.ReadLine();
                if ((Regex.IsMatch(login,patternlogin)) && (Regex.IsMatch(password,patternpassword)))
                {
                    Console.WriteLine("Registration successful!");
                    break;
                }
                else Console.WriteLine("Wrong input!");
            }
            Console.ReadLine();
        }
    }
}
