using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phonebook = new string[5, 2];

            for (int i = 0; i < phonebook.GetLength(0); i++)
            {
                for (int j = 0; j < phonebook.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine($"Enter the contact name #{i + 1}");
                    }
                    else
                    {
                        Console.WriteLine($"Enter the phone number for contact #{i + 1}");
                    }
                    phonebook[i, j] = Console.ReadLine();                }
            }

            for (int i = 0; i < phonebook.GetLength(0); i++)
            {
                for (int j = 0; j < phonebook.GetLength(1); j++)
                {
                    Console.Write($"{phonebook[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
//Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий список телефонных контактов: первый элемент хранит имя контакта, второй — номер телефона/e-mail.
