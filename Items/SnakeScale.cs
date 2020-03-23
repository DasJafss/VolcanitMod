using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class SnakeScale : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Snake Scale");
		}

		public override void SetDefaults() 
		{
			item.width = 12;
			item.height = 10;
			item.value = 1000;
			item.rare = 7;
			item.maxStack = 999;
		}
	}
}