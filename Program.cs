using System;

namespace CSharpBasics
{
    class Program
    {
        enum Month{
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            string monthName = "";

            bool loopContinue = true;
            while (loopContinue)
            {
                int index = 0;
                bool sym = false;
                Console.WriteLine("Enter the month index number:");
                try
                {
                    index = Int32.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("You have to use only numbers.");
                    sym = true;
                }

                if (sym != true)
                {
                    switch (index)
                    {
                        case 1:
                            monthName = Month.January.ToString();
                            loopContinue = false;
                            break;
                        case 2:
                            monthName = Month.February.ToString();
                            loopContinue = false;
                            break;
                        case 3:
                            monthName = Month.March.ToString();
                            loopContinue = false;
                            break;
                        case 4:
                            monthName = Month.April.ToString();
                            loopContinue = false;
                            break;
                        case 5:
                            monthName = Month.May.ToString();
                            loopContinue = false;
                            break;
                        case 6:
                            monthName = Month.June.ToString();
                            loopContinue = false;
                            break;
                        case 7:
                            monthName = Month.July.ToString();
                            loopContinue = false;
                            break;
                        case 8:
                            monthName = Month.August.ToString();
                            loopContinue = false;
                            break;
                        case 9:
                            monthName = Month.September.ToString();
                            loopContinue = false;
                            break;
                        case 10:
                            monthName = Month.October.ToString();
                            loopContinue = false;
                            break;
                        case 11:
                            monthName = Month.November.ToString();
                            loopContinue = false;
                            break;
                        case 12:
                            monthName = Month.December.ToString();
                            loopContinue = false;
                            break;
                        default:
                            Console.WriteLine("You have entered the incorrect number. Use numbers from 1 to 12.");
                            loopContinue = true;
                            break;
                    }
                }
                else
                {
                    loopContinue = true;
                }
            }
            Console.WriteLine($"You month is: {monthName}");
        }
    }
}
//Запросить у пользователя порядковый номер текущего месяца и вывести его название.
