using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Tools.Axes
{
	public class ScarletAxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Scarlet Axe");
		}

		public override void SetDefaults() 
		{
			item.damage = 70;
			item.melee = true;
			item.width = 46;
			item.axe = 48;
			item.height = 52;
			item.useTime = 15;
			item.useAnimation = 15;
			item.crit = 3;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ScarletBar", 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}