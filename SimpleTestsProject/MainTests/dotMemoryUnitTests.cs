using System.Linq;
using JetBrains.dotMemoryUnit;
using NUnit.Framework;

namespace MainTests
{
    public class dotMemoryUnitTests
    {
        [Test]
        public void Test1()
        {
            dotMemory.Check(memory =>
            {
                var group = memory.GroupByType();
                var largeTypes = group.Where(typeMemoryInfo =>
                    typeMemoryInfo.SizeInBytes > 1000000).ToList();

                // do sth. with largeTypes                
            });            
        }


        [Test]
        public void Test2()
        {
            var checkPoint1 = dotMemory.Check();

            // do sth.

            dotMemory.Check(memory =>
            {
                var traffic = memory.GetTrafficFrom(checkPoint1);
                var group = traffic.GroupByType();

                var heavyTrafficTypes =
                    group.Where(typeMemoryInfo => typeMemoryInfo.AllocatedMemoryInfo.SizeInBytes > 1000000).ToList();

                // do sth. with largeTypes                
            });            
        }
    }
}