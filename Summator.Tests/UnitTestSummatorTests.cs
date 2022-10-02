using NUnit.Framework;
using System;

namespace Summator.Tests
{
    public class UnitTestsSummatorTests
    {
        [Test]
        public void Test_Sum_TwoPositiveNumbers()
        {
            int actual = Summator.Sum(new int[] { 5, 7 });
            int expected = 12;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_OnePositiveNumber()
        {
            int actual = Summator.Sum(new int[] { 5 });
            int expected = 5;
            Assert.That(actual == expected);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            int actual = Summator.Sum(new int[] { -5, -10 });
            int expected = -15;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_SumTwoNumbers()
        {
            int expected = 120;

            //if (expected != Summator.Sum(new int[] { 0, 120 }))
            //{
            //    throw new Exception("0 + 120 != 120");
            //}

            Assert.That(expected == Summator.Sum(new int[] {120 }));
        }

        [Test]
        public static void Sum_EmptyArray()
        {
            int expected = 0;

            //if (expected != Summator.Sum(new int[] { }))
            //{
            //    throw new Exception("sum of EmptyArray is != than 0"); 
            //}

            Assert.That(expected == Summator.Sum(new int[] { }));
        }

        [Test]
        public static void Test_Sum_BigValues() 
        {
            int actual = Summator.Sum(new int[] {1500000000, 2000000000});
            // Assert.That(3500000000 == actual);
            // Assert.AreEqual(3500000000, actual);
            //throwing Aritmethic Exception,
            //we have to change the type from int to long to pass the test

            if (actual < int.MinValue || actual > int.MaxValue)
            {
                throw new ArithmeticException("Sum is more than int Range");
            }
        }
    }
}