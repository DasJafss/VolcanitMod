using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Materials.Bars
{
	public class CursedBar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cursed Bar");
		}

		public override void SetDefaults() 
		{
			item.width = 30;
			item.height = 24;
			item.value = 2000;
			item.rare = 9;
			item.maxStack = 99;
			item.useStyle = 1;
			item.useTime = 10;
			item.useAnimation = 15;
			item.consumable = true;
			item.createTile = mod.TileType("CursedIngot");
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Cursed", 5);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}