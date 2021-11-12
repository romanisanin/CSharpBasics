using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Int32.Parse(Console.ReadLine());
            int f = GetFibonachi(number);
            Console.WriteLine(f);
        }

        static int GetFibonachi(int number)
        {
            if (number == 0 || number == 1) { return number; }
            return GetFibonachi(number - 1) + GetFibonachi(number - 2);
        }
         

    }
}
