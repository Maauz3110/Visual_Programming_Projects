using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _233599_ConsoleApp_Activity_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Data source  
            int[] numbers = new int[] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation  
            // LINQ query to find even numbers  
            var numQuery = from num in numbers
                           where (num % 2) == 0
                           select num;

            // 3. Query execution  
            Console.WriteLine("Even numbers in the array:");
            foreach (int num in numQuery)
            {
                Console.Write("{0} ", num);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();  // To keep the console open  
        }
    }
}
