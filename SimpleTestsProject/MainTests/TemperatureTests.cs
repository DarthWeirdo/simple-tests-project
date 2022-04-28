// using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using SimpleTestsProject;
using Assert = NUnit.Framework.Assert;

namespace MainTests
{
    [TestFixture]
    class TemperatureTests
    {
        [Test]
        public void TestTemperatureF()
        {
            var t = new Temperature {C = 100};
            Assert.AreEqual(212, t.F);
        }

        [Test]
        public void TestTemperatureK()
        {
            var t = new Temperature {C = 100};
            Assert.AreEqual(273, t.K);
        }
    }
}