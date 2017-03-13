using NUnit.Framework;
using System.Collections.Generic;
using System;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzTests
    {
        [Test]
        public void Should_Return_Fizz_For_Numbers_Multiplied_By_3()
        {
            string fizzWord = FizzBuzzGenerator.Range(3, 1).Single();
            Assert.AreEqual(fizzWord, "fizz");
        }

        [Test]
        public void Should_Return_Buzz_For_Numbers_Multiplied_By_3()
        {
            string fizzWord = FizzBuzzGenerator.Range(5, 1).Single();
            Assert.AreEqual(fizzWord, "buzz");
        }

        [Test]
        public void Should_Return_FizzBuzz_For_Numbers_Multiplied_By_15()
        {
            string fizzWord = FizzBuzzGenerator.Range(15, 1).Single();
            Assert.AreEqual(fizzWord, "fizzbuzz");
        }

        [Test]
        public void Should_Return_Right_Values_To_Print_For_The_Given_Range()
        {
            Assert.AreEqual(
                FizzBuzzGenerator.PrintableRange(1, 20), 
                "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz");
        }
    }
}
