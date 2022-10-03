using NUnit.Framework;
using System;

namespace Summator.Tests
{
    [TestFixture] // optional notation
    public class UnitTestsSummatorTests
    {
        private Summator summator;

        [SetUp]
        public void SetUp() 
        {
            summator = new Summator();
            Console.WriteLine("Test started here" + DateTime.Now.Ticks.ToString());
        }


        [Test]
        public void Test_Sum_TwoPositiveNumbers()
        {
            double actual = summator.Sum(new double[] { 5, 7 });
            double expected = 12d;

            Assert.That(expected == actual);
        }

        [Test]
        [Category("Critical")] // Test category will appear into the TestExplorer
        public void Test_Sum_OnePositiveNumber()
        {
            double actual = summator.Sum(new double[] { 5 });
            double expected = 5d;
            Assert.That(actual == expected);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            double actual = summator.Sum(new double[] { -5, -10 });
            double expected = -15d;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_SumTwoNumbers()
        {
            double expected = 120;

            Assert.That(expected == summator.Sum(new double[] { 120 }));
        }

        [Test]
        public void Sum_EmptyArray()
        {
            double expected = 0d;

            Assert.That(expected == summator.Sum(new double[] { }));
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            double actual = summator.Sum(new double[] { 1500000000, 2000000000 });
            double expected = 3500000000;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_ReturnArrayAverageNumber_When_ArrayLengthIsBiggerThanZero() 
        {
            double actual = summator.ReturnAverageNumberFromArray(
                new double[] {10, 0, 5 });

            double expected = 5;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_ReturnArrayAverageNumber_When_ArrayLengthIsZero()
        {
            double actual = summator.ReturnAverageNumberFromArray(
                new double[] {});

            double expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TearDown]
        public void TearDown() 
        {
            summator = null;
            Console.WriteLine("Test ended here " + DateTime.Now);
        }
    }
}