using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class MaskOfJafss : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mask of Jafss");
			Tooltip.SetDefault("The mask of Jafss, dropped by the Eye of Jafss.");
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