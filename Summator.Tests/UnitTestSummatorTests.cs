using NUnit.Framework;
using System;

namespace Summator.Tests
{
    public class UnitTestsSummatorTests
    {
        [Test]
        public void Test_Sum_TwoPositiveNumbers()
        {
            double actual = Summator.Sum(new double[] { 5, 7 });
            double expected = 12d;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_OnePositiveNumber()
        {
            double actual = Summator.Sum(new double[] { 5 });
            double expected = 5d;
            Assert.That(actual == expected);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            double actual = Summator.Sum(new double[] { -5, -10 });
            double expected = -15d;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_SumTwoNumbers()
        {
            double expected = 120;

            Assert.That(expected == Summator.Sum(new double[] { 120 }));
        }

        [Test]
        public static void Sum_EmptyArray()
        {
            double expected = 0d;

            Assert.That(expected == Summator.Sum(new double[] { }));
        }

        [Test]
        public static void Test_Sum_BigValues()
        {
            double actual = Summator.Sum(new double[] { 1500000000, 2000000000 });
            double expected = 3500000000;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void Test_ArrayAverageNumber_When_ArrayLengthIsBiggerThanZero() 
        {
            double actual = Summator.ReturnAverageNumberFromArray(
                new double[] {10, 0, 5 });

            double expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void Test_ArrayAverageNumber_When_ArrayLengthIsZero()
        {
            double actual = Summator.ReturnAverageNumberFromArray(
                new double[] {});

            double expected = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}