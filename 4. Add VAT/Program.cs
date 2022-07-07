using System;
using System.Linq;

namespace _4._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal> addVat = x => x * 1.20m;
            string input = Console.ReadLine();
            string[] tokens = input.Split(", ");
            decimal[] nums = tokens.Select(decimal.Parse).Select(addVat).ToArray();
            foreach (var n in nums)
            {
                Console.WriteLine($"{n:f2}");

            }
        }
    }
}
