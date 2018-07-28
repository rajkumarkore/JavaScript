using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Nunit
{
    [TestFixture]
    class MyTestCase
    {
        [TestCase]
        public void Add()
        {
            MyMath m = new MyMath();
            Assert.AreEqual(31, m.Add(10, 20));
        }
        [TestCase]
        public void Sub()
        {
            MyMath m = new MyMath();
            Assert.AreEqual(31, m.Sub(30, 20));
        }
    }
}