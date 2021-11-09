using System;
using System.Collections.Generic;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = InitializeTable();
            var (ship, isVertical) = CreateShip();
            //CheckAvailability(table, ship, isVertical); not ready
            PrintShip(ship, table);

        }

        private static void PrintShip(int[,] ship, char[,] table)
        {

            for (int i = 0; i < ship.GetLength(0); i++)
            {
                int x = ship[i, 0];
                int y = ship[i, 1]-1;
                table[y, x] = 'X';
            }

            printTable(table);
        }

        private static char[,] InitializeTable()
        {
            var table = new char[10, 10];
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = 'O';
                }
            }

            return table;
        }

        private static (int[,], bool) CreateShip()
        {
            bool isVertical;
            int[,] ship;
            Console.WriteLine("Enter 2 coordinates for a ship:");
            while (true)
            {
                Console.Write($"Enter ships coordinates (e.g. A1-A3, A2-D2): ");
                string coordinate = Console.ReadLine().Replace("-", "").Replace(" ", "");
                int x1 = ConvertXtoInt(coordinate.Substring(0, 1));
                int y1 = Int32.Parse(coordinate.Substring(1, 1));
                int x2 = ConvertXtoInt(coordinate.Substring(2, 1));
                int y2 = Int32.Parse(coordinate.Substring(3, 1));

                if (x1 == 100 || x2 == 100)
                {
                    Console.WriteLine("You have entered wrong coordinates. Try one more time.");
                }
                else
                {
                    if (x1 == x2) //vertical ship
                    {
                        isVertical = true;
                        ship = new int[y2 - y1 + 1, 2];
                        int begin = y2 - y1 - 1;
                        for (int i = 0; i < ship.GetLength(0); i++)
                        {
                            for (int j = 0; j < ship.GetLength(1); j++)
                            {
                                if (j == 0)
                                {
                                    ship[i, j] = x1;
                                }
                                else
                                {
                                    ship[i, j] = begin + i;
                                }
                            }

                        }
                    }
                    else //horizontal ship
                    {
                        isVertical = false;
                        ship = new int[x2 - x1 + 1, 2];
                        int begin = y2 - y1;
                        for (int i = 0; i < ship.GetLength(0); i++)
                        {
                            for (int j = 0; j < ship.GetLength(1); j++)
                            {
                                if (j == 0)
                                {
                                    ship[i, j] = begin + i;
                                }
                                else
                                {
                                    ship[i, j] = y1;
                                }
                            }
                        }
                    }
                    break;
                }
            }
            return (ship, isVertical);
        }


        public static bool CheckAvailability(char[,] table, int[,] ship, bool isVertical)
        {
            List<List<int>> arrayList = new List<List<int>>();
            if (isVertical)
            {
                for (int i = 0; i < ship.GetLength(0); i++)
                {
                    for (int j = 0; j < ship.GetLength(1); j++)
                    {
                      //  arrayList.Add(ship[i, j]);
                    }
                }

            }

            for (int i = 0; i < ship.GetLength(0); i++)
            {
                int x = ship[i, 0];
                int y = ship[i, 1];
                if (table[x, y] == 'X')
                {
                    return false;
                }
                else
                {
                    if (ship.GetLength(0) == 1) //one cell ship
                    {
                        if (x != 0 && y != 0) //don't touch borders
                        {
                            if (table[x - 1, y - 1] == 'X' || table[x - 1, y] == 'X' || table[x - 1, y + 1] == 'X'
                              || table[x, y - 1] == 'X' || table[x, y + 1] == 'X' || table[x + 1, y - 1] == 'X'
                              || table[x + 1, y] == 'X' || table[x + 1, y + 1] == 'X')
                            {
                                return false;
                            }
                        }
                        else if (x == 0) //touch x 
                        {
                            if (table[x, y - 1] == 'X' || table[x, y + 1] == 'X' || table[x + 1, y - 1] == 'X' || table[x + 1, y] == 'X' || table[x + 1, y + 1] == 'X')
                            {
                                return false;
                            }
                        }
                        else if (y == 0) //touch y
                        {
                            if (table[x - 1, y] == 'X' || table[x - 1, y + 1] == 'X' || table[x, y + 1] == 'X' || table[x, y + 1] == 'X' || table[x + 1, y + 1] == 'X')
                            {
                                return false;
                            }
                        }


                    }
                    if (i == 0 || i == ship.GetLength(0) - 1) //multi cells ship
                    {

                        if (x != 0 && y != 0)
                        {
                            if (table[x - 1, y - 1] == 'X' || table[x - 1, y] == 'X' || table[x - 1, y + 1] == 'X'
                              || table[x, y - 1] == 'X' || table[x, y + 1] == 'X' || table[x + 1, y - 1] == 'X'
                              || table[x + 1, y] == 'X' || table[x + 1, y + 1] == 'X')
                            {
                                return false;
                            }
                        }
                        else if (x == 0)
                        {
                            if (table[x, y - 1] == 'X' || table[x, y + 1] == 'X' || table[x + 1, y - 1] == 'X'
                              || table[x, y + 1] == 'X' || table[x + 1, y + 1] == 'X')
                            {
                                return false;
                            }
                        }
                        else if (y == 0)
                        {
                            if (table[x - 1, y - 1] == 'X' || table[x - 1, y] == 'X' || table[x - 1, y + 1] == 'X'
                              || table[x, y - 1] == 'X' || table[x, y + 1] == 'X')
                            {
                                return false;
                            }
                        }
                    }
                    else
                    {
                        if (x != 0 && y != 0)
                        {
                            if (table[x, y - 1] == 'X' || table[x, y + 1] == 'X')
                            {
                                return false;
                            }
                        }
                        else if (x == 0)
                        {
                            if (table[x, y + 1] == 'X')
                            {
                                return false;
                            }
                        }
                        else if (y == 0)
                        {
                            if (table[x - 1, y - 1] == 'X' || table[x - 1, y] == 'X' || table[x - 1, y + 1] == 'X'
                              || table[x, y - 1] == 'X' || table[x, y + 1] == 'X')
                            {
                                return false;
                            }
                        }
                    }

                }
            }
            return true;
        }

        static int ConvertXtoInt(string x)
        {
            foreach (xcoordinate xcoordinate in Enum.GetValues(typeof(xcoordinate)))
            {
                if (x == xcoordinate.ToString())
                {
                    return (int)xcoordinate;
                }
            }
            return 100;
        }


        private static void printTable(char[,] table)
        {
            Console.WriteLine("   A B C D E F G E H J");
            int count = 0;
            for (int i = 0; i < table.GetLength(0); i++)
            {
                if (i != 9)
                {
                    Console.Write($"{++count}  ");
                }
                else
                {
                    Console.Write($"{++count} ");
                }
                for (int j = 0; j < table.GetLength(1); j++)
                {
                     Console.Write($"{table[i, j]} ");
                }
                Console.WriteLine();
            }
        }

    }
}
//* «Морской бой» — вывести на экран массив 10х10, состоящий из символов X и O, где Х — элементы кораблей, а О — свободные клетки.
