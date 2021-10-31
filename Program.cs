using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter min temperature in °C:");
            float min =  float.Parse(Console.ReadLine());
            Console.WriteLine("Enter max temperature in °C:");
            float max = float.Parse(Console.ReadLine());
            Console.WriteLine($"Average day's temperature is {(max+min)/2}°C");
        }
    }
}
//Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.