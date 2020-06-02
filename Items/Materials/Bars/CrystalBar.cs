using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Materials.Bars
{
	public class CrystalBar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Fiaryite Bar");
		}

		public override void SetDefaults() 
		{
			item.width = 30;
			item.height = 24;
			item.value = 2000;
			item.rare = 8;
			item.maxStack = 99;
			item.useStyle = 1;
			item.useTime = 10;
			item.useAnimation = 15;
			item.consumable = true;
			item.createTile = mod.TileType("CrystalIngot");
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CrystalOre", 4);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}