using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MwosPrinters.Core.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //test should not use logic
            Assert.AreEqual(4, 1 + 3, "1 + 3 does not equal 4 in our code!!");
        }
    }
}
