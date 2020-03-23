using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class SandscaleLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sandscale Leggings");
			Tooltip.SetDefault("Smells gritty.");
		}
		public override void SetDefaults()
		{
		item.width = 18;
		item.height = 18;
		item.value = 10000;
		item.rare = 8;
		item.defense = 18;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SandScale", 18);
			recipe.AddIngredient(ItemID.SpectreBar, 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}