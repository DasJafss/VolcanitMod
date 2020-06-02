using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Materials
{
	public class HeroSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Hero Sword");
			Tooltip.SetDefault("Originally found in the Jungle Temple by Jafss, it has since been kept by his eye. Utterly priceless.");
		}

		public override void SetDefaults() 
		{
			item.width = 104;
			item.height = 116;
			item.value = 50000;
			item.rare = 4;
			item.maxStack = 99;
		}
	}
}