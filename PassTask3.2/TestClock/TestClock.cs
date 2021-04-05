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
            Assert.AreEqual("00:00:00", _clock.Time());
        }

        [TestCase(0, "00:00:00")] //Initialises to 0
        [TestCase(3700, "01:01:40")] //Checks hours and minutes
        [TestCase(86465, "00:01:05")] //Wraps around
        public void TestClockTick(int ticks, string expectedResult)
        {
            for(int i = 0; i < ticks; i++)
            {
                _clock.Tick();
            }
            Assert.AreEqual(expectedResult,_clock.Time(), "Clock didn't tick correctly"); 
        }

        [Test]
        public void testClockReset()
        {
            for(int i = 0; i < 3650; i++)
            {
                _clock.Tick();
            }
            _clock.Reset();
            Assert.AreEqual("00:00:00", _clock.Time(), "Clock reset didn't reset to 0");
        }
    }
}