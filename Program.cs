using System;
using System.Collections.Generic;
using System.Linq;

namespace linq6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello {nameof(linq6)}!");
            Console.WriteLine($"Calculates a sequence of pairs for every combination in the input.");

            IEnumerable<char> input = new [] { 'a', 'b', 'c', 'd', 'e' };
            IEnumerable<(char, char)> output = input
                .SelectMany(c1 => input.Except(new [] { c1 }).Select(c2 => (c1, c2)))
                .ToList();

            Console.WriteLine($"input={input.Count()}, output={output.Count()}");
            foreach((char x, char y) pair in output) {
                Console.WriteLine($"{pair.x}, {pair.y}");
            }
        }
    }
}
