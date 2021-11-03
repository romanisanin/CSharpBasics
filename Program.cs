using System;

namespace CSharpBasics
{
    class Program
    {  
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Rome Number:");
            string romeNumber = Console.ReadLine();
            int[] arabNumber = new int[romeNumber.Length];
            for (int i = 0; i < romeNumber.Length; i++)
            {
                if (romeNumber[i] == 'I')
                {
                    arabNumber[i] = 1;
                }
                if (romeNumber[i] == 'V')
                {
                    arabNumber[i] = 5;
                }
                if (romeNumber[i] == 'X')
                {
                    arabNumber[i] = 10;
                }
                if (romeNumber[i] == 'L')
                {
                    arabNumber[i] = 50;
                }
                if (romeNumber[i] == 'C')
                {
                    arabNumber[i] = 100;
                }
                if (romeNumber[i] == 'D') 
                {
                    arabNumber[i] = 500;
                }
                if (romeNumber[i] == 'M')
                {
                    arabNumber[i] = 1000;
                }
            }
            
            int temp= arabNumber[0];

            if (arabNumber.Length == 1)
            {
                temp = arabNumber[0];
            }
            else
            {
                for (int i = 0; i < arabNumber.Length - 1; i++)
                {
                    if (arabNumber[i] >= arabNumber[i + 1])
                    {
                        temp += arabNumber[i + 1];
                    }
                    else
                    {
                        if (i != 0)
                        {
                            temp += arabNumber[i + 1] - arabNumber[i] - arabNumber[i];
                        }
                        else
                        {
                            temp = arabNumber[i + 1] - arabNumber[i];
                        }
                    }
                }
            }
            Console.WriteLine(temp);
         }
    }
}
//Усложненное задание: написать программу, принимающую на входе число записанное римскими цифрами и выводящее число записанное арабскими.