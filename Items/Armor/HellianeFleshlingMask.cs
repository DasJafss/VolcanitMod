using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class HellianeFleshlingMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Helliane Fleshling Mask");
		}
		public override void SetDefaults()
		{
		item.width = 18;
		item.height = 18;
		item.value = 10000;
		item.rare = 5;
		item.vanity = true;
		}

		public override bool DrawHead() {
			return false;
		}
	}
}