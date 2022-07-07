using System;
using System.Linq;

namespace _2._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = n => int.Parse(n);
            string numbers = Console.ReadLine();
            int[] numbersSplited = numbers.Split(", ").Select(parser).ToArray();
            Console.WriteLine(numbersSplited.Length);
            Console.WriteLine(numbersSplited.Sum());
        }
    }
}
