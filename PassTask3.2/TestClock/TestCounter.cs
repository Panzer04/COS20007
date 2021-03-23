using NUnit.Framework;

namespace PassTask3._2
{
    public class TestCounter
    {
        Counter _testCounter;
        [SetUp]
        public void Setup()
        {
            _testCounter = new Counter("TEST COUNTER");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void TestInitialiseCounterToZero()
        {
            Setup();
            Assert.AreEqual(0, _testCounter.Ticks);
        }

        [Test]
        public void TestIncrementingCounter()
        {
            Setup();
            _testCounter.Increment();
            Assert.AreEqual(1, _testCounter.Ticks);
        }

        [Test]
        public void TestIncrementingCounterMultipleTimes()
        {
            Setup();
            _testCounter.Increment();
            _testCounter.Increment();
            _testCounter.Increment();
            Assert.AreEqual(3, _testCounter.Ticks);
        }

        [Test]
        public void TestCounterReset()
        {
            Setup();
            _testCounter.Increment();
            _testCounter.Reset();
            Assert.AreEqual(0, _testCounter.Ticks);
        }
    }
}