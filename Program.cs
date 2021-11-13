using System;
using System.IO;
using System.Linq;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter random set of numbers from 0 to 255:");
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            
            byte[] array = numbers.Select(i => (byte)i).ToArray();

            File.WriteAllBytes("bytes.bin", array);
            byte[] fromFile = File.ReadAllBytes("bytes.bin");

            foreach (var item in fromFile)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
//Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.