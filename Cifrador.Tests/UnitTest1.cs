using NUnit.Framework;

namespace Cifrador.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            ContainerBuilder.StartIoC();
            ContainerBuilder.ClearCache();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}