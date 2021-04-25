using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Passtask2._3
{
    public class TestBag
    {
        Bag _bag1, _bag2;
        Item _apple, _sword;
        [SetUp]
        public void Setup()
        {
            _bag1 = new Bag(new string[] { "b1", "magicBag" }, "Bag'o'holding", "A most marvelous magical bag");
            _apple = new Item(new string[] { "apple" }, "Apple", "A delicious red fruit");
            _sword = new Item(new string[] { "sword" }, "Bronze Sword", "A poorly made bronze sword");
            _bag2 = new Bag(new string[] { "b2", "mundaneBag"}, "Backpack", "A disappointingly mundane backpack");
            _bag1.Inventory.Put(_apple);
            _bag2.Inventory.Put(_sword);
        }

        [Test]
        public void TestBagLocates()
        {
            Assert.AreEqual(_bag1, _bag1.Locate("b1"));
            Assert.AreEqual(_apple, _bag1.Locate("apple"));

        }
        [Test]
        public void TestBagLocatesSelf()
        {
            Assert.AreEqual(_bag1, _bag1.Locate("magicBag"));
            Assert.AreEqual(_bag1, _bag1.Locate("b1"));

        }
        [Test]
        public void testBagLocatesNothing()
        {
            Assert.AreEqual(null, _bag1.Locate("Nothing"));
        }
        [Test]
        public void testBagFullDescription()
        {
            Assert.AreEqual($"In the { _bag1.Name} you can see: {_bag1.Inventory.ItemList}",_bag1.FullDescription);
        }
        [Test]
        public void testBagInBag()
        {
            _bag1.Inventory.Put(_bag2);
            Assert.AreEqual(_bag2, _bag1.Locate("b2"));
            Assert.AreEqual(_apple, _bag1.Locate(_apple.FirstID));
            Assert.IsNull(_bag1.Locate("sword"));

        }


    }
}
