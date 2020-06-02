using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Tools.Axes
{
	public class CrystalAxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Fiaryite Axe");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.melee = true;
			item.width = 36;
			item.axe = 40;
			item.height = 40;
			item.useTime = 7;
			item.useAnimation = 7;
			item.crit = 3;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CrystalBar", 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}