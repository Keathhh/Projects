using System;
namespace SwinAdventures
{
	public class LookCommand : Command
	{
		public LookCommand():
			base(new string[] {"look"})
		{
		}

        public override string Execute(Player p, string[] text)
        {
			IHaveInventory _container;
			string _itemid;
			string error = "Error in look input.";

			if (text[0].ToLower() != "look")
				return error;

			switch (text.Length)
			{
				case 3:
					if (text[1].ToLower() != "at")
						return "What do you want to look at?";
					_container = p;
					_itemid = text[2];
					break;

				case 5:
					_container = FetchContainer(p, text[4]);
					if (_container == null)
						return "I cannot find " + text[4];
					_itemid = text[2];
					break;

				default:
					return error;
			}
			return LookAtIn(_itemid, _container);
        }

		private IHaveInventory FetchContainer(Player p, string containerID)
		{
			return p.Locate(containerID) as IHaveInventory;
		}

		private string LookAtIn(string thingsid, IHaveInventory container)
		{
			if (container.Locate(thingsid) != null)
				return container.Locate(thingsid).FullDescription;

			return "Cannot find " + thingsid;
		}
    }
}

