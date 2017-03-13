using FizzBuzz;
using System;

namespace FizzBuzzProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzzGenerator.PrintableRange(1,100));

            Console.WriteLine("fizz: {0}", FizzBuzzGenerator.FizzWordsCount);
            Console.WriteLine("buzz: {0}", FizzBuzzGenerator.BuzzWordsCount);
            Console.WriteLine("fizzbuzz: {0}", FizzBuzzGenerator.FizzBuzzWordsCount);
            Console.WriteLine("lucky: {0}", FizzBuzzGenerator.LuckyWordsCount);
            Console.WriteLine("integer: {0}", FizzBuzzGenerator.NumberCount);
        }
    }
}
