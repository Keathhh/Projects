using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace SwinAdventures
{
	public class LookCommandTest
	{
		Command look;
		Player player, player1;
		Bag bag;

		Item gem = new Item(new string[] { "gem" }, "a gem", "This is a gem");
		Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");
		Item shield = new Item(new string[] {"shield"}, "a shield", "This is a shield");

		[SetUp]
		public void SetUp()
		{
			look = new LookCommand();
			player = new Player("Wilma", "Wilma of legend");
			bag = new Bag(new string[] {"bag"},
				"wilma's bag",
				$"This is {player.FirstID} bag");
			player.Inventory.Put(bag);

			player1 = new Player("Wilma", "Wilma of legend");

		}

        [Test]
        public void TestLookAtMe()
        {
            string output = look.Execute(player, new string[] { "look", "at", "me" });
            string exp = $"{player.FullDescription}";
            Assert.That(exp, Is.EqualTo(output));
        }

		[Test]
		public void TestLookAtUnk()
		{
			string output = look.Execute(player, new string[] { "look", "at", "gem" });
			string exp = "Cannot find gem";
			Assert.That(exp, Is.EqualTo(output));
		}


        [Test]
        public void TestLookAtGem()
        {
            player.Inventory.Put(gem);

            string output = look.Execute(player, new string[] { "look", "at", "gem" });
            string exp = gem.FullDescription;
            Assert.That(output, Is.EqualTo(exp));
        }


        [Test]
		public void TestLookAtGemInMe()
		{
			player.Inventory.Put(gem);
			string Output = look.Execute(player, new string[] { "look", "at", "gem", "in", "me" });
			string exp = $"{gem.FullDescription}";
			Assert.That(exp, Is.EqualTo(Output));
		}

		[Test]
		public void TestLookAtGemInBag()
		{
			bag.Inventory.Put(gem);
			string Output = look.Execute(player, new string[] { "look", "at", "gem", "in", $"bag" });
			string exp = $"This is a gem";
			Assert.That(Output, Is.EqualTo(exp));
		}

        [Test]
        public void TestLookAtNoGemInBag()
        {
            string output = look.Execute(player, new string[] { "look", "at", "gem", "in", "bag" });
            string exp = $"Cannot find gem";
            Assert.That(exp, Is.EqualTo(output));
        }


        [Test]
        public void TestInvalidLook()
        {
            Assert.That(look.Execute(player1, new string[] { "look", "around" }), Is.EqualTo("Error in look input."));
            Assert.That(look.Execute(player1, new string[] { "find", "gem" }), Is.EqualTo("Error in look input."));
        }

    }
}

