using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.TileItems
{
	public class BrainBlockItem : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Brain Block");
		}

		public override void SetDefaults() 
		{
			item.width = 16;
			item.height = 16;
			item.value = 1000;
			item.rare = 2;
			item.useStyle = 1;
			item.useTime = 10;
			item.useAnimation = 15;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = mod.TileType("BrainBlock");
		}
	}
}