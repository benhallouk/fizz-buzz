using NUnit.Framework;
using System.Collections.Generic;
using System;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzTests
    {
        [Test]
        public void Should_Return_Lucky_For_Numbers_That_Contains_3()
        {
            string fizzWord = FizzBuzzGenerator.Range(3, 1).Single();
            Assert.AreEqual(fizzWord, "lucky");
        }

        [Test]
        public void Should_Return_Fizz_For_Numbers_Multiplied_By_3()
        {
            string fizzWord = FizzBuzzGenerator.Range(6, 1).Single();
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
                "1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz");
        }

        [Test]
        public void Should_Count_Fizz_Words()
        {
            FizzBuzzGenerator.PrintableRange(6, 1);
            Assert.AreEqual(FizzBuzzGenerator.FizzWordsCount, 1);
        }


        [Test]
        public void Should_Count_Buzz_Words()
        {
            FizzBuzzGenerator.PrintableRange(5, 1);
            Assert.AreEqual(FizzBuzzGenerator.BuzzWordsCount, 1);
        }

        [Test]
        public void Should_Count_FizzBuzz_Words()
        {
            FizzBuzzGenerator.PrintableRange(15, 1);
            Assert.AreEqual(FizzBuzzGenerator.FizzBuzzWordsCount, 1);
        }

        [Test]
        public void Should_Count_Luck_Words()
        {
            FizzBuzzGenerator.PrintableRange(3, 1);
            Assert.AreEqual(FizzBuzzGenerator.LuckyWordsCount, 1);
        }

        [Test]
        public void Should_Count_Numbers()
        {
            FizzBuzzGenerator.PrintableRange(1, 1);
            Assert.AreEqual(FizzBuzzGenerator.NumberCount, 1);
        }

        [Test]
        public void Should_Count_All_Words_In_A_Given_Range()
        {
            FizzBuzzGenerator.PrintableRange(1, 20);
            Assert.AreEqual(FizzBuzzGenerator.FizzWordsCount, 4);
            Assert.AreEqual(FizzBuzzGenerator.BuzzWordsCount, 3);
            Assert.AreEqual(FizzBuzzGenerator.FizzBuzzWordsCount, 1);
            Assert.AreEqual(FizzBuzzGenerator.LuckyWordsCount, 2);
            Assert.AreEqual(FizzBuzzGenerator.NumberCount, 10);
        }
    }
}
