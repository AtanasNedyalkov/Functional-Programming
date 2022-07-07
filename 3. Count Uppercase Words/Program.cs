using System;
using System.Linq;

namespace _3._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> cheker = x => x.Length > 0 && char.IsUpper(x[0]);
            string [] words = Console.ReadLine()
                .Split()
                .Where(w=>cheker(w))
                .ToArray();
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
