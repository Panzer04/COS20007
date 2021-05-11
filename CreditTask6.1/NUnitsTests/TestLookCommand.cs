using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Passtask2._3
{
    public class TestLookCommand
    {
        LookCommand _look;
        Player _player;
        Item _gem;
        Item _book;
        string _gemDescription = "A pretty gem";
        Location _location;

        [SetUp]
        public void Setup()
        {
            
            _gem = new Item(new string[] { "gem" }, "Gem", _gemDescription);
            _book = new Item(new string[] { "book" }, "A book", "A dense tome");
            _location = new Location(new string[] { "swinburne" }, "Swinburne University", "A place of learning");
            _location.Inventory.Put(_book);
            _player = new Player("Panzer04", "the player", _location);
            _player.Inventory.Put(_gem);
            _look = new LookCommand();
            
        }
        [Test]
        public void TestIsLookCommandIdentifiable()
        {
            Assert.IsTrue(_look.AreYou("look"));
        }

        [Test]
        public void TestLookAtMe()
        {
            Assert.AreEqual(_player.FullDescription,_look.Execute(_player, new string[] {"look", "at", "inventory"}));
        }

        [Test]
        public void TestLookAtGem()
        {
            Assert.AreEqual(_gemDescription, _look.Execute(_player, new string[] { "look", "at", "gem"}));
        }

        [Test]
        public void TestLookAtUnknown()
        {
            _player.Inventory.Take("gem");
            Assert.AreEqual("I can't find the gem", _look.Execute(_player, new string[] { "look", "at", "gem" }));
        }

        [Test]
        public void TestLookAtGemInMe()
        {
            Assert.AreEqual(_gemDescription, _look.Execute(_player, new string[] { "look", "at", "gem", "in", "inventory" }));
        }

        [Test]
        public void TestLookAtGemInBag()
        {
            Bag bag = new Bag(new string[] { "bag" }, "bag", "a bag");
            bag.Inventory.Put(_gem);
            _player.Inventory.Put(bag);
            Assert.AreEqual(_gemDescription, _look.Execute(_player, new string[] { "look", "at", "gem", "in", "bag" }));
        }

        [Test]
        public void TestLookAtGemInNoBag()
        {
            Assert.AreEqual("I can't find the bag", _look.Execute(_player, new string[] { "look", "at", "gem", "in", "bag" }));
        }

        [Test]
        public void TestLookAtNoGemInBag()
        {
            Bag bag = new Bag(new string[] { "bag" }, "bag", "a bag");
            _player.Inventory.Put(bag);
            Assert.AreEqual("I can't find the gem", _look.Execute(_player, new string[] { "look", "at", "gem", "in", "bag" }));
        }

        [Test]
        public void TestValidLook()
        {
            string invalidSizeError = "I don't know how to look like that";
            string lookError = "Error in look input";
            Assert.AreEqual(invalidSizeError, _look.Execute(_player, new string[] { }));
            Assert.AreEqual(invalidSizeError, _look.Execute(_player, new string[] { "a", "b", "c", "d"}));
            Assert.AreEqual(invalidSizeError, _look.Execute(_player, new string[] {"a" }));
            Assert.AreEqual(lookError, _look.Execute(_player, new string[] { "a", "b", "c" }));
        }

        [Test]
        public void TestLookInLocation()
        {
            string lookInLocation = "look at book";
            string[] lookInLocationArr = lookInLocation.Split(" ");
            Assert.AreEqual(_book.FullDescription,_look.Execute(_player, lookInLocationArr));
        }
    }
}
