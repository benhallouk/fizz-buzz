using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static string PrintableRange(int start, int count)
        {
            return string.Join(" ", Range(start, count).ToArray());
        }

        public static IEnumerable<string> Range(int start, int count)
        {
            return Enumerable.Range(start, count)
                             .Select(number => wordBy(number));
        }

        private static string wordBy(int number)
        {
            var numberAsString = number.ToString();
            if (numberAsString.Contains("3")) return "lucky";
            if (number % 15 == 0) return "fizzbuzz";
            if (number % 3 == 0) return "fizz";
            if (number % 5 == 0) return "buzz";
            return numberAsString;
        }
    }
}