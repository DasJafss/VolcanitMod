using Terraria;
using Terraria.ID;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Items.TileItems
{
	public class SunkenTreasure : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Sunken Treasure");
		}

		public override void SetDefaults() 
		{
			item.width = 42;
			item.height = 26;
			item.value = 1000;
			item.rare = 5;
			item.useStyle = 1;
			item.useTime = 10;
			item.useAnimation = 15;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.noUseGraphic = true;
			item.createTile = TileType<Tiles.SunkenTreasureTile>();
		}
	}
}