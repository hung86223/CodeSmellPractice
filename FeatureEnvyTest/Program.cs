using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatureEnvyTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app!
        }
    }

    internal class Item
    {
        public bool IsOutOfStock;
        public decimal Price;
        public decimal Tax;
        public bool IsOnSale;
        public decimal SaleDiscount;
    }

    internal class Basket
    {
        private readonly LongMethod _longMethod = new LongMethod();

        private static decimal GetTotalPrice(Item i)
        {
            if (i.IsOutOfStock)
                throw new Exception("Item ${i} is out of stock.");
            var price = i.Price + i.Tax;
            if (i.IsOnSale)
                price = price - i.SaleDiscount * price;
            return price;
        }
    }
}