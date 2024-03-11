using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace SwinAdventures
{
    public class BagTest
    {
        Bag b;
        Bag b1;
        Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
        Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");
        Item shield = new Item(new string[] { "shield" }, "a shield", "This is a shield");
        Item potion = new Item(new string[] { "potion" }, "a potion", "This is a potion");

        [SetUp]
        public void Setup()
        {
            b = new Bag(new string[] { "bag" }, "a bag", "This is a bag");
            b1 = new Bag(new string[] { "bag 1" }, "bag 1", "This is bag 1");
            b.Inventory.Put(shovel); b.Inventory.Put(sword);
            b1.Inventory.Put(potion); b1.Inventory.Put(potion);
        }

        [SetUp]
        public void SetUp()
        {
            b = new Bag(new string[] { "bag" }, "a bag", "This is a bag");
            b1 = new Bag(new string[] { "bag 1" }, "bag 1", "This is a bag1");
            b.Inventory.Put(shovel); b.Inventory.Put(sword);
            b1.Inventory.Put(shield); b1.Inventory.Put(potion);
        }

        [Test]
        public void TestBagLocatesItem()
        {
            b.Inventory.Take(sword.FirstID);
            Assert.IsFalse(b.Inventory.HasItem("sword"));
            Assert.IsTrue(b.Inventory.HasItem("shovel"));

            Assert.IsFalse(b.Locate(sword.FirstID) == sword);
            Assert.IsTrue(b.Locate(shovel.FirstID) == shovel);
        }

        [Test]
        public void TestBagLocateItself()
        {
            Assert.IsTrue(b.Locate(b.FirstID) == b);
            Assert.IsTrue(b.Locate("bag") == b);
        }

        [Test]
        public void TestBagLocateNothing()
        {
            Assert.IsTrue(b.Locate(shield.FirstID) == null);
        }

        [Test]
        public void TestBagFullDesc()
        {
            Assert.AreEqual(b.FullDescription, "a bag, containing:\na shovel (shovel)\na sword (sword)\n");
        }

        [Test]
        public void TestBagInBag()
        {
            b.Inventory.Put(b1);
            Assert.IsTrue(b.Locate("bag 1") == b1);
            Assert.IsTrue(b.Locate("sword") == sword);
            Assert.IsFalse(b.Locate("potion") == potion);

            Assert.That(b.Locate("bag 1"), Is.EqualTo(b1));
            Assert.That(b.Locate("sword"), Is.EqualTo(sword));
            Assert.That(b1.Locate("potion"), Is.EqualTo(potion));


        }

    }
}

