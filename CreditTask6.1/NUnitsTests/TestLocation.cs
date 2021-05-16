using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Passtask2._3
{
    class TestLocation
    {
        Location _location;
        Player _player;
        Item _apple;
        [SetUp]
        public void Setup()
        {
            _apple = new Item(new string[] { "apple" }, "Apple", "A delicious red fruit");
            _location = new Location(new string[] { "Swinburne" }, "Swinburne Univeristy", "A place of learning");
        }

        [Test]
        public void TestIdentifiableLocation()
        {
            Assert.IsTrue(_location.AreYou("swinburne"));
        }

        [Test]
        public void TestLocationHasItems()
        {
            _location.Inventory.Put(_apple);
            Assert.AreEqual(_location.Locate("apple"), _apple);
        }

        [Test]
        public void TestLocationDescription()
        {
            Assert.AreEqual("You are at " + _location.Name + "\n" + "A place of learning" + _location.ShortDescription + "\nYou can see: \n " + _location.Inventory.ItemList, _location.FullDescription);
        }
    }
}
