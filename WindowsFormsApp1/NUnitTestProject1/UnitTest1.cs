using NUnit.Framework;
using System;
using WindowsFormsApp1;

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
            var a = new Sum();

            Assert.isEqual(a != null);

        }
    }
}