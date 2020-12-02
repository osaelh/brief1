using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the action to be performed");  
            Console.WriteLine("Press a for Addition");  
            Console.WriteLine("Press s for Subtraction");  
            Console.WriteLine("Press m for Multiplication");  
            Console.WriteLine("Press d for Division \n");
            string action = Console.ReadLine();  
            Console.WriteLine("Enter 1st input");  
            int input_1 = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter 2nd input");  
            int input_2 = Convert.ToInt32(Console.ReadLine());  
            int result = 0;  
            switch (action) {  
                case "a": {  
                    result = Addition(input_1, input_2);  
                    break;  
                }  
                case "s": {  
                    result = Subtraction(input_1, input_2);  
                    break;  
                }  
                case "m": {  
                    result = Multiplication(input_1, input_2);  
                    break;  
                }  
                case "d": {  
                    result = Division(input_1, input_2);  
                    break;  
                }
 
                default:  
                    Console.WriteLine("Wrong action!! try again");  
                    break;  
            }  
            Console.WriteLine("The result is {0}", result);
            Console.WriteLine("press q to quit");
            if (Console.ReadLine() == "q")
            {
                Environment.Exit(0);
            }
            else
            {
                System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
            }
        }  
        //Addition  
        public static int Addition(int input_1, int input_2) {  
            int result = input_1 + input_2;  
            return result;  
        }  
        //Substraction  
        public static int Subtraction(int input_1, int input_2) {  
            int result = input_1 + input_2;  
            return result;  
        }  
        //Multiplication  
        public static int Multiplication(int input_1, int input_2) {  
            int result = input_1 + input_2;  
            return result;  
        }  
        //Division  
        public static int Division(int input_1, int input_2) {  
            int result = input_1 + input_2;  
            return result;  
        }  


    }  
}
