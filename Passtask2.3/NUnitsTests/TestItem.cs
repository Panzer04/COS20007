using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Passtask2._3;

namespace Passtask2._3
{
    [TestFixture]
    public class TestItem
    {
        Item item;
        [SetUp]
        public void Setup()
        {
            string[] testStringArray = new string[] {"Sword"};
            string name = "Bronze Sword";
            string desc = "A poorly made bronze sword";
            item = new Item(testStringArray, name, desc);
        }
        [Test]
        public void TestIdentifiableItem()
        {
            Assert.IsTrue(item.AreYou("Sword"));
        }

        [Test]
        public void TestShortDescription()
        {
            Assert.AreEqual("A Bronze Sword (sword)", item.ShortDescription);
        }

        [Test]
        public void TestFullDescription()
        {
            Assert.AreEqual("A poorly made bronze sword", item.FullDescription);
        }

    }
}
