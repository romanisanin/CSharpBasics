using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string1:");
            string string1 = Console.ReadLine();
            Console.WriteLine("Enter string2:");
            string string2 = Console.ReadLine();
            string string3 = GetLongestMatch(string1, string2);
            Console.WriteLine(string3);
        }

        private static string GetLongestMatch(string string1, string string2)
        {
            string string3 = "";
            string max_str = "";
            int t = 0;
            for (int i = 0; i < string1.Length; i++)
            {
                for (int j = t; j < string2.Length; j++)
                {
                    if (string1[i] == string2[j])
                    {
                        
                        string3 += string1[i];
                        t = j+1;
                        break;
                    }
                    else
                    {
                        if (max_str.Length < string3.Length)
                        {
                            max_str = string3;
                        }
                        t = 0;
                        string3 = "";
                    }
                }
            }
            return max_str;
        }
    }
}
//Найти максимальную совпадающую подстроку из двух строк