using System;
using System.Collections.Generic;

namespace _04.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> shopProducts = new SortedDictionary<string, string>();
            Dictionary<string, double> productsPrice = new Dictionary<string, double>();
            string command;
            while((command = Console.ReadLine())!="Revision")
            {
                string[] segments = command.Split(", ");
                string shopName = segments[0];
                string product = segments[1];
                double price = double.Parse(segments[2]);
                if (!shopProducts.ContainsKey(product))
                {
                    shopProducts.Add(product, shopName);
                    productsPrice.Add(product, price);
                }
                else
                {
                    shopProducts[product] = shopName;
                    productsPrice.Add(product, price);
                }
            }
            foreach(var x in shopProducts)
            {
                foreach(var z in shopProducts)
                {
                    if(x.Value==z.Value+1)
                    {
                        Console.WriteLine($"{x.Value}->");
                    }
                }
                 
                 foreach (var y in productsPrice)
                 {
                    if (x.Key == y.Key)
                    {
                        Console.WriteLine($"Product: {x.Key}, Price: {y.Value}");
                    }
                 } 
            }
            Console.Read();
        }
    }
}

