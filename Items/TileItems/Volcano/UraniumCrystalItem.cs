using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.TileItems.Volcano
{
	public class UraniumCrystalItem : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Uranium Crystal");
		}

		public override void SetDefaults() 
		{
			item.width = 16;
			item.height = 16;
			item.value = 200;
			item.rare = 2;
			item.maxStack = 99;
		}
	}
}