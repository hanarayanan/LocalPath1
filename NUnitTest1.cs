using System;
//using NUnit.Framework;
using WindowsServiceBAL;
using NUnit.Framework;

namespace NUnitTest
{
    [TestFixture]
    public class NUnitTest1
    {
      



        [Test]
        public void TestMethodNunit1()
        {
            
            int result = 20 + 1000;
            Assert.AreEqual(1020, result);
        }
    }

    [TestFixture]
    public class NUnitTest2
    {


        [Test]
        public void HelloCheck()
        {

            int result = 20 + 10900;
            Assert.AreEqual(10920, result);
        }
    }
}