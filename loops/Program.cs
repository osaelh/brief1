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
            float a = 1;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a);
                a = a + a / 2;
                Console.WriteLine(a);
            }

            int msg;
            for (msg = 1; msg <= 15; msg++)
            {
                Console.WriteLine("On y arrive presque... " + msg);
            }

            int msg1;
            for (msg1 = 20; msg1 >= 0; msg1--)
            {
                Console.WriteLine("C'est presque bon... " + msg1);
            }

            int msg2;
            for (msg2 = 1; msg2 <= 100; msg2 += 15)
            {
                Console.WriteLine("On tient le bon bout..." + msg2);
            }

            int msg3;
            for (msg3 = 200; msg3 >= 0; msg3 -= 15)
            {
                Console.WriteLine("Enfin ! ! !" + msg3);
            }


        }
    }
}
