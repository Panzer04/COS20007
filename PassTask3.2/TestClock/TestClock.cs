using NUnit.Framework;

namespace PassTask3._2
{
    public class TestClock
    {
        Clock _clock;
        [SetUp]
        public void Setup()
        {
            _clock = new Clock();
        }

        [Test]
        public void TestClockTimeFormat()
        {
            Assert.AreEqual("00:00:00",_clock.Time());
            
        }

        [Test]
        public void testClockReset()
        {
            for(int i = 0; i < 3650; i++)
            {
                _clock.Tick();
            }
            _clock.Reset();
            Assert.AreEqual("00:00:00", _clock.Time());
        }
    }
}