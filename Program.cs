using System;
using System.Collections.Generic;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter receipt #");
            string receipt = Console.ReadLine();
            List<Product> productList = new List<Product>();
            bool stop = false;
            while (!stop)
            {
                float productPrice = 0;
                float productAmount = 0;
                Console.WriteLine("Enter product name. To Stop type Enter.");
                string productName = Console.ReadLine();
                if(productName == "") { stop = true; break; }
                try
                {
                    Console.WriteLine("Enter product price:");
                    productPrice = float.Parse(Console.ReadLine());
                }
                catch
                {
                    stop = true; break;
                }
                try
                {
                    Console.WriteLine("Enter product amount:");
                    productAmount = float.Parse(Console.ReadLine());
                }
                catch
                {
                    stop = true; break;
                }
                productList.Add(new Product(productName, productPrice, productAmount));
            }

            if (productList.Count == 0)
            {
                Console.WriteLine("No products have been entered or something has entered incorrect. Check has been cancelled.");
            }
            else
            {
                int counter = 0;
                float total = 0;

                Console.WriteLine($"********************Receipt #{receipt}********************");
                foreach (var item in productList)
                {
                    counter++;
                    total += item.printProduct().Item2;
                    Console.WriteLine($"{counter}. {item.printProduct().Item1}");
                }

                Console.WriteLine("_________________________");
                Console.WriteLine($"Total: {total}");
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()}");
            }
        }
    }
}
//Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, только за место динамических,
//по вашему мнению, данных (это может быть дата, название магазина, сумма покупок) подставляйте переменные, которые были заранее заготовлены до вывода на консоль