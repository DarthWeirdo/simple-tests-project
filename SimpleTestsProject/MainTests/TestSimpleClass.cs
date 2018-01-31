using NUnit.Framework;

namespace MainTests
{
    [TestFixture]
    public class TestSimpleClass
    {
        [Test]
        public void TestSimpleClassCtor()
        {
            var sc = new SimpleTestsProject.SimpleClass(0);
            Assert.AreEqual(sc.I, 0);
        }
    }
}