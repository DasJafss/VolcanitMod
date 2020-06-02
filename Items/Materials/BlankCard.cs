using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Materials
{
	public class BlankCard : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Blank Card");
			Tooltip.SetDefault("Can be crafted into other cards");
		}

		public override void SetDefaults() 
		{
			item.width = 30;
			item.height = 36;
			item.value = 10000;
			item.rare = 5;
			item.maxStack = 99;
		}
	}
}