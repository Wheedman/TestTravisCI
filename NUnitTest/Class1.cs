using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TravisCI;

namespace NUnitTest
{
    [TestFixture]
    public class Class1
    {
        private Program program = new Program();
        [Test]
        public void CalculationTest1()
        {
            Assert.AreEqual(program.multiplication(1, 2), 2);
        }

        [Test]
        public void CalculationTest2()
        {
            Assert.AreEqual(program.multiplication(1, 2), 4);
        }
    }
}
