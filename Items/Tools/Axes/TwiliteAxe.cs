using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Tools.Axes
{
	public class TwiliteAxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Twilite Axe");
		}

		public override void SetDefaults() 
		{
			item.damage = 150;
			item.melee = true;
			item.width = 46;
			item.axe = 75;
			item.height = 52;
			item.useTime = 15;
			item.useAnimation = 15;
			item.crit = 3;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "TwiliteBar", 23);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}