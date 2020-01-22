using NUnit.Framework;

namespace RegressionTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            int a = 7;
            int b = 7;
            int c = a + b;
            Assert.AreEqual(c, 14);
            Assert.Pass("Test Case Passed");
        }
    }
}
