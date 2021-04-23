using NUnit.Framework;
using System.Collections.Generic;

namespace PrimeFactorKata
{
    public class Tests
    {
        private List<int> List(params int[] ints)
        {
            List<int> list = new List<int>();
            foreach(int i in ints)
            {
                list.Add(i);
            }
            return list;
        }
        
        [SetUp]
        public void Setup()
        {
             
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void IsNotNull()
        {
            Assert.IsNotNull(PrimeFactor.Generate(1));
        }

        [Test]
        public void IsList()
        {
            Assert.AreEqual(List(), PrimeFactor.Generate(1));
        }

        [Test]
        public void testTwo()
        {
            Assert.AreEqual(List(2), PrimeFactor.Generate(2));
        }
        [Test]
        public void testThree()
        {
            Assert.AreEqual(List(3), PrimeFactor.Generate(3));
        }
        [Test]
        public void testFour()
        {
            Assert.AreEqual(List(2,2), PrimeFactor.Generate(4));
        }
        [Test]
        public void testSix()
        {
            Assert.AreEqual(List(2, 3), PrimeFactor.Generate(6));
        }
        [Test]
        public void testEight()
        {
            Assert.AreEqual(List(2, 2, 2), PrimeFactor.Generate(8));
        }
        [Test]
        public void testNine()
        {
            Assert.AreEqual(List(3,3), PrimeFactor.Generate(9));
        }
        [Test]
        public void test60()
        {
            Assert.AreEqual(List(2, 2, 3, 5), PrimeFactor.Generate(60));
        }
        [Test]
        public void Sanity()
        {
            Assert.AreEqual(List(2, 2, 3, 5,7,11,17), PrimeFactor.Generate(78540));
        }
    }
}