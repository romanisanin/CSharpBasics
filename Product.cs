using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Product
    {
        string productName;
        float productPrice;
        float productAmount;

        public Product(string _productName, float _productPrice, float _productAmount)
        {
            productName = _productName;
            productPrice = _productPrice;
            productAmount = _productAmount;
        }

        public Tuple<string,float> printProduct()
        {
            float price = productPrice * productAmount;
            if (productName.Length > 20)
            {
                productName = productName.Substring(0, 19);
            }
            string productDetail = $"{productName}\n{productPrice}X{productAmount}\nPrice:............{price}";

            return Tuple.Create(productDetail, price);
        }
    }
}
