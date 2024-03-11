using System;
using System.Collections.Generic;

namespace SwinAdventures
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your name: ");
            string playerName = Console.ReadLine();

            Console.WriteLine("Enter your description:");
            string playerDescription = Console.ReadLine();

            Player player = new Player(playerName, playerDescription);

            Item shovel = new Item(new string[] { "shovel" }, "a shovel", "This is a shovel");
            Item sword = new Item(new string[] { "sword" }, "a sword", "This is a sword");
            Item shield = new Item(new string[] { "shield" }, "a shield", "This is a shield");

            Bag bag = new Bag(new string[] { $"bag" }, $"{playerName}'s bag", $"This is {playerName}'s bag");
            player.Inventory.Put(shovel);
            player.Inventory.Put(sword);
            player.Inventory.Put(bag);
            bag.Inventory.Put(shield);


            string _input;
            Command l = new LookCommand();

            while (true)
            {
                Console.WriteLine("Enter Command: ");
                _input = Console.ReadLine();
                if (_input == "quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(l.Execute(player, _input.Split(" ")));
                }
            }
        }
    }
}


