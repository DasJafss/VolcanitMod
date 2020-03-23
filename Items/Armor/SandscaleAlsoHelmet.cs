using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SandscaleAlsoHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sandscale Helmet");
			Tooltip.SetDefault("Smells like how sand tastes.");
		}
		public override void SetDefaults()
		{
		item.width = 18;
		item.height = 18;
		item.value = 10000;
		item.rare = 8;
		item.defense = 18;
		}

		public override bool DrawHead() {
			return false;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SandScale", 23);
			recipe.AddIngredient(ItemID.SpectreBar, 14);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}