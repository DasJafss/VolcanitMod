using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class SandscaleChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sandscale Breastplate");
			Tooltip.SetDefault("Smells like dust.");
		}
		public override void SetDefaults()
		{
		item.width = 18;
		item.height = 18;
		item.value = 10000;
		item.rare = 8;
		item.defense = 25;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SandScale", 30);
			recipe.AddIngredient(ItemID.SpectreBar, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}