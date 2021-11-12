using System;

namespace CSharpBasics
{
    enum Season
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }
    class Program
    {

        static void Main(string[] args)
        {
            int monthNumber = GetNumber();
            string monthString = GetString(monthNumber);
            PrintMonth(monthString);
        }

        private static void PrintMonth(string monthString)
        {
            Console.WriteLine($"Month entered: {monthString}");
        }

        private static string GetString(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1: return Season.Winter.ToString();
                case 2: return Season.Winter.ToString();
                case 3: return Season.Spring.ToString();
                case 4: return Season.Spring.ToString();
                case 5: return Season.Spring.ToString();
                case 6: return Season.Summer.ToString();
                case 7: return Season.Summer.ToString();
                case 8: return Season.Summer.ToString();
                case 9: return Season.Autumn.ToString();
                case 10: return Season.Autumn.ToString();
                case 11: return Season.Autumn.ToString();
                case 12: return Season.Winter.ToString();
                default: return "Wrong data";
            }
        }

        static int GetNumber()
        {
            int monthNumber;
            Console.WriteLine("Enter month number:");
            while (true)
            {
                monthNumber = Int32.Parse(Console.ReadLine());

                if (monthNumber >= 1 && monthNumber <= 12)
                {
                    break;
                }
                Console.WriteLine("Error: Enter number from 1 to 12:");
            }
            return monthNumber;    
        }
    }
}
//Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
//На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn.
//Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень).
//Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.
//Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
