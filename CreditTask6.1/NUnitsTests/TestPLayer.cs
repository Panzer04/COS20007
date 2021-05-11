using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Passtask2._3
{
    public class TestPLayer
    {
        Player _player;
        Item _apple;
        Item _sword;
        Item _book;
        Location _location;

        [SetUp]
        public void setup()
        {
            _apple = new Item(new string[] { "apple" }, "Apple", "A delicious red fruit");
            _sword = new Item(new string[] { "sword" }, "Bronze Sword", "A poorly made bronze sword");
            _book = new Item(new string[] { "book" }, "A book", "A dense tome");
            _location = new Location(new string[] { "swinburne" }, "Swinburne University", "A place of learning");
            _location.Inventory.Put(_book);
            _player = new Player("Panzer04", "A vistitor to a strange and unfamiliar land", _location);
            _player.Inventory.Put(_apple);
            _player.Inventory.Put(_sword);
        }

        [Test]
        public void PlayerIsIdentifiable()
        {
            Assert.IsTrue(_player.AreYou("me"));
            Assert.IsTrue(_player.AreYou("inventory"));
        }

        [Test]
        public void TestPlayerLocate()
        {
            Assert.AreEqual(_apple, _player.Locate("apple"));
        }

        [Test]
        public void TestPlayerLocateSelf()
        {
            Assert.AreEqual(_player, _player.Locate("me"));
            Assert.AreEqual(_player, _player.Locate("inventory"));
        }

        [Test]
        public void TestPlayerLocateNothing()
        {
            Assert.AreEqual(null, _player.Locate("NonexisentID"));
        }

        [Test]
        public void TestPlayerFullDescription()
        {
            Assert.AreEqual($"You are {_player.Name} A vistitor to a strange and unfamiliar land\n You are carrying: \n {_player.Inventory.ItemList}", _player.FullDescription);
        }

        [Test]
        public void TestPlayerCanFindLocationItem()
        {
            Assert.AreEqual(_book, _player.Locate("book"));
        }

        
    }
}
