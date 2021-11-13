using System;
using System.IO;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase:");
            string phrase = Console.ReadLine();

            Console.WriteLine("Enter filename:");
            string filename = Console.ReadLine();
            File.WriteAllText(filename, phrase);
            
            string fileText = File.ReadAllText(filename);
            Console.WriteLine(fileText);
        }
    }
}
//Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
