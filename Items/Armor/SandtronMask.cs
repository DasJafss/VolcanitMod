using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SandtronMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dune Eater Mask");
		}
		public override void SetDefaults()
		{
		item.width = 28;
		item.height = 22;
		item.value = 10000;
		item.rare = 5;
		item.vanity = true;
		}

		public override bool DrawHead() {
			return false;
		}
	}
}