using System;
using System.Linq;

namespace Functional_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToArray();
            string result = string.Join(", ", numbers);
            Console.WriteLine(result);

        }
    }
}
