using System;

namespace CSharpBasics
{
    class Program
    {
        enum WinterMonth
        {
            December,
            January,
            February
        }
        static void Main(string[] args)
        {
            float averageTemp;
            Console.WriteLine("Enter a month:");
            string month = Console.ReadLine();

            if(month.ToLower()  == WinterMonth.December.ToString().ToLower() || 
                month.ToLower() == WinterMonth.January.ToString().ToLower() || 
                month.ToLower() == WinterMonth.February.ToString().ToLower())
            {
                Console.WriteLine("Enter average temperature:");
                try
                {
                    averageTemp = float.Parse(Console.ReadLine());
                    if (averageTemp > 0)
                    {
                        Console.WriteLine("Rainy Winter");
                    }
                    else
                    { 
                        Console.WriteLine("Snowy Winter");
                    }

                }
                catch
                {
                    Console.WriteLine("Wrong temperature has been entered. Closing the app");
                }
            }
            else
            {
                Console.WriteLine("Wrong month has been entered. Closing the app");
            }
            //(*) Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».
        }
    }
}
