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
        public void TestInitialiseCounterToZero()
        {
            Assert.AreEqual(0, _testCounter.Ticks);
        }

        [Test]
        public void testCounterName()
        {
            Assert.AreEqual("TEST COUNTER", _testCounter.Name);
        }

        [TestCase(1, 1)]
        [TestCase(10, 10)]
        public void TestIncrementingCounter(int increments, int expectedResult)
        {
            for(int i = 0; i < increments; i++)
            {
                _testCounter.Increment();
            }            
            Assert.AreEqual(expectedResult, _testCounter.Ticks);
        }

        [Test]
        public void TestCounterReset()
        {
            _testCounter.Increment();
            _testCounter.Reset();
            Assert.AreEqual(0, _testCounter.Ticks);
        }
    }
}