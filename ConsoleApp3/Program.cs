using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "january", "february", "mars", "april", "mai", "june", "july", "auguste", "september", "october", "november", "december" };
            List<string> months = new List<string>(input);
            Console.WriteLine("\nCapacity: {0}", months.Capacity);
            foreach(string month in months)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine(months[2]);
            months[6] = "august";
            Console.WriteLine(months[6]);
            months.Insert(0, "months");
            Console.WriteLine(months[0]);
            months.RemoveAt(2);
            foreach (string month in months)
            {
                Console.WriteLine(month);
            }
            //string isExist =months.Find(x => x.Contains("november"));
            // Console.WriteLine(isExist);
            Console.WriteLine("\nFind: Part where name contains \"january\": {0}",
            months.Exists(x => x == "january"));
            months.Sort();
            foreach (var month in months)
            {
                Console.WriteLine(month);
            }

            List<string> copy = months.ToList();
            foreach (var month in copy)
            {
                Console.WriteLine(month);
            }





        }
    }
}
