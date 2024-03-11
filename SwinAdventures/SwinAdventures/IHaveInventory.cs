using System;
using System.Collections.Generic;

namespace SwinAdventures
{

		public interface IHaveInventory
		{
			GameObject Locate(string id);
			string Name
			{
				get;
			}
		}
}