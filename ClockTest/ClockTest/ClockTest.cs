using NUnit.Framework;

namespace Clock.Tests
{
    [TestFixture]
    internal class ClockTest
    {
        private Clock _clock;

        [SetUp]
        public void Setup()
        {
            _clock = new Clock();
        }

        [Test]
        public void TestObjectExists()
        {
            Assert.IsNotNull(_clock);
        }

        [Test]
        public void TestReset()
        {
            _clock.Reset();
            Assert.That(_clock.GetTime(), Is.EqualTo("00:00:00"));
        }

        [Test]
        public void TestCounterInit()
        {
            Assert.That(_clock.GetTime(), Is.EqualTo("00:00:00"));
        }

        [TestCase(1, "00:00:01")]
        [TestCase(60, "00:01:00")]
        [TestCase(3600, "01:00:00")]
        [TestCase(86400, "00:00:00")]
        public void TestMultipleIncrements(int increments, string expectedTime)
        {
            _clock.Reset();
            for (int i = 0; i < increments; i++)
            {
                _clock.Tick();
            }

            Assert.That(_clock.GetTime(), Is.EqualTo(expectedTime));
        }
    }
}
