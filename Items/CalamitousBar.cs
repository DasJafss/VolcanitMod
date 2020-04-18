using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class CalamitousBar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Calamitous Bar");
		}

		public override void SetDefaults() 
		{
			item.width = 30;
			item.height = 24;
			item.value = 3000;
			item.rare = 12;
			item.maxStack = 99;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "TwiliteBar", 1);
			recipe.AddIngredient(null, "VolcaniteBar", 1);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}