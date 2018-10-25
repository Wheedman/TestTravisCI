using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TravisCI;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Program program = new Program();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(program.multiplication(1, 2), 2);
        }
    }
}
