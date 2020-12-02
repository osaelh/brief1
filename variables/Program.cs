using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName;
            int netPrice;
            Console.WriteLine("enter product name");
            productName = Console.ReadLine();
            Console.WriteLine(productName);
            Console.WriteLine("product price");
            netPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(netPrice);
            int TVA = netPrice * 19 / 100;
            Console.WriteLine("your taxes amount to " + TVA);
            int productPrice = netPrice + TVA;
            Console.WriteLine("the price of " + productName + " is " + productPrice);
        }
    }
}
