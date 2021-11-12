using System;
using System.Collections.Generic;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> catalog = new List<string>();
            AddUsers(catalog);
            
            int counter = 0;
            foreach (var FIO in catalog)
            {
                Console.WriteLine($"{++counter}. {FIO}");
            }
        }

        static void AddUsers(List<string> catalog)
        {
            for (int i = 0; i < 3; i++)
            {
                catalog.Add(AddUser(i+1));
            }
        }

        static string AddUser(int iterator)
        {
            Console.WriteLine($"Enter FirstName #{iterator}:");
            string firstName = Console.ReadLine();
            Console.WriteLine($"Enter LastName #{iterator}:");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Enter Patronymic #{iterator}:"); 
            string patronymic = Console.ReadLine();
            return GetFullName(firstName, lastName, patronymic);
        }

        private static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return lastName +" "+ firstName +" "+ patronymic;
        }
    }
}
//Написать метод GetFullName(string firstName, string lastName, string patronymic),
//принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
//Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
