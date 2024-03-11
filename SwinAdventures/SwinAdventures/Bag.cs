using System;
using System.Xml.Linq;

namespace SwinAdventures
{
	public class Bag : Item, IHaveInventory
	{

		private Inventory _inventory;

		public Bag(string[] idents, string name, string desc) :
			base(idents, name, desc)
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
				return Inventory.Fetch(id);
			}
		}

		public override string FullDescription
		{
			get
			{
				return $"{Name}, containing:\n" + _inventory.ItemList;
			}
	
		}

		public Inventory Inventory
		{
			get => _inventory;
		}
	}	
}

