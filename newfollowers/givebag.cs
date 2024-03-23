using newfollowers.Items;
using Terraria;
using System.Collections.Generic;
using Terraria.ModLoader;

namespace newfollowers
{
	public class givebag : ModPlayer
	{
		public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath) {
			return new[] {
				new Item(ModContent.ItemType<grabbag1>(), 1),
				new Item(ModContent.ItemType<grabbag2>(), 1),
				new Item(ModContent.ItemType<grabbag3>(), 1)
			};
		}
	}
}