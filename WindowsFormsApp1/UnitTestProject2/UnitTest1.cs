using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;


namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sum = new Sum();

            Assert.IsTrue(sum.SumAction("bf", "1") == 0);
            Assert.IsTrue(sum.SumAction("1", "bf") == 0);
            Assert.IsTrue(sum.SumAction("bf", "bf") == 0);

            Assert.IsTrue(sum.SumAction("2", "4") == decimal.Parse(6.ToString()));


        }
    }
}
