using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        interface IAccount 
        {
            string PasswordChecker();
            void ShowInfo();
        }
      
    }
}
