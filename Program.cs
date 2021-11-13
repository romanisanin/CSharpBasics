using System;
using System.IO;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllLines("startup.txt",new string[] { DateTime.Now.ToLocalTime().ToString() });

            string[] fileText = File.ReadAllLines("startup.txt");

            foreach (var item in fileText)
            {
                Console.WriteLine(item);
            }
        }
    }
}
//Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
