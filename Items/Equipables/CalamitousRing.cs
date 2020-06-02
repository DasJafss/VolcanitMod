using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Items.Equipables
{
	public class CalamitousRing : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Calamitous Ring");
			Tooltip.SetDefault("When below 10% health, damage is increased by 60%.");
		}
		public override void SetDefaults()
		{
		item.width = 32;
		item.height = 28;
		item.value = 10000;
		item.rare = 12;
		item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual) {
			int calahealth = player.statLifeMax / 10;
			if (calahealth>player.statLife)
				player.allDamage*=1.6f;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CalamitousBar", 15);
			recipe.AddTile(null, "VolcanitAnvils");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}