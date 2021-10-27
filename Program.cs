using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine($"Hello, {username}, today is {DateTime.Now.ToShortDateString()}");
        }
    }
}
