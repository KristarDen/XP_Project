using NUnit.Framework;
using System;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ArabianCalculatorTest()
        {
            Random rnd = new Random();

            decimal Num1 = rnd.Next(-100, 100);
            decimal Num2 = rnd.Next(-100, 100);

            ushort operation = rnd()

            Assert.Pass();
        }
    }
}