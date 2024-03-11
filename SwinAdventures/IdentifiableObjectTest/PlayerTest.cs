using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace SwinAdventures
{
    public class TestPlayer
    {
        private Player _player;
        private Item _shovel;
        private Item _sword;

        [SetUp]
        public void Setup()
        {
            _player = new Player("Wilma", "Swinnie student");
            _shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
            _sword = new Item(new string[] { "sword" }, "a sword", "This is a Sword");
        }
    
        [Test]
        public void TestObjectExists()
        {
            Assert.IsNotNull(_player);
        }


        [Test]
        public void TestPlayerLocateItems()
        {
            _player.Inventory.Put(_shovel);
            Assert.That(_player.Locate("shovel"), Is.EqualTo(_shovel));
        }

        [TestCase("me")]
        [TestCase("inventory")]
        public void TestPlayerIdentifiable(string id)
        {
            Assert.IsTrue(_player.AreYou(id));
        }

        [TestCase("me")]
        [TestCase("inventory")]
        public void TestPlayerLocateItself(string id)
        {
            Assert.That(_player.Locate(id), Is.EqualTo(_player));
        }
        
        [Test]
        public void TestPlayerLocateNothing()
        {
            Assert.That(_player.Locate("gun"), Is.EqualTo(null));
        }

        [Test]
        public void TestPlayerFullDescription()
        {
            _player.Inventory.Put(_shovel);
            _player.Inventory.Put(_sword);
            Assert.That(_player.FullDescription, Is.EqualTo("Wilma, Swinnie student.\nYou are carrying:\na shovel (shovel)\na sword (sword)\n"));
        }
    }
}