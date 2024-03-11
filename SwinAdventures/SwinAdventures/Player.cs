using System;
using System.Collections;
using System.Collections.Generic;

namespace SwinAdventures
{
    public class Player : GameObject, IHaveInventory
    {
        private Inventory _inventory;

        public Player(string name, string desc): base(new string[] {"me", "inventory"}, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            else
            {
                return _inventory.Fetch(id);
            }
            
        }

        public override string FullDescription
        {
            get
            {
                return $"{Name}, {base.FullDescription}.\n" + $"You are carrying:\n" + $"{_inventory.ItemList}";
            }
        }

        public Inventory Inventory
        {
            get => _inventory;
        }

    }
}

