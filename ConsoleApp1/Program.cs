using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 1;
            for (int i = 0; i < 10; i++)
            {
                num1++;
                Console.WriteLine(num1);
                float num2 = num1 + num1 / 2;
                Console.WriteLine(num2);

            }

        }
    }
}
