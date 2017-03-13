using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public static int FizzWordsCount { get; private set; }
        public static int BuzzWordsCount { get; private set; }
        public static int FizzBuzzWordsCount { get; private set; }
        public static int LuckyWordsCount { get; private set; }
        public static int NumberCount { get; private set; }

        public static string PrintableRange(int start, int count)
        {
            return string.Join(" ", Range(start, count).ToArray());            
        }

        public static IEnumerable<string> Range(int start, int end)
        {
            resetWordsCount();
            return Enumerable.Range(start, end)
                             .Select(number => count(wordBy(number)));
        }

        private static void resetWordsCount()
        {
            FizzWordsCount = 0;
            BuzzWordsCount = 0;
            FizzBuzzWordsCount = 0;
            LuckyWordsCount = 0;
            NumberCount = 0;
        }

        private static string count(string word)
        {
            switch (word)
            {
                case "fizz":
                    FizzWordsCount++;
                    break;
                case "buzz":
                    BuzzWordsCount++;
                    break;
                case "fizzbuzz":
                    FizzBuzzWordsCount++;
                    break;
                case "lucky":
                    LuckyWordsCount++;
                    break;
                default:
                    NumberCount++;
                    break;

            }
            return word;
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