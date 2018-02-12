using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTestsProject;
using Xunit;

namespace xUnitTests
{
    
    public class Tests
    {
        [Fact]
        public void TestCircleSquare()
        {
            var center = new Point(0, 0);
            var circle = new Circle(center, 10);
            Assert.Equal(314, circle.GetSquare());
        }

        [Fact]
        public void TestCircleLength()
        {
            var center = new Point(0, 0);
            var circle = new Circle(center, 10);
            Assert.Equal(62.8, circle.GetLength());
        }
    }


}
