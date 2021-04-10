using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Passtask2._3
{
    public class TestInventory
    {
        Inventory _inventory;
        Item _sword;
        Item _apple;
        Item _book;
        [SetUp]
        public void Setup()
        {
            _inventory = new Inventory();
            _sword = new Item(new string[] { "sword" }, "Bronze Sword", "A poorly made bronze sword");
            _apple = new Item(new string[] {"apple" }, "Apple", "A delicious red fruit");
            _book = new Item(new string[] {"book" }, "Book", "A mysterious book");
            _inventory.Put(_sword);
            _inventory.Put(_apple);
        }

        [Test]
        public void TestHasItem()
        {
            Assert.IsTrue(_inventory.HasItem("sword"));
            Assert.IsTrue(_inventory.HasItem("apple"));
        }

        [Test]
        public void testNoItemFound()
        {
            Assert.IsFalse(_inventory.HasItem("book"));
            Assert.IsFalse(_inventory.HasItem("Zeus"));
        }

        [Test]
        public void testFetch()
        {
            Assert.AreEqual(_apple, _inventory.Fetch("apple"));
            Assert.AreEqual(_sword, _inventory.Fetch("sword"));
        }

        [Test]
        public void testTake()
        {
            Assert.IsTrue(_inventory.HasItem("apple"));
            Assert.AreEqual(_apple, _inventory.take("apple"));
            Assert.IsFalse(_inventory.HasItem("apple"));
        }

        [Test]
        public void testItemList()
        {
            string itemListString = "\t" + _sword.ShortDescription + "\n\t" + _apple.ShortDescription +"\n";
            Assert.AreEqual(itemListString, _inventory.ItemList);
        }

    }
}
