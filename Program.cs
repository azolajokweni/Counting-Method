using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethod(); // The method that handles input and counting
        }

        static void MyMethod()
        {
            Console.WriteLine("Enter a list of items separated by spaces:");
            string input = Console.ReadLine();

            List<string> items = new List<string>(input.Split(' '));
            // Split the input into a list of strings

            CountItems(items);
        }

        static void CountItems<T>(List<T> items)
        {
            Dictionary<T, int> itemCounts = new Dictionary<T, int>();

            foreach (T item in items)
            {
                if (itemCounts.ContainsKey(item))
                {
                    itemCounts[item]++;
                }
                else
                {
                    itemCounts[item] = 1;
                }
            }

            Console.WriteLine("\nItem Counts:");
            foreach (KeyValuePair<T, int> pair in itemCounts)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
