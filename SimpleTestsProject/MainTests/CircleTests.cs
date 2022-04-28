using NUnit.Framework;
using SimpleTestsProject;
using Assert = NUnit.Framework.Assert;

//using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace MainTests
{
    // [TestClass]
    // public class Tests
    // {
    //     [TestMethod]
    //     public void TestCircleSquare()
    //     {
    //         var center = new Point(0, 0);
    //         var circle = new Circle(center, 10);
    //         Assert.AreEqual(314, circle.GetSquare());
    //     }
    //
    //     [TestMethod]
    //     public void TestCircleLength()
    //     {
    //         var center = new Point(0, 0);
    //         var circle = new Circle(center, 10);
    //         Assert.AreEqual(62.8, circle.GetLength());
    //     }
    // }


    [TestFixture]
    class CircleTests
    {
        [Test]
        public void TestCircleLength()
        {
            var center = new Point(0, 0);
            var circle = new Circle(center, 10);
            Assert.AreEqual(62.8, circle.GetLength(), 0.1);
        }

        [Test]
        public void TestCircleSquare()
        {
            var center = new Point(0, 0);
            var circle = new Circle(center, 10);
            Assert.AreEqual(314, circle.GetSquare());
        }
    }
}
