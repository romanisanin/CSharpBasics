using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            string hw = "Hello";
            string wh = "";
            for (int i = hw.Length-1; i >= 0; i--)
            {
                wh += hw[i];
            }

            Console.WriteLine(wh);
        }
    }
}
//Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello).
