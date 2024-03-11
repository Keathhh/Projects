using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace SwinAdventures
{
    public class TestItem
    {
        private Item _item;

        [SetUp]
        public void Setup()
        {
            _item = new Item(new string[] { "sword", "shovel" }, "mythical sword", "rusty shovel");
        }

        [Test]
        public void TestItemIdentifiable()
        {
            Assert.IsTrue(_item.AreYou("sword"));
            Assert.IsFalse(_item.AreYou("katana"));
            Assert.IsTrue(_item.AreYou("shovel"));
        }

        [Test]
        public void TestShortDescription()
        {
            Assert.That(_item.ShortDescription, Is.EqualTo("mythical sword (sword)"));
            Assert.That(_item.ShortDescription, Is.Not.EqualTo("This is a shovel"));
        }

        [Test]
        public void TestFullDescription()
        {
            Assert.That(_item.FullDescription, Is.EqualTo("rusty shovel"));
            Assert.That(_item.FullDescription, Is.Not.EqualTo("a shovel"));
        }
    }
}
