namespace SampleApp.UnitTests
{
    using NUnit.Framework;

    [TestFixture]
    public class TestSample
    {
        [Test]
        public void TestPass()
        {
            Assert.Pass("Yay!");
        }
    }
}
