using System;
using System.IO;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            string workDir = @"D:\tmp";
            string filename = "catalog.txt";

            Console.WriteLine("--------------------Recursion------------------------");

            Recursion(workDir);

            Console.WriteLine("--------------------Recursion------------------------");
            NoRecursion(workDir, filename);
        }

        private static void Recursion(string workDir)
        {
            try
            {
                foreach (string f in Directory.GetFiles(workDir))
                    Console.WriteLine(f);
                foreach (string d in Directory.GetDirectories(workDir))
                {
                    Console.WriteLine(d);
                    Recursion(d);
                }

            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void NoRecursion(string workDir, string filename)
        {
            string[] entries = Directory.GetFileSystemEntries(workDir, "*", SearchOption.AllDirectories);

            File.WriteAllLines(filename, entries);

            string[] output = File.ReadAllLines(filename);
            foreach (string entry in output)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
//(*) Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.